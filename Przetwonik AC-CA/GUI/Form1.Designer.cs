namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RecordButton = new Button();
            LoadButton = new Button();
            PlayButton = new Button();
            SamplingInfo = new TextBox();
            QuantizationInfo = new TextBox();
            SNRInfo = new TextBox();
            SamplingSet = new TextBox();
            SNRSet = new TextBox();
            CommsSet = new TextBox();
            CommsInfo = new TextBox();
            CA = new TextBox();
            AC = new TextBox();
            FileName = new TextBox();
            QuantizationSet = new ComboBox();
            SuspendLayout();
            // 
            // RecordButton
            // 
            RecordButton.BackColor = Color.DarkSlateBlue;
            RecordButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RecordButton.Location = new Point(12, 36);
            RecordButton.Name = "RecordButton";
            RecordButton.Size = new Size(206, 81);
            RecordButton.TabIndex = 0;
            RecordButton.Text = "Nagraj";
            RecordButton.UseVisualStyleBackColor = false;
            RecordButton.Click += RecordButton_Click;
            // 
            // LoadButton
            // 
            LoadButton.BackColor = Color.DarkSlateBlue;
            LoadButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LoadButton.Location = new Point(405, 36);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(206, 81);
            LoadButton.TabIndex = 1;
            LoadButton.Text = "Wczytaj";
            LoadButton.UseVisualStyleBackColor = false;
            LoadButton.Click += LoadButton_Click;
            // 
            // PlayButton
            // 
            PlayButton.BackColor = Color.DarkSlateBlue;
            PlayButton.Enabled = false;
            PlayButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PlayButton.Location = new Point(405, 132);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(207, 81);
            PlayButton.TabIndex = 3;
            PlayButton.Text = "Odtwórz";
            PlayButton.UseVisualStyleBackColor = false;
            PlayButton.Click += PlayButton_Click;
            // 
            // SamplingInfo
            // 
            SamplingInfo.BackColor = Color.LightBlue;
            SamplingInfo.Enabled = false;
            SamplingInfo.ForeColor = SystemColors.MenuText;
            SamplingInfo.Location = new Point(12, 132);
            SamplingInfo.Name = "SamplingInfo";
            SamplingInfo.ReadOnly = true;
            SamplingInfo.Size = new Size(100, 23);
            SamplingInfo.TabIndex = 4;
            SamplingInfo.Text = "Próbkowanie:";
            // 
            // QuantizationInfo
            // 
            QuantizationInfo.BackColor = Color.LightBlue;
            QuantizationInfo.Enabled = false;
            QuantizationInfo.ForeColor = SystemColors.MenuText;
            QuantizationInfo.Location = new Point(12, 161);
            QuantizationInfo.Name = "QuantizationInfo";
            QuantizationInfo.ReadOnly = true;
            QuantizationInfo.Size = new Size(100, 23);
            QuantizationInfo.TabIndex = 5;
            QuantizationInfo.Text = "Kwantyzacja:";
            // 
            // SNRInfo
            // 
            SNRInfo.BackColor = Color.LightBlue;
            SNRInfo.Enabled = false;
            SNRInfo.ForeColor = SystemColors.MenuText;
            SNRInfo.Location = new Point(12, 190);
            SNRInfo.Name = "SNRInfo";
            SNRInfo.ReadOnly = true;
            SNRInfo.Size = new Size(100, 23);
            SNRInfo.TabIndex = 6;
            SNRInfo.Text = "SNR:";
            // 
            // SamplingSet
            // 
            SamplingSet.Location = new Point(118, 132);
            SamplingSet.Name = "SamplingSet";
            SamplingSet.Size = new Size(100, 23);
            SamplingSet.TabIndex = 7;
            SamplingSet.TextChanged += SamplingSet_TextChanged;
            // 
            // SNRSet
            // 
            SNRSet.Enabled = false;
            SNRSet.Location = new Point(118, 190);
            SNRSet.Name = "SNRSet";
            SNRSet.ReadOnly = true;
            SNRSet.Size = new Size(100, 23);
            SNRSet.TabIndex = 9;
            // 
            // CommsSet
            // 
            CommsSet.Enabled = false;
            CommsSet.Location = new Point(12, 268);
            CommsSet.Name = "CommsSet";
            CommsSet.ReadOnly = true;
            CommsSet.Size = new Size(599, 23);
            CommsSet.TabIndex = 10;
            // 
            // CommsInfo
            // 
            CommsInfo.BackColor = Color.LightBlue;
            CommsInfo.Enabled = false;
            CommsInfo.ForeColor = SystemColors.MenuText;
            CommsInfo.Location = new Point(12, 239);
            CommsInfo.Name = "CommsInfo";
            CommsInfo.ReadOnly = true;
            CommsInfo.Size = new Size(100, 23);
            CommsInfo.TabIndex = 11;
            CommsInfo.Text = "Komunikaty:";
            // 
            // CA
            // 
            CA.BackColor = Color.LightBlue;
            CA.Enabled = false;
            CA.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CA.Location = new Point(359, 1);
            CA.Name = "CA";
            CA.ReadOnly = true;
            CA.Size = new Size(40, 34);
            CA.TabIndex = 12;
            CA.Text = "C/A";
            // 
            // AC
            // 
            AC.BackColor = Color.LightBlue;
            AC.Enabled = false;
            AC.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AC.Location = new Point(224, 1);
            AC.Name = "AC";
            AC.ReadOnly = true;
            AC.Size = new Size(40, 34);
            AC.TabIndex = 13;
            AC.Text = "A/C";
            // 
            // FileName
            // 
            FileName.Location = new Point(12, 7);
            FileName.Name = "FileName";
            FileName.Size = new Size(206, 23);
            FileName.TabIndex = 14;
            FileName.Text = "Nazwa pliku / ścieżka";
            // 
            // QuantizationSet
            // 
            QuantizationSet.FormattingEnabled = true;
            QuantizationSet.Items.AddRange(new object[] { "8", "16", "24", "32" });
            QuantizationSet.Location = new Point(118, 161);
            QuantizationSet.Name = "QuantizationSet";
            QuantizationSet.Size = new Size(100, 23);
            QuantizationSet.TabIndex = 15;
            QuantizationSet.SelectedIndexChanged += QuantizationSet_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(623, 303);
            Controls.Add(QuantizationSet);
            Controls.Add(FileName);
            Controls.Add(AC);
            Controls.Add(CA);
            Controls.Add(CommsInfo);
            Controls.Add(CommsSet);
            Controls.Add(SNRSet);
            Controls.Add(SamplingSet);
            Controls.Add(SNRInfo);
            Controls.Add(QuantizationInfo);
            Controls.Add(SamplingInfo);
            Controls.Add(PlayButton);
            Controls.Add(LoadButton);
            Controls.Add(RecordButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RecordButton;
        private Button LoadButton;
        private Button PlayButton;
        private TextBox SamplingInfo;
        private TextBox QuantizationInfo;
        private TextBox SNRInfo;
        private TextBox SamplingSet;
        private TextBox SNRSet;
        private TextBox CommsSet;
        private TextBox CommsInfo;
        private TextBox CA;
        private TextBox AC;
        private TextBox FileName;
        private ComboBox QuantizationSet;
    }
}