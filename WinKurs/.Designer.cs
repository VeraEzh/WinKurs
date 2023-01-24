namespace WinKurs
{
    partial class FormRegistr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistr));
            this.Button_Reg = new System.Windows.Forms.Button();
            this.LoginB = new System.Windows.Forms.TextBox();
            this.PassB1 = new System.Windows.Forms.TextBox();
            this.PassB2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RegCanBut = new System.Windows.Forms.Button();
            this.buttoncheckPP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Reg
            // 
            this.Button_Reg.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Reg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Reg.Image = ((System.Drawing.Image)(resources.GetObject("Button_Reg.Image")));
            this.Button_Reg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Reg.Location = new System.Drawing.Point(12, 342);
            this.Button_Reg.Name = "Button_Reg";
            this.Button_Reg.Size = new System.Drawing.Size(234, 51);
            this.Button_Reg.TabIndex = 4;
            this.Button_Reg.Text = "Зарегистрироваться";
            this.Button_Reg.UseVisualStyleBackColor = false;
            this.Button_Reg.Click += new System.EventHandler(this.Button_Reg_Click);
            // 
            // LoginB
            // 
            this.LoginB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginB.Location = new System.Drawing.Point(12, 27);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(170, 26);
            this.LoginB.TabIndex = 0;
            // 
            // PassB1
            // 
            this.PassB1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PassB1.Location = new System.Drawing.Point(12, 100);
            this.PassB1.Name = "PassB1";
            this.PassB1.PasswordChar = '*';
            this.PassB1.Size = new System.Drawing.Size(170, 26);
            this.PassB1.TabIndex = 1;
            // 
            // PassB2
            // 
            this.PassB2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PassB2.Location = new System.Drawing.Point(12, 173);
            this.PassB2.Name = "PassB2";
            this.PassB2.PasswordChar = '*';
            this.PassB2.Size = new System.Drawing.Size(170, 26);
            this.PassB2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Повторите пароль";
            // 
            // RegCanBut
            // 
            this.RegCanBut.BackColor = System.Drawing.SystemColors.Control;
            this.RegCanBut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RegCanBut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RegCanBut.Image = ((System.Drawing.Image)(resources.GetObject("RegCanBut.Image")));
            this.RegCanBut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegCanBut.Location = new System.Drawing.Point(268, 345);
            this.RegCanBut.Name = "RegCanBut";
            this.RegCanBut.Size = new System.Drawing.Size(234, 48);
            this.RegCanBut.TabIndex = 5;
            this.RegCanBut.Text = "Отмена";
            this.RegCanBut.UseVisualStyleBackColor = false;
            // 
            // buttoncheckPP
            // 
            this.buttoncheckPP.BackColor = System.Drawing.SystemColors.Control;
            this.buttoncheckPP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttoncheckPP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoncheckPP.Location = new System.Drawing.Point(281, 96);
            this.buttoncheckPP.Name = "buttoncheckPP";
            this.buttoncheckPP.Size = new System.Drawing.Size(221, 34);
            this.buttoncheckPP.TabIndex = 3;
            this.buttoncheckPP.Text = "показать/скрыть пароль";
            this.buttoncheckPP.UseVisualStyleBackColor = false;
            this.buttoncheckPP.Click += new System.EventHandler(this.buttoncheckPP_Click);
            // 
            // FormRegistr
            // 
            this.AcceptButton = this.Button_Reg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.RegCanBut;
            this.ClientSize = new System.Drawing.Size(514, 444);
            this.Controls.Add(this.buttoncheckPP);
            this.Controls.Add(this.RegCanBut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PassB2);
            this.Controls.Add(this.PassB1);
            this.Controls.Add(this.LoginB);
            this.Controls.Add(this.Button_Reg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistr";
            this.Text = "Новый пользователь";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Reg;
        private System.Windows.Forms.TextBox LoginB;
        private System.Windows.Forms.TextBox PassB1;
        private System.Windows.Forms.TextBox PassB2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RegCanBut;
        private System.Windows.Forms.Button buttoncheckPP;
    }
}