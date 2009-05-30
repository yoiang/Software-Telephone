namespace SoftwareTelephone
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StartWithSpeechFile = new System.Windows.Forms.TextBox();
            this.browseStartWithSpeechFile = new System.Windows.Forms.Button();
            this.StartWithText = new System.Windows.Forms.TextBox();
            this.bStartWithSpeech = new System.Windows.Forms.RadioButton();
            this.bStartWithText = new System.Windows.Forms.RadioButton();
            this.ProcessList = new System.Windows.Forms.ListBox();
            this.removeProcess = new System.Windows.Forms.Button();
            this.addProccess = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(82, 442);
            this.button1.MaximumSize = new System.Drawing.Size(84, 23);
            this.button1.MinimumSize = new System.Drawing.Size(84, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clickPlay);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.StartWithSpeechFile);
            this.groupBox1.Controls.Add(this.browseStartWithSpeechFile);
            this.groupBox1.Controls.Add(this.StartWithText);
            this.groupBox1.Controls.Add(this.bStartWithSpeech);
            this.groupBox1.Controls.Add(this.bStartWithText);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start With";
            // 
            // StartWithSpeechFile
            // 
            this.StartWithSpeechFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.StartWithSpeechFile.Location = new System.Drawing.Point(75, 75);
            this.StartWithSpeechFile.Name = "StartWithSpeechFile";
            this.StartWithSpeechFile.Size = new System.Drawing.Size(337, 20);
            this.StartWithSpeechFile.TabIndex = 4;
            this.StartWithSpeechFile.Click += new System.EventHandler(this.clickStartWithSpeechFile);
            // 
            // browseStartWithSpeechFile
            // 
            this.browseStartWithSpeechFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseStartWithSpeechFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browseStartWithSpeechFile.Location = new System.Drawing.Point(418, 75);
            this.browseStartWithSpeechFile.Name = "browseStartWithSpeechFile";
            this.browseStartWithSpeechFile.Size = new System.Drawing.Size(29, 19);
            this.browseStartWithSpeechFile.TabIndex = 3;
            this.browseStartWithSpeechFile.Text = "...";
            this.browseStartWithSpeechFile.UseVisualStyleBackColor = true;
            this.browseStartWithSpeechFile.Click += new System.EventHandler(this.clickbrowseStartWithSpeechFile);
            // 
            // StartWithText
            // 
            this.StartWithText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.StartWithText.Location = new System.Drawing.Point(59, 20);
            this.StartWithText.Multiline = true;
            this.StartWithText.Name = "StartWithText";
            this.StartWithText.Size = new System.Drawing.Size(391, 49);
            this.StartWithText.TabIndex = 2;
            this.StartWithText.Text = "all is well in my sorrow, isn\'t she a beauty, burning hall, ash and shadow, here " +
                "comes the hero";
            // 
            // bStartWithSpeech
            // 
            this.bStartWithSpeech.AutoSize = true;
            this.bStartWithSpeech.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bStartWithSpeech.Location = new System.Drawing.Point(6, 75);
            this.bStartWithSpeech.Name = "bStartWithSpeech";
            this.bStartWithSpeech.Size = new System.Drawing.Size(61, 17);
            this.bStartWithSpeech.TabIndex = 1;
            this.bStartWithSpeech.TabStop = true;
            this.bStartWithSpeech.Text = "&Speech";
            this.bStartWithSpeech.UseVisualStyleBackColor = true;
            this.bStartWithSpeech.Click += new System.EventHandler(this.clickbStartWithSpeech);
            // 
            // bStartWithText
            // 
            this.bStartWithText.AutoSize = true;
            this.bStartWithText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bStartWithText.Location = new System.Drawing.Point(6, 19);
            this.bStartWithText.Name = "bStartWithText";
            this.bStartWithText.Size = new System.Drawing.Size(45, 17);
            this.bStartWithText.TabIndex = 0;
            this.bStartWithText.TabStop = true;
            this.bStartWithText.Text = "&Text";
            this.bStartWithText.UseVisualStyleBackColor = true;
            this.bStartWithText.Click += new System.EventHandler(this.clickbStartWithText);
            // 
            // ProcessList
            // 
            this.ProcessList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.ProcessList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProcessList.FormattingEnabled = true;
            this.ProcessList.IntegralHeight = false;
            this.ProcessList.Location = new System.Drawing.Point(13, 134);
            this.ProcessList.Name = "ProcessList";
            this.ProcessList.Size = new System.Drawing.Size(153, 302);
            this.ProcessList.TabIndex = 4;
            // 
            // removeProcess
            // 
            this.removeProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeProcess.Location = new System.Drawing.Point(35, 442);
            this.removeProcess.Name = "removeProcess";
            this.removeProcess.Size = new System.Drawing.Size(23, 23);
            this.removeProcess.TabIndex = 5;
            this.removeProcess.Text = "-";
            this.removeProcess.UseVisualStyleBackColor = true;
            this.removeProcess.Click += new System.EventHandler(this.clickremoveProcess);
            // 
            // addProccess
            // 
            this.addProccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addProccess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addProccess.Location = new System.Drawing.Point(13, 442);
            this.addProccess.Name = "addProccess";
            this.addProccess.Size = new System.Drawing.Size(23, 23);
            this.addProccess.TabIndex = 6;
            this.addProccess.Text = "+";
            this.addProccess.UseVisualStyleBackColor = true;
            this.addProccess.Click += new System.EventHandler(this.clickaddToProcess);
            // 
            // ResultBox
            // 
            this.ResultBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultBox.Location = new System.Drawing.Point(173, 134);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.Size = new System.Drawing.Size(300, 302);
            this.ResultBox.TabIndex = 8;
            this.ResultBox.Text = "";
            this.ResultBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.ResultBox_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 477);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.addProccess);
            this.Controls.Add(this.removeProcess);
            this.Controls.Add(this.ProcessList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(314, 260);
            this.Name = "Main";
            this.Text = "Software Telephone";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bStartWithSpeech;
        private System.Windows.Forms.RadioButton bStartWithText;
        private System.Windows.Forms.TextBox StartWithText;
        private System.Windows.Forms.Button browseStartWithSpeechFile;
        private System.Windows.Forms.TextBox StartWithSpeechFile;
        private System.Windows.Forms.ListBox ProcessList;
        private System.Windows.Forms.Button removeProcess;
        private System.Windows.Forms.Button addProccess;
        private System.Windows.Forms.RichTextBox ResultBox;
    }
}

