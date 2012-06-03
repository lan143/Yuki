using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Yuki.Complex;

namespace Yuki.StringFinder
{
    public partial class frmMain : Form
    {
        private string folder_patch = null;
        private string textMask = null;
        private List<string> StringList = new List<string>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog d = new FolderBrowserDialog();
            d.Description = "Выберите папку с sql файлами";
            d.SelectedPath = @"C:\";
            if (d.ShowDialog() == DialogResult.OK)
            {
                this.folder_patch = d.SelectedPath;
                this.btnStart.Enabled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Начать")
            {
                btnStart.Text = "Остановить";
                btnSelectFolder.Enabled = false;

                backgroundWorker1.RunWorkerAsync();
            }
            else
                backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            DirectoryInfo di = new DirectoryInfo(this.folder_patch);
            FileInfo[] fi = di.GetFiles("*.sql", SearchOption.AllDirectories);

            foreach (FileInfo f in fi)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }

                using (StreamReader sr = new StreamReader(f.FullName))
                {
                    while (!sr.EndOfStream)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            break;
                        }

                        string m_string = sr.ReadLine();
                        if (m_string.Length > this.textMask.Length)
                        {
                            string substring = m_string.Substring(0, this.textMask.Length);

                            if (substring.Equals(this.textMask))
                            {
                                if (!FindStringInList(m_string))
                                    this.StringList.Add(m_string);
                            }
                        }
                    }
                }
            }
        }

        private bool FindStringInList(string s)
        {
            foreach (String st in this.StringList)
                if (st.Equals(s))
                    return true;

            return false;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnStart.Text = "Начать";
            btnSelectFolder.Enabled = true;

            foreach (String m_string in this.StringList)
            {
                this.output.AppendText(m_string);
                this.output.AppendText("\r\n");
            }

            this.output.ColorizeCode();
        }

        private void boxMask_TextChanged(object sender, EventArgs e)
        {
            this.textMask = boxMask.Text;
        }
    }
}
