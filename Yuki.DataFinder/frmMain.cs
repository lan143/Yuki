using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Yuki.Complex;
using Yuki.Complex.Enums;
using Yuki.Complex.Structures;
using Yuki.WoW.Enums;

namespace Yuki.DataFinder
{
    public partial class frmMain : Form
    {
        struct resultList
        {
            public string filepatch;
            public uint line;
            public uint opcode;
        };

        private string folder_patch = null;
        private uint opcode = 0;
        private int counter = 0;
        private List<resultList> opcodelist = new List<resultList>(); 

        public frmMain()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void butFolderSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog d = new FolderBrowserDialog();
            d.Description = "Выберите папку с pkt файлами";
            d.SelectedPath = @"C:\";
            if (d.ShowDialog() == DialogResult.OK)
            {
                this.folder_patch = d.SelectedPath;
                this.buttonFind.Enabled = true;
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (buttonFind.Text == "Искать")
            {
                buttonFind.Text = "Отменить";
                butFolderSelect.Enabled = false;
                textBox1.Enabled = false;
                comboBox1.Enabled = false;
                progressBar1.Visible = true;
                this.listView1.Items.Clear();

                this.opcode = uint.Parse(this.textBox1.Text);

                backgroundWorker1.RunWorkerAsync();
            }
            else
                backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            DirectoryInfo di = new DirectoryInfo(this.folder_patch);
            FileInfo[] fi = di.GetFiles("*.pkt", SearchOption.AllDirectories);

            int count = 0;

            foreach (FileInfo f in fi)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }

                worker.ReportProgress(count * 100 / fi.Length);

                FileStream fs = new FileStream(f.FullName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                int selectedIndex = 0;

                if (comboBox1.InvokeRequired)
                    this.comboBox1.BeginInvoke(new Action(() => selectedIndex = comboBox1.SelectedIndex));
                else
                    selectedIndex = comboBox1.SelectedIndex;

                PktFileMainHeader MainHeader = new PktFileMainHeader();

                MainHeader = br.ReadStruct<PktFileMainHeader>();

                byte[] buffer = br.ReadBytes((int)MainHeader.OptionalHeaderLength);
                if (MainHeader.Signature[0] == 'P'
                    && MainHeader.Signature[1] == 'K'
                    && MainHeader.Signature[2] == 'T'
                    && MainHeader.MajorVersion == 3
                    && MainHeader.MinorVersion == 1)
                {
                    UInt32 counts = 0;

                    while (br.BaseStream.Position != br.BaseStream.Length)
                    {
                        try
                        {
                            if (worker.CancellationPending == true)
                            {
                                e.Cancel = true;
                                break;
                            }

                            string direct = Encoding.UTF8.GetString(br.ReadBytes(4));
                            var direction = (direct == "SMSG" ? Direction.ToServer : Direction.ToClient);
                            uint UnixTime = br.ReadUInt32();
                            uint tickCount = br.ReadUInt32();
                            int optionalHeaderLength1 = br.ReadInt32();
                            byte[] optionalData1 = new byte[optionalHeaderLength1];
                            int dataLength = br.ReadInt32();
                            byte[] data = new byte[dataLength];

                            optionalData1 = br.ReadBytes(optionalHeaderLength1);
                            data = br.ReadBytes(dataLength);

                            MemoryStream mss = new MemoryStream(data);
                            BinaryReader brr = new BinaryReader(mss);

                            uint opcodes = brr.ReadUInt32();
                            byte[] byteData = new byte[brr.BaseStream.Length - 4];

                            byteData = brr.ReadBytes((int)(brr.BaseStream.Length - 4));

                            if (selectedIndex == 0)
                            {
                                if (opcodes == (uint)WoWOpcodes.SMSG_NEW_WORLD)
                                    SMSG_NEW_WORLD(new BinaryReader(new MemoryStream(byteData)), f.FullName, counts);
                            }
                            else if (selectedIndex == 1)
                            {
                                if (opcodes == (uint)WoWOpcodes.CMSG_CREATURE_QUERY)
                                    CMSG_CREATURE_QUERY(new BinaryReader(new MemoryStream(byteData)), f.FullName, counts);
                            }
                            else if (selectedIndex == 2)
                            {
                                if (opcodes == (uint)WoWOpcodes.SMSG_INIT_WORLD_STATES)
                                    SMSG_INIT_WORLD_STATES(new BinaryReader(new MemoryStream(byteData)), f.FullName, counts);
                            }
                            counts++;
                        }
                        catch { }
                    }

                    br.Close();
                    fs.Close();
                    count++;
                }
            }
        }

        private void SMSG_NEW_WORLD(BinaryReader br, string filename, UInt32 count)
        {
            UInt32 mapid = br.ReadUInt32();
            if (mapid == this.opcode)
            {
                resultList rl = new resultList();
                rl.filepatch = filename;
                rl.line = count;
                rl.opcode = this.opcode;
                this.opcodelist.Add(rl);
                this.counter++;
                if (listView1.InvokeRequired)
                    listView1.BeginInvoke(new Action(() => listView1.Items.Add(new ListViewItem(new string[] { rl.filepatch, rl.line.ToString() }))));
                else
                    listView1.Items.Add(new ListViewItem(new string[] { rl.filepatch, rl.line.ToString() }));

                if (listView1.InvokeRequired)
                    listView1.BeginInvoke(new Action(() => listView1.Refresh()));
                else
                    listView1.Refresh();
            }
        }

        private void CMSG_CREATURE_QUERY(BinaryReader br, string filename, UInt32 count)
        {
            UInt32 creatureEntry = br.ReadUInt32();
            if (creatureEntry == this.opcode)
            {
                resultList rl = new resultList();
                rl.filepatch = filename;
                rl.line = count;
                rl.opcode = this.opcode;
                this.opcodelist.Add(rl);
                this.counter++;
                if (listView1.InvokeRequired)
                    listView1.BeginInvoke(new Action(() => listView1.Items.Add(new ListViewItem(new string[] { rl.filepatch, rl.line.ToString() }))));
                else
                    listView1.Items.Add(new ListViewItem(new string[] { rl.filepatch, rl.line.ToString() }));

                if (listView1.InvokeRequired)
                    listView1.BeginInvoke(new Action(() => listView1.Refresh()));
                else
                    listView1.Refresh();
            }
        }

        private void SMSG_INIT_WORLD_STATES(BinaryReader br, string filename, UInt32 count)
        {
            UInt32 mapid = br.ReadUInt32();
            UInt32 zoneid = br.ReadUInt32();
            if (zoneid == this.opcode)
            {
                resultList rl = new resultList();
                rl.filepatch = filename;
                rl.line = count;
                rl.opcode = this.opcode;
                this.opcodelist.Add(rl);
                this.counter++;
                if (listView1.InvokeRequired)
                    listView1.BeginInvoke(new Action(() => listView1.Items.Add(new ListViewItem(new string[] { rl.filepatch, rl.line.ToString() }))));
                else
                    listView1.Items.Add(new ListViewItem(new string[] { rl.filepatch, rl.line.ToString() }));

                if (listView1.InvokeRequired)
                    listView1.BeginInvoke(new Action(() => listView1.Refresh()));
                else
                    listView1.Refresh();
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            buttonFind.Text = "Искать";
            butFolderSelect.Enabled = true;
            textBox1.Enabled = true;
            comboBox1.Enabled = true;
            progressBar1.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    label1.Text = "Карта:";
                    break;
                case 1:
                    label1.Text = "Номер:";
                    break;
            }
        }
    }
}
