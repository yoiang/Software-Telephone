namespace dotNetSpeech
{
    partial class Configure
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
            this.OkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VoiceList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Rate = new System.Windows.Forms.NumericUpDown();
            this.Volume = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(108, 56);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "&Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voice";
            // 
            // VoiceList
            // 
            this.VoiceList.FormattingEnabled = true;
            this.VoiceList.Location = new System.Drawing.Point(13, 30);
            this.VoiceList.Name = "VoiceList";
            this.VoiceList.Size = new System.Drawing.Size(121, 21);
            this.VoiceList.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rate";
            // 
            // Rate
            // 
            this.Rate.Location = new System.Drawing.Point(155, 31);
            this.Rate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Rate.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(41, 20);
            this.Rate.TabIndex = 4;
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(233, 32);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(41, 20);
            this.Volume.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Volume";
            // 
            // Configure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 91);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VoiceList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OkButton);
            this.Name = "Configure";
            this.Text = "Configure .NET Speech Synthesizer";
            ((System.ComponentModel.ISupportInitialize)(this.Rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox VoiceList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Rate;
        private System.Windows.Forms.NumericUpDown Volume;
        private System.Windows.Forms.Label label3;
    }
}