namespace Restaurant
{
    partial class Logo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logo));
            this.Picture1 = new System.Windows.Forms.PictureBox();
            this.PanelUser = new System.Windows.Forms.Panel();
            this.LabelUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelCreate = new System.Windows.Forms.Label();
            this.PanelAdmin = new System.Windows.Forms.Panel();
            this.LabelAdmin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).BeginInit();
            this.PanelUser.SuspendLayout();
            this.PanelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // Picture1
            // 
            this.Picture1.BackColor = System.Drawing.Color.Transparent;
            this.Picture1.Image = ((System.Drawing.Image)(resources.GetObject("Picture1.Image")));
            this.Picture1.Location = new System.Drawing.Point(144, 12);
            this.Picture1.Name = "Picture1";
            this.Picture1.Size = new System.Drawing.Size(400, 350);
            this.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture1.TabIndex = 0;
            this.Picture1.TabStop = false;
            // 
            // PanelUser
            // 
            this.PanelUser.BackColor = System.Drawing.Color.Crimson;
            this.PanelUser.Controls.Add(this.LabelUser);
            this.PanelUser.Location = new System.Drawing.Point(587, 136);
            this.PanelUser.Name = "PanelUser";
            this.PanelUser.Size = new System.Drawing.Size(394, 78);
            this.PanelUser.TabIndex = 1;
            this.PanelUser.Click += new System.EventHandler(this.PanelUser_Click);
            this.PanelUser.MouseEnter += new System.EventHandler(this.PanelUser_MouseEnter);
            this.PanelUser.MouseLeave += new System.EventHandler(this.PanelUser_MouseLeave);
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelUser.ForeColor = System.Drawing.Color.White;
            this.LabelUser.Location = new System.Drawing.Point(24, 12);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(342, 55);
            this.LabelUser.TabIndex = 0;
            this.LabelUser.Text = "Пользователь";
            this.LabelUser.Click += new System.EventHandler(this.LabelUser_Click);
            this.LabelUser.MouseEnter += new System.EventHandler(this.LabelUser_MouseEnter);
            this.LabelUser.MouseLeave += new System.EventHandler(this.LabelUser_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(665, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Войти как";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(587, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Нет аккаунта ?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(587, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Хотите";
            // 
            // LabelCreate
            // 
            this.LabelCreate.AutoSize = true;
            this.LabelCreate.BackColor = System.Drawing.Color.Transparent;
            this.LabelCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCreate.ForeColor = System.Drawing.Color.White;
            this.LabelCreate.Location = new System.Drawing.Point(682, 267);
            this.LabelCreate.Name = "LabelCreate";
            this.LabelCreate.Size = new System.Drawing.Size(205, 31);
            this.LabelCreate.TabIndex = 3;
            this.LabelCreate.Text = "создать аккунт";
            this.LabelCreate.Click += new System.EventHandler(this.LabelCreate_Click);
            this.LabelCreate.MouseEnter += new System.EventHandler(this.LabelCreate_MouseEnter);
            this.LabelCreate.MouseLeave += new System.EventHandler(this.LabelCreate_MouseLeave);
            // 
            // PanelAdmin
            // 
            this.PanelAdmin.BackColor = System.Drawing.Color.Crimson;
            this.PanelAdmin.Controls.Add(this.LabelAdmin);
            this.PanelAdmin.Location = new System.Drawing.Point(593, 344);
            this.PanelAdmin.Name = "PanelAdmin";
            this.PanelAdmin.Size = new System.Drawing.Size(395, 78);
            this.PanelAdmin.TabIndex = 2;
            this.PanelAdmin.Click += new System.EventHandler(this.PanelAdmin_Click);
            this.PanelAdmin.MouseEnter += new System.EventHandler(this.PanelAdmin_MouseEnter);
            this.PanelAdmin.MouseLeave += new System.EventHandler(this.PanelAdmin_MouseLeave);
            // 
            // LabelAdmin
            // 
            this.LabelAdmin.AutoSize = true;
            this.LabelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAdmin.ForeColor = System.Drawing.Color.White;
            this.LabelAdmin.Location = new System.Drawing.Point(13, 13);
            this.LabelAdmin.Name = "LabelAdmin";
            this.LabelAdmin.Size = new System.Drawing.Size(375, 55);
            this.LabelAdmin.TabIndex = 0;
            this.LabelAdmin.Text = "Администратор";
            this.LabelAdmin.Click += new System.EventHandler(this.LabelAdmin_Click);
            this.LabelAdmin.MouseEnter += new System.EventHandler(this.LabelAdmin_MouseEnter);
            this.LabelAdmin.MouseLeave += new System.EventHandler(this.LabelAdmin_MouseLeave);
            // 
            // Logo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.PanelAdmin);
            this.Controls.Add(this.LabelCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelUser);
            this.Controls.Add(this.Picture1);
            this.Name = "Logo";
            this.Text = "« Claude Monet »";
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).EndInit();
            this.PanelUser.ResumeLayout(false);
            this.PanelUser.PerformLayout();
            this.PanelAdmin.ResumeLayout(false);
            this.PanelAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture1;
        private System.Windows.Forms.Panel PanelUser;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelCreate;
        private System.Windows.Forms.Panel PanelAdmin;
        private System.Windows.Forms.Label LabelAdmin;
    }
}