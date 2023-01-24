namespace WinKurs
{
    partial class Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.AuthOkBut = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PasswordBox1 = new System.Windows.Forms.TextBox();
            this.LoginBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AuthCanBut = new System.Windows.Forms.Button();
            this.button_checkP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AuthOkBut
            // 
            this.AuthOkBut.Image = ((System.Drawing.Image)(resources.GetObject("AuthOkBut.Image")));
            this.AuthOkBut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AuthOkBut.Location = new System.Drawing.Point(12, 262);
            this.AuthOkBut.Name = "AuthOkBut";
            this.AuthOkBut.Size = new System.Drawing.Size(140, 40);
            this.AuthOkBut.TabIndex = 3;
            this.AuthOkBut.Text = "Вход";
            this.AuthOkBut.UseVisualStyleBackColor = true;
            this.AuthOkBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(390, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Регистрация нового пользователя";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PasswordBox1
            // 
            this.PasswordBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordBox1.Location = new System.Drawing.Point(12, 209);
            this.PasswordBox1.MaxLength = 100;
            this.PasswordBox1.Name = "PasswordBox1";
            this.PasswordBox1.PasswordChar = '*';
            this.PasswordBox1.Size = new System.Drawing.Size(128, 26);
            this.PasswordBox1.TabIndex = 1;
            // 
            // LoginBox1
            // 
            this.LoginBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginBox1.Location = new System.Drawing.Point(12, 139);
            this.LoginBox1.MaxLength = 100;
            this.LoginBox1.Name = "LoginBox1";
            this.LoginBox1.Size = new System.Drawing.Size(128, 26);
            this.LoginBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль";
            // 
            // AuthCanBut
            // 
            this.AuthCanBut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AuthCanBut.Image = ((System.Drawing.Image)(resources.GetObject("AuthCanBut.Image")));
            this.AuthCanBut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AuthCanBut.Location = new System.Drawing.Point(262, 262);
            this.AuthCanBut.Name = "AuthCanBut";
            this.AuthCanBut.Size = new System.Drawing.Size(140, 40);
            this.AuthCanBut.TabIndex = 4;
            this.AuthCanBut.Text = "Отмена";
            this.AuthCanBut.UseVisualStyleBackColor = true;
            // 
            // button_checkP
            // 
            this.button_checkP.Location = new System.Drawing.Point(156, 209);
            this.button_checkP.Name = "button_checkP";
            this.button_checkP.Size = new System.Drawing.Size(214, 32);
            this.button_checkP.TabIndex = 2;
            this.button_checkP.Text = "показать/скрыть пароль";
            this.button_checkP.UseVisualStyleBackColor = true;
            this.button_checkP.Click += new System.EventHandler(this.button_checkP_Click);
            // 
            // Auth
            // 
            this.AcceptButton = this.AuthOkBut;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.AuthCanBut;
            this.ClientSize = new System.Drawing.Size(453, 373);
            this.Controls.Add(this.button_checkP);
            this.Controls.Add(this.AuthCanBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBox1);
            this.Controls.Add(this.PasswordBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AuthOkBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AuthOkBut;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox PasswordBox1;
        private System.Windows.Forms.TextBox LoginBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AuthCanBut;
        private System.Windows.Forms.Button button_checkP;
    }
}