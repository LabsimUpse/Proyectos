namespace LoginSystem
{
    partial class loginwind
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
            this.ingresar = new System.Windows.Forms.Button();
            this.cteuser = new System.Windows.Forms.Button();
            this.labeluser = new System.Windows.Forms.Label();
            this.labelpassw = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menubarlogin = new System.Windows.Forms.MenuStrip();
            this.filemenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitmenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.menubarlogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // ingresar
            // 
            this.ingresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ingresar.Location = new System.Drawing.Point(191, 196);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(113, 23);
            this.ingresar.TabIndex = 0;
            this.ingresar.Text = "Ingresar";
            this.ingresar.UseVisualStyleBackColor = true;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // cteuser
            // 
            this.cteuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cteuser.Location = new System.Drawing.Point(190, 226);
            this.cteuser.Name = "cteuser";
            this.cteuser.Size = new System.Drawing.Size(113, 23);
            this.cteuser.TabIndex = 1;
            this.cteuser.Text = "Crear Usuario";
            this.cteuser.UseVisualStyleBackColor = true;
            this.cteuser.Click += new System.EventHandler(this.cteuser_Click);
            // 
            // labeluser
            // 
            this.labeluser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeluser.AutoSize = true;
            this.labeluser.Location = new System.Drawing.Point(52, 99);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(46, 13);
            this.labeluser.TabIndex = 2;
            this.labeluser.Text = "Usuario:";
            // 
            // labelpassw
            // 
            this.labelpassw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelpassw.AutoSize = true;
            this.labelpassw.Location = new System.Drawing.Point(52, 135);
            this.labelpassw.Name = "labelpassw";
            this.labelpassw.Size = new System.Drawing.Size(64, 13);
            this.labelpassw.TabIndex = 3;
            this.labelpassw.Text = "Contraseña:";
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.Location = new System.Drawing.Point(131, 96);
            this.username.MaximumSize = new System.Drawing.Size(149, 20);
            this.username.MinimumSize = new System.Drawing.Size(149, 20);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(149, 20);
            this.username.TabIndex = 4;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.Location = new System.Drawing.Point(131, 128);
            this.password.MaximumSize = new System.Drawing.Size(149, 20);
            this.password.MinimumSize = new System.Drawing.Size(149, 20);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(149, 20);
            this.password.TabIndex = 5;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sistema de Gestión Académica";
            // 
            // menubarlogin
            // 
            this.menubarlogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filemenu});
            this.menubarlogin.Location = new System.Drawing.Point(0, 0);
            this.menubarlogin.Name = "menubarlogin";
            this.menubarlogin.Size = new System.Drawing.Size(334, 24);
            this.menubarlogin.TabIndex = 7;
            this.menubarlogin.Text = "menuStrip1";
            this.menubarlogin.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menubarlogin_ItemClicked);
            // 
            // filemenu
            // 
            this.filemenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitmenuitem});
            this.filemenu.Name = "filemenu";
            this.filemenu.Size = new System.Drawing.Size(37, 20);
            this.filemenu.Text = "&File";
            // 
            // exitmenuitem
            // 
            this.exitmenuitem.Name = "exitmenuitem";
            this.exitmenuitem.Size = new System.Drawing.Size(92, 22);
            this.exitmenuitem.Text = "&Exit";
            // 
            // loginwind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.labelpassw);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.cteuser);
            this.Controls.Add(this.ingresar);
            this.Controls.Add(this.menubarlogin);
            this.MainMenuStrip = this.menubarlogin;
            this.MaximumSize = new System.Drawing.Size(550, 500);
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "loginwind";
            this.Text = "Gestión Académica";
            this.Load += new System.EventHandler(this.loginwind_Load);
            this.menubarlogin.ResumeLayout(false);
            this.menubarlogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ingresar;
        private System.Windows.Forms.Button cteuser;
        private System.Windows.Forms.Label labeluser;
        private System.Windows.Forms.Label labelpassw;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menubarlogin;
        private System.Windows.Forms.ToolStripMenuItem filemenu;
        private System.Windows.Forms.ToolStripMenuItem exitmenuitem;
    }
}

