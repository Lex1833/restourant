namespace Restaurant
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.PanelBack = new System.Windows.Forms.Panel();
            this.LabelBack = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelLogin.SuspendLayout();
            this.PanelBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Linen;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPhone.Location = new System.Drawing.Point(32, 210);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(314, 46);
            this.txtPhone.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Linen;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Location = new System.Drawing.Point(32, 296);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(314, 46);
            this.txtPassword.TabIndex = 3;
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.Color.Crimson;
            this.PanelLogin.Controls.Add(this.LabelLogin);
            this.PanelLogin.Location = new System.Drawing.Point(125, 378);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(120, 47);
            this.PanelLogin.TabIndex = 5;
            this.PanelLogin.Click += new System.EventHandler(this.PanelLogin_Click);
            this.PanelLogin.MouseEnter += new System.EventHandler(this.PanelLogin_MouseEnter);
            this.PanelLogin.MouseLeave += new System.EventHandler(this.PanelLogin_MouseLeave);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLogin.ForeColor = System.Drawing.Color.White;
            this.LabelLogin.Location = new System.Drawing.Point(20, 9);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(85, 29);
            this.LabelLogin.TabIndex = 0;
            this.LabelLogin.Text = "Войти";
            this.LabelLogin.Click += new System.EventHandler(this.LabelLogin_Click);
            this.LabelLogin.MouseEnter += new System.EventHandler(this.LabelLogin_MouseEnter);
            this.LabelLogin.MouseLeave += new System.EventHandler(this.LabelLogin_MouseLeave);
            // 
            // PanelBack
            // 
            this.PanelBack.BackColor = System.Drawing.Color.Crimson;
            this.PanelBack.Controls.Add(this.LabelBack);
            this.PanelBack.Location = new System.Drawing.Point(21, 21);
            this.PanelBack.Name = "PanelBack";
            this.PanelBack.Size = new System.Drawing.Size(120, 47);
            this.PanelBack.TabIndex = 6;
            this.PanelBack.Click += new System.EventHandler(this.PanelBack_Click);
            this.PanelBack.MouseEnter += new System.EventHandler(this.PanelBack_MouseEnter);
            this.PanelBack.MouseLeave += new System.EventHandler(this.PanelBack_MouseLeave);
            // 
            // LabelBack
            // 
            this.LabelBack.AutoSize = true;
            this.LabelBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelBack.ForeColor = System.Drawing.Color.White;
            this.LabelBack.Location = new System.Drawing.Point(20, 9);
            this.LabelBack.Name = "LabelBack";
            this.LabelBack.Size = new System.Drawing.Size(83, 29);
            this.LabelBack.TabIndex = 0;
            this.LabelBack.Text = "Назад";
            this.LabelBack.Click += new System.EventHandler(this.LabelBack_Click);
            this.LabelBack.MouseEnter += new System.EventHandler(this.LabelBack_MouseEnter);
            this.LabelBack.MouseLeave += new System.EventHandler(this.LabelBack_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Телефон:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пароль:";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(384, 504);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelBack);
            this.Controls.Add(this.PanelLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPhone);
            this.Name = "User";
            this.Text = "Вход";
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            this.PanelBack.ResumeLayout(false);
            this.PanelBack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Panel PanelBack;
        private System.Windows.Forms.Label LabelBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}