namespace WinKurs
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.SourceText = new System.Windows.Forms.TextBox();
            this.button_code = new System.Windows.Forms.Button();
            this.labecod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TargetText = new System.Windows.Forms.TextBox();
            this.DiamEd = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DecrText = new System.Windows.Forms.TextBox();
            this.EncLabel = new System.Windows.Forms.Label();
            this.EncrSaveDi = new System.Windows.Forms.SaveFileDialog();
            this.SaveEncrBut = new System.Windows.Forms.Button();
            this.EncrOpenDi = new System.Windows.Forms.OpenFileDialog();
            this.EncrOpenBut = new System.Windows.Forms.Button();
            this.MainCancel = new System.Windows.Forms.Button();
            this.EncrFBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DiamEd)).BeginInit();
            this.SuspendLayout();
            // 
            // SourceText
            // 
            this.SourceText.Location = new System.Drawing.Point(16, 37);
            this.SourceText.Multiline = true;
            this.SourceText.Name = "SourceText";
            this.SourceText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SourceText.Size = new System.Drawing.Size(754, 96);
            this.SourceText.TabIndex = 0;
            // 
            // button_code
            // 
            this.button_code.BackColor = System.Drawing.Color.Gold;
            this.button_code.Location = new System.Drawing.Point(528, 149);
            this.button_code.Name = "button_code";
            this.button_code.Size = new System.Drawing.Size(164, 63);
            this.button_code.TabIndex = 2;
            this.button_code.Text = "Зашифровать";
            this.button_code.UseVisualStyleBackColor = false;
            this.button_code.Click += new System.EventHandler(this.button_code_Click);
            // 
            // labecod
            // 
            this.labecod.AutoSize = true;
            this.labecod.BackColor = System.Drawing.Color.MediumAquamarine;
            this.labecod.Location = new System.Drawing.Point(16, 218);
            this.labecod.Name = "labecod";
            this.labecod.Size = new System.Drawing.Size(191, 20);
            this.labecod.TabIndex = 3;
            this.labecod.Text = "Зашифрованный текст:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Исходный текст";
            // 
            // TargetText
            // 
            this.TargetText.Location = new System.Drawing.Point(15, 262);
            this.TargetText.Multiline = true;
            this.TargetText.Name = "TargetText";
            this.TargetText.ReadOnly = true;
            this.TargetText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TargetText.Size = new System.Drawing.Size(754, 96);
            this.TargetText.TabIndex = 3;
            // 
            // DiamEd
            // 
            this.DiamEd.Location = new System.Drawing.Point(162, 168);
            this.DiamEd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DiamEd.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.DiamEd.Name = "DiamEd";
            this.DiamEd.Size = new System.Drawing.Size(126, 26);
            this.DiamEd.TabIndex = 1;
            this.DiamEd.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.DiamEd.ValueChanged += new System.EventHandler(this.DiamEd_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Диаметр (ключ):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label3.Location = new System.Drawing.Point(18, 362);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Расшифровка для проверки:";
            // 
            // DecrText
            // 
            this.DecrText.Location = new System.Drawing.Point(15, 385);
            this.DecrText.Multiline = true;
            this.DecrText.Name = "DecrText";
            this.DecrText.ReadOnly = true;
            this.DecrText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DecrText.Size = new System.Drawing.Size(754, 96);
            this.DecrText.TabIndex = 4;
            // 
            // EncLabel
            // 
            this.EncLabel.Location = new System.Drawing.Point(213, 218);
            this.EncLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EncLabel.Name = "EncLabel";
            this.EncLabel.Size = new System.Drawing.Size(558, 20);
            this.EncLabel.TabIndex = 11;
            // 
            // EncrSaveDi
            // 
            this.EncrSaveDi.DefaultExt = "SKT";
            this.EncrSaveDi.Title = "Сохраняем шифровку:";
            // 
            // SaveEncrBut
            // 
            this.SaveEncrBut.Image = ((System.Drawing.Image)(resources.GetObject("SaveEncrBut.Image")));
            this.SaveEncrBut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveEncrBut.Location = new System.Drawing.Point(16, 497);
            this.SaveEncrBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveEncrBut.Name = "SaveEncrBut";
            this.SaveEncrBut.Size = new System.Drawing.Size(252, 46);
            this.SaveEncrBut.TabIndex = 5;
            this.SaveEncrBut.Text = "Сохранить шифровку";
            this.SaveEncrBut.UseVisualStyleBackColor = true;
            this.SaveEncrBut.Click += new System.EventHandler(this.SaveEncrBut_Click);
            // 
            // EncrOpenDi
            // 
            this.EncrOpenDi.DefaultExt = "SKT";
            this.EncrOpenDi.Title = "Читаем шифровку:";
            // 
            // EncrOpenBut
            // 
            this.EncrOpenBut.Image = ((System.Drawing.Image)(resources.GetObject("EncrOpenBut.Image")));
            this.EncrOpenBut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EncrOpenBut.Location = new System.Drawing.Point(278, 497);
            this.EncrOpenBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EncrOpenBut.Name = "EncrOpenBut";
            this.EncrOpenBut.Size = new System.Drawing.Size(242, 46);
            this.EncrOpenBut.TabIndex = 6;
            this.EncrOpenBut.Text = "Прочитать шифровку";
            this.EncrOpenBut.UseVisualStyleBackColor = true;
            this.EncrOpenBut.Click += new System.EventHandler(this.EncrOpenBut_Click);
            // 
            // MainCancel
            // 
            this.MainCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MainCancel.Image = ((System.Drawing.Image)(resources.GetObject("MainCancel.Image")));
            this.MainCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainCancel.Location = new System.Drawing.Point(527, 497);
            this.MainCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainCancel.Name = "MainCancel";
            this.MainCancel.Size = new System.Drawing.Size(242, 46);
            this.MainCancel.TabIndex = 7;
            this.MainCancel.Text = "Закончить работу";
            this.MainCancel.UseVisualStyleBackColor = true;
            this.MainCancel.Click += new System.EventHandler(this.MainCancel_Click);
            // 
            // EncrFBox
            // 
            this.EncrFBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EncrFBox.Location = new System.Drawing.Point(15, 243);
            this.EncrFBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EncrFBox.Name = "EncrFBox";
            this.EncrFBox.ReadOnly = true;
            this.EncrFBox.Size = new System.Drawing.Size(754, 19);
            this.EncrFBox.TabIndex = 13;
            this.EncrFBox.TabStop = false;
            this.EncrFBox.WordWrap = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.MainCancel;
            this.ClientSize = new System.Drawing.Size(794, 562);
            this.Controls.Add(this.EncrFBox);
            this.Controls.Add(this.MainCancel);
            this.Controls.Add(this.EncrOpenBut);
            this.Controls.Add(this.SaveEncrBut);
            this.Controls.Add(this.EncLabel);
            this.Controls.Add(this.DecrText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DiamEd);
            this.Controls.Add(this.TargetText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labecod);
            this.Controls.Add(this.button_code);
            this.Controls.Add(this.SourceText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Шифрование";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DiamEd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SourceText;
        private System.Windows.Forms.Button button_code;
        private System.Windows.Forms.Label labecod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TargetText;
        private System.Windows.Forms.NumericUpDown DiamEd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DecrText;
        private System.Windows.Forms.Label EncLabel;
        private System.Windows.Forms.SaveFileDialog EncrSaveDi;
        private System.Windows.Forms.Button SaveEncrBut;
        private System.Windows.Forms.OpenFileDialog EncrOpenDi;
        private System.Windows.Forms.Button EncrOpenBut;
        private System.Windows.Forms.Button MainCancel;
        private System.Windows.Forms.TextBox EncrFBox;
    }
}