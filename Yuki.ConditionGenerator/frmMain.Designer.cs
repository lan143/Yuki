namespace Yuki.ConditionGenerator
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boxOutput = new System.Windows.Forms.GroupBox();
            this.lSourceTypeOrReferenceId = new System.Windows.Forms.Label();
            this.lSourceGroup = new System.Windows.Forms.Label();
            this.lSourceEntry = new System.Windows.Forms.Label();
            this.lElseGroup = new System.Windows.Forms.Label();
            this.lConditionTypeOrReference = new System.Windows.Forms.Label();
            this.lConditionTarget = new System.Windows.Forms.Label();
            this.lConditionValue1 = new System.Windows.Forms.Label();
            this.lConditionValue2 = new System.Windows.Forms.Label();
            this.lConditionValue3 = new System.Windows.Forms.Label();
            this.lNegativeCondition = new System.Windows.Forms.Label();
            this.lErrorTextId = new System.Windows.Forms.Label();
            this.lScriptName = new System.Windows.Forms.Label();
            this.lComment = new System.Windows.Forms.Label();
            this.cbSourceTypeOrReferenceId = new System.Windows.Forms.ComboBox();
            this.tbSourceGroup = new System.Windows.Forms.TextBox();
            this.tbSourceEntry = new System.Windows.Forms.TextBox();
            this.cbConditionTypeOrReference = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbConditionValue1 = new System.Windows.Forms.TextBox();
            this.tbConditionValue2 = new System.Windows.Forms.TextBox();
            this.tbConditionValue3 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tbErrorTextId = new System.Windows.Forms.TextBox();
            this.tbScriptName = new System.Windows.Forms.TextBox();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.tbElseGroup = new System.Windows.Forms.TextBox();
            this.tbSourceId = new System.Windows.Forms.TextBox();
            this.lSourceId = new System.Windows.Forms.Label();
            this.bGenerate = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.bClear = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.boxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bSave);
            this.groupBox1.Controls.Add(this.bClear);
            this.groupBox1.Controls.Add(this.bGenerate);
            this.groupBox1.Controls.Add(this.lSourceId);
            this.groupBox1.Controls.Add(this.tbSourceId);
            this.groupBox1.Controls.Add(this.tbElseGroup);
            this.groupBox1.Controls.Add(this.tbComment);
            this.groupBox1.Controls.Add(this.tbScriptName);
            this.groupBox1.Controls.Add(this.tbErrorTextId);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.tbConditionValue3);
            this.groupBox1.Controls.Add(this.tbConditionValue2);
            this.groupBox1.Controls.Add(this.tbConditionValue1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.cbConditionTypeOrReference);
            this.groupBox1.Controls.Add(this.tbSourceEntry);
            this.groupBox1.Controls.Add(this.tbSourceGroup);
            this.groupBox1.Controls.Add(this.cbSourceTypeOrReferenceId);
            this.groupBox1.Controls.Add(this.lComment);
            this.groupBox1.Controls.Add(this.lScriptName);
            this.groupBox1.Controls.Add(this.lErrorTextId);
            this.groupBox1.Controls.Add(this.lNegativeCondition);
            this.groupBox1.Controls.Add(this.lConditionValue3);
            this.groupBox1.Controls.Add(this.lConditionValue2);
            this.groupBox1.Controls.Add(this.lConditionValue1);
            this.groupBox1.Controls.Add(this.lConditionTarget);
            this.groupBox1.Controls.Add(this.lConditionTypeOrReference);
            this.groupBox1.Controls.Add(this.lElseGroup);
            this.groupBox1.Controls.Add(this.lSourceEntry);
            this.groupBox1.Controls.Add(this.lSourceGroup);
            this.groupBox1.Controls.Add(this.lSourceTypeOrReferenceId);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 439);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // boxOutput
            // 
            this.boxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.boxOutput.Controls.Add(this.Output);
            this.boxOutput.Location = new System.Drawing.Point(13, 458);
            this.boxOutput.Name = "boxOutput";
            this.boxOutput.Size = new System.Drawing.Size(677, 108);
            this.boxOutput.TabIndex = 1;
            this.boxOutput.TabStop = false;
            this.boxOutput.Text = "Output";
            // 
            // lSourceTypeOrReferenceId
            // 
            this.lSourceTypeOrReferenceId.AutoSize = true;
            this.lSourceTypeOrReferenceId.Location = new System.Drawing.Point(7, 20);
            this.lSourceTypeOrReferenceId.Name = "lSourceTypeOrReferenceId";
            this.lSourceTypeOrReferenceId.Size = new System.Drawing.Size(138, 13);
            this.lSourceTypeOrReferenceId.TabIndex = 0;
            this.lSourceTypeOrReferenceId.Text = "SourceTypeOrReferenceId:";
            // 
            // lSourceGroup
            // 
            this.lSourceGroup.AutoSize = true;
            this.lSourceGroup.Location = new System.Drawing.Point(7, 48);
            this.lSourceGroup.Name = "lSourceGroup";
            this.lSourceGroup.Size = new System.Drawing.Size(73, 13);
            this.lSourceGroup.TabIndex = 1;
            this.lSourceGroup.Text = "SourceGroup:";
            // 
            // lSourceEntry
            // 
            this.lSourceEntry.AutoSize = true;
            this.lSourceEntry.Location = new System.Drawing.Point(7, 75);
            this.lSourceEntry.Name = "lSourceEntry";
            this.lSourceEntry.Size = new System.Drawing.Size(68, 13);
            this.lSourceEntry.TabIndex = 2;
            this.lSourceEntry.Text = "SourceEntry:";
            // 
            // lElseGroup
            // 
            this.lElseGroup.AutoSize = true;
            this.lElseGroup.Location = new System.Drawing.Point(7, 342);
            this.lElseGroup.Name = "lElseGroup";
            this.lElseGroup.Size = new System.Drawing.Size(59, 13);
            this.lElseGroup.TabIndex = 4;
            this.lElseGroup.Text = "ElseGroup:";
            // 
            // lConditionTypeOrReference
            // 
            this.lConditionTypeOrReference.AutoSize = true;
            this.lConditionTypeOrReference.Location = new System.Drawing.Point(7, 102);
            this.lConditionTypeOrReference.Name = "lConditionTypeOrReference";
            this.lConditionTypeOrReference.Size = new System.Drawing.Size(139, 13);
            this.lConditionTypeOrReference.TabIndex = 5;
            this.lConditionTypeOrReference.Text = "ConditionTypeOrReference:";
            // 
            // lConditionTarget
            // 
            this.lConditionTarget.AutoSize = true;
            this.lConditionTarget.Location = new System.Drawing.Point(7, 130);
            this.lConditionTarget.Name = "lConditionTarget";
            this.lConditionTarget.Size = new System.Drawing.Size(85, 13);
            this.lConditionTarget.TabIndex = 6;
            this.lConditionTarget.Text = "ConditionTarget:";
            // 
            // lConditionValue1
            // 
            this.lConditionValue1.AutoSize = true;
            this.lConditionValue1.Location = new System.Drawing.Point(7, 157);
            this.lConditionValue1.Name = "lConditionValue1";
            this.lConditionValue1.Size = new System.Drawing.Size(87, 13);
            this.lConditionValue1.TabIndex = 7;
            this.lConditionValue1.Text = "ConditionValue1:";
            // 
            // lConditionValue2
            // 
            this.lConditionValue2.AutoSize = true;
            this.lConditionValue2.Location = new System.Drawing.Point(7, 184);
            this.lConditionValue2.Name = "lConditionValue2";
            this.lConditionValue2.Size = new System.Drawing.Size(87, 13);
            this.lConditionValue2.TabIndex = 8;
            this.lConditionValue2.Text = "ConditionValue2:";
            // 
            // lConditionValue3
            // 
            this.lConditionValue3.AutoSize = true;
            this.lConditionValue3.Location = new System.Drawing.Point(7, 211);
            this.lConditionValue3.Name = "lConditionValue3";
            this.lConditionValue3.Size = new System.Drawing.Size(87, 13);
            this.lConditionValue3.TabIndex = 9;
            this.lConditionValue3.Text = "ConditionValue3:";
            // 
            // lNegativeCondition
            // 
            this.lNegativeCondition.AutoSize = true;
            this.lNegativeCondition.Location = new System.Drawing.Point(7, 238);
            this.lNegativeCondition.Name = "lNegativeCondition";
            this.lNegativeCondition.Size = new System.Drawing.Size(97, 13);
            this.lNegativeCondition.TabIndex = 10;
            this.lNegativeCondition.Text = "NegativeCondition:";
            // 
            // lErrorTextId
            // 
            this.lErrorTextId.AutoSize = true;
            this.lErrorTextId.Location = new System.Drawing.Point(7, 265);
            this.lErrorTextId.Name = "lErrorTextId";
            this.lErrorTextId.Size = new System.Drawing.Size(62, 13);
            this.lErrorTextId.TabIndex = 11;
            this.lErrorTextId.Text = "ErrorTextId:";
            // 
            // lScriptName
            // 
            this.lScriptName.AutoSize = true;
            this.lScriptName.Location = new System.Drawing.Point(7, 292);
            this.lScriptName.Name = "lScriptName";
            this.lScriptName.Size = new System.Drawing.Size(65, 13);
            this.lScriptName.TabIndex = 12;
            this.lScriptName.Text = "ScriptName:";
            // 
            // lComment
            // 
            this.lComment.AutoSize = true;
            this.lComment.Location = new System.Drawing.Point(7, 319);
            this.lComment.Name = "lComment";
            this.lComment.Size = new System.Drawing.Size(54, 13);
            this.lComment.TabIndex = 13;
            this.lComment.Text = "Comment:";
            // 
            // cbSourceTypeOrReferenceId
            // 
            this.cbSourceTypeOrReferenceId.FormattingEnabled = true;
            this.cbSourceTypeOrReferenceId.Location = new System.Drawing.Point(282, 17);
            this.cbSourceTypeOrReferenceId.Name = "cbSourceTypeOrReferenceId";
            this.cbSourceTypeOrReferenceId.Size = new System.Drawing.Size(374, 21);
            this.cbSourceTypeOrReferenceId.TabIndex = 14;
            this.cbSourceTypeOrReferenceId.SelectedIndexChanged += new System.EventHandler(this.cbSourceTypeOrReferenceId_SelectedIndexChanged);
            // 
            // tbSourceGroup
            // 
            this.tbSourceGroup.Location = new System.Drawing.Point(282, 45);
            this.tbSourceGroup.Name = "tbSourceGroup";
            this.tbSourceGroup.Size = new System.Drawing.Size(374, 20);
            this.tbSourceGroup.TabIndex = 15;
            this.tbSourceGroup.Text = "0";
            // 
            // tbSourceEntry
            // 
            this.tbSourceEntry.Location = new System.Drawing.Point(282, 72);
            this.tbSourceEntry.Name = "tbSourceEntry";
            this.tbSourceEntry.Size = new System.Drawing.Size(374, 20);
            this.tbSourceEntry.TabIndex = 16;
            this.tbSourceEntry.Text = "0";
            // 
            // cbConditionTypeOrReference
            // 
            this.cbConditionTypeOrReference.FormattingEnabled = true;
            this.cbConditionTypeOrReference.Location = new System.Drawing.Point(282, 99);
            this.cbConditionTypeOrReference.Name = "cbConditionTypeOrReference";
            this.cbConditionTypeOrReference.Size = new System.Drawing.Size(374, 21);
            this.cbConditionTypeOrReference.TabIndex = 17;
            this.cbConditionTypeOrReference.SelectedIndexChanged += new System.EventHandler(this.cbConditionTypeOrReference_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(282, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(374, 20);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = "0";
            // 
            // tbConditionValue1
            // 
            this.tbConditionValue1.Location = new System.Drawing.Point(282, 154);
            this.tbConditionValue1.Name = "tbConditionValue1";
            this.tbConditionValue1.Size = new System.Drawing.Size(374, 20);
            this.tbConditionValue1.TabIndex = 19;
            this.tbConditionValue1.Text = "0";
            // 
            // tbConditionValue2
            // 
            this.tbConditionValue2.Location = new System.Drawing.Point(282, 181);
            this.tbConditionValue2.Name = "tbConditionValue2";
            this.tbConditionValue2.Size = new System.Drawing.Size(374, 20);
            this.tbConditionValue2.TabIndex = 20;
            this.tbConditionValue2.Text = "0";
            // 
            // tbConditionValue3
            // 
            this.tbConditionValue3.Location = new System.Drawing.Point(282, 208);
            this.tbConditionValue3.Name = "tbConditionValue3";
            this.tbConditionValue3.Size = new System.Drawing.Size(374, 20);
            this.tbConditionValue3.TabIndex = 21;
            this.tbConditionValue3.Text = "0";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(282, 235);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(374, 20);
            this.textBox7.TabIndex = 22;
            this.textBox7.Text = "0";
            // 
            // tbErrorTextId
            // 
            this.tbErrorTextId.Location = new System.Drawing.Point(282, 262);
            this.tbErrorTextId.Name = "tbErrorTextId";
            this.tbErrorTextId.Size = new System.Drawing.Size(374, 20);
            this.tbErrorTextId.TabIndex = 23;
            this.tbErrorTextId.Text = "0";
            // 
            // tbScriptName
            // 
            this.tbScriptName.Location = new System.Drawing.Point(282, 289);
            this.tbScriptName.Name = "tbScriptName";
            this.tbScriptName.Size = new System.Drawing.Size(374, 20);
            this.tbScriptName.TabIndex = 24;
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(282, 316);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(374, 20);
            this.tbComment.TabIndex = 25;
            // 
            // tbElseGroup
            // 
            this.tbElseGroup.Location = new System.Drawing.Point(282, 339);
            this.tbElseGroup.Name = "tbElseGroup";
            this.tbElseGroup.Size = new System.Drawing.Size(374, 20);
            this.tbElseGroup.TabIndex = 26;
            this.tbElseGroup.Text = "0";
            // 
            // tbSourceId
            // 
            this.tbSourceId.Location = new System.Drawing.Point(282, 366);
            this.tbSourceId.Name = "tbSourceId";
            this.tbSourceId.Size = new System.Drawing.Size(374, 20);
            this.tbSourceId.TabIndex = 27;
            this.tbSourceId.Text = "0";
            // 
            // lSourceId
            // 
            this.lSourceId.AutoSize = true;
            this.lSourceId.Location = new System.Drawing.Point(7, 369);
            this.lSourceId.Name = "lSourceId";
            this.lSourceId.Size = new System.Drawing.Size(53, 13);
            this.lSourceId.TabIndex = 28;
            this.lSourceId.Text = "SourceId:";
            // 
            // bGenerate
            // 
            this.bGenerate.Location = new System.Drawing.Point(10, 407);
            this.bGenerate.Name = "bGenerate";
            this.bGenerate.Size = new System.Drawing.Size(75, 23);
            this.bGenerate.TabIndex = 29;
            this.bGenerate.Text = "Generate";
            this.bGenerate.UseVisualStyleBackColor = true;
            this.bGenerate.Click += new System.EventHandler(this.bGenerate_Click);
            // 
            // Output
            // 
            this.Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Output.Location = new System.Drawing.Point(10, 22);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(646, 80);
            this.Output.TabIndex = 0;
            this.Output.Text = "";
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(92, 407);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 30;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(174, 407);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 31;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 578);
            this.Controls.Add(this.boxOutput);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Conditions Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.boxOutput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox boxOutput;
        private System.Windows.Forms.Label lComment;
        private System.Windows.Forms.Label lScriptName;
        private System.Windows.Forms.Label lErrorTextId;
        private System.Windows.Forms.Label lNegativeCondition;
        private System.Windows.Forms.Label lConditionValue3;
        private System.Windows.Forms.Label lConditionValue2;
        private System.Windows.Forms.Label lConditionValue1;
        private System.Windows.Forms.Label lConditionTarget;
        private System.Windows.Forms.Label lConditionTypeOrReference;
        private System.Windows.Forms.Label lElseGroup;
        private System.Windows.Forms.Label lSourceEntry;
        private System.Windows.Forms.Label lSourceGroup;
        private System.Windows.Forms.Label lSourceTypeOrReferenceId;
        private System.Windows.Forms.ComboBox cbSourceTypeOrReferenceId;
        private System.Windows.Forms.TextBox tbSourceEntry;
        private System.Windows.Forms.TextBox tbSourceGroup;
        private System.Windows.Forms.ComboBox cbConditionTypeOrReference;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbConditionValue3;
        private System.Windows.Forms.TextBox tbConditionValue2;
        private System.Windows.Forms.TextBox tbConditionValue1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox tbErrorTextId;
        private System.Windows.Forms.TextBox tbScriptName;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.TextBox tbElseGroup;
        private System.Windows.Forms.Label lSourceId;
        private System.Windows.Forms.TextBox tbSourceId;
        private System.Windows.Forms.Button bGenerate;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bSave;
    }
}

