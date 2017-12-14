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
            this.grpBoxCteAcc = new System.Windows.Forms.GroupBox();
            this.addPicButton = new System.Windows.Forms.Button();
            this.userpic = new System.Windows.Forms.PictureBox();
            this.labelcont = new System.Windows.Forms.Label();
            this.textcont = new System.Windows.Forms.TextBox();
            this.textusername = new System.Windows.Forms.TextBox();
            this.labelusername = new System.Windows.Forms.Label();
            this.textquinniv = new System.Windows.Forms.TextBox();
            this.labelquinniv = new System.Windows.Forms.Label();
            this.textcuarniv = new System.Windows.Forms.TextBox();
            this.labelcuarniv = new System.Windows.Forms.Label();
            this.texttercniv = new System.Windows.Forms.TextBox();
            this.textapel = new System.Windows.Forms.TextBox();
            this.textnomb = new System.Windows.Forms.TextBox();
            this.textced = new System.Windows.Forms.TextBox();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.buttoncreate = new System.Windows.Forms.Button();
            this.labelterniv = new System.Windows.Forms.Label();
            this.labelapel = new System.Windows.Forms.Label();
            this.labelnomb = new System.Windows.Forms.Label();
            this.labelced = new System.Windows.Forms.Label();
            this.menubarlogin.SuspendLayout();
            this.grpBoxCteAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).BeginInit();
            this.SuspendLayout();
            // 
            // ingresar
            // 
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
            this.cteuser.Location = new System.Drawing.Point(191, 226);
            this.cteuser.Name = "cteuser";
            this.cteuser.Size = new System.Drawing.Size(113, 23);
            this.cteuser.TabIndex = 1;
            this.cteuser.Text = "Crear Usuario";
            this.cteuser.UseVisualStyleBackColor = true;
            this.cteuser.Click += new System.EventHandler(this.cteuser_Click);
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.Location = new System.Drawing.Point(52, 99);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(46, 13);
            this.labeluser.TabIndex = 2;
            this.labeluser.Text = "Usuario:";
            // 
            // labelpassw
            // 
            this.labelpassw.AutoSize = true;
            this.labelpassw.Location = new System.Drawing.Point(52, 135);
            this.labelpassw.Name = "labelpassw";
            this.labelpassw.Size = new System.Drawing.Size(64, 13);
            this.labelpassw.TabIndex = 3;
            this.labelpassw.Text = "Contraseña:";
            // 
            // username
            // 
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
            this.exitmenuitem.Click += new System.EventHandler(this.exitmenuitem_Click);
            // 
            // grpBoxCteAcc
            // 
            this.grpBoxCteAcc.Controls.Add(this.addPicButton);
            this.grpBoxCteAcc.Controls.Add(this.userpic);
            this.grpBoxCteAcc.Controls.Add(this.labelcont);
            this.grpBoxCteAcc.Controls.Add(this.textcont);
            this.grpBoxCteAcc.Controls.Add(this.textusername);
            this.grpBoxCteAcc.Controls.Add(this.labelusername);
            this.grpBoxCteAcc.Controls.Add(this.textquinniv);
            this.grpBoxCteAcc.Controls.Add(this.labelquinniv);
            this.grpBoxCteAcc.Controls.Add(this.textcuarniv);
            this.grpBoxCteAcc.Controls.Add(this.labelcuarniv);
            this.grpBoxCteAcc.Controls.Add(this.texttercniv);
            this.grpBoxCteAcc.Controls.Add(this.textapel);
            this.grpBoxCteAcc.Controls.Add(this.textnomb);
            this.grpBoxCteAcc.Controls.Add(this.textced);
            this.grpBoxCteAcc.Controls.Add(this.buttoncancel);
            this.grpBoxCteAcc.Controls.Add(this.buttoncreate);
            this.grpBoxCteAcc.Controls.Add(this.labelterniv);
            this.grpBoxCteAcc.Controls.Add(this.labelapel);
            this.grpBoxCteAcc.Controls.Add(this.labelnomb);
            this.grpBoxCteAcc.Controls.Add(this.labelced);
            this.grpBoxCteAcc.Location = new System.Drawing.Point(397, 27);
            this.grpBoxCteAcc.Name = "grpBoxCteAcc";
            this.grpBoxCteAcc.Size = new System.Drawing.Size(425, 280);
            this.grpBoxCteAcc.TabIndex = 32;
            this.grpBoxCteAcc.TabStop = false;
            this.grpBoxCteAcc.Text = "Sistema de Gestión Académica";
            this.grpBoxCteAcc.Visible = false;
            // 
            // addPicButton
            // 
            this.addPicButton.Location = new System.Drawing.Point(6, 168);
            this.addPicButton.Name = "addPicButton";
            this.addPicButton.Size = new System.Drawing.Size(135, 37);
            this.addPicButton.TabIndex = 28;
            this.addPicButton.Text = "Agregar Foto";
            this.addPicButton.UseVisualStyleBackColor = true;
            // 
            // userpic
            // 
            this.userpic.Location = new System.Drawing.Point(6, 15);
            this.userpic.Name = "userpic";
            this.userpic.Size = new System.Drawing.Size(135, 147);
            this.userpic.TabIndex = 27;
            this.userpic.TabStop = false;
            // 
            // labelcont
            // 
            this.labelcont.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelcont.AutoSize = true;
            this.labelcont.Location = new System.Drawing.Point(155, 197);
            this.labelcont.Name = "labelcont";
            this.labelcont.Size = new System.Drawing.Size(64, 13);
            this.labelcont.TabIndex = 17;
            this.labelcont.Text = "Contraseña:";
            // 
            // textcont
            // 
            this.textcont.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textcont.Location = new System.Drawing.Point(272, 194);
            this.textcont.Name = "textcont";
            this.textcont.Size = new System.Drawing.Size(144, 20);
            this.textcont.TabIndex = 16;
            this.textcont.UseSystemPasswordChar = true;
            this.textcont.TextChanged += new System.EventHandler(this.textcont_TextChanged);
            // 
            // textusername
            // 
            this.textusername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textusername.Location = new System.Drawing.Point(272, 168);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(144, 20);
            this.textusername.TabIndex = 15;
            this.textusername.TextChanged += new System.EventHandler(this.textusername_TextChanged);
            // 
            // labelusername
            // 
            this.labelusername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelusername.AutoSize = true;
            this.labelusername.Location = new System.Drawing.Point(155, 171);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(46, 13);
            this.labelusername.TabIndex = 14;
            this.labelusername.Text = "Usuario:";
            // 
            // textquinniv
            // 
            this.textquinniv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textquinniv.Location = new System.Drawing.Point(272, 142);
            this.textquinniv.Name = "textquinniv";
            this.textquinniv.Size = new System.Drawing.Size(144, 20);
            this.textquinniv.TabIndex = 13;
            this.textquinniv.TextChanged += new System.EventHandler(this.textquinniv_TextChanged);
            // 
            // labelquinniv
            // 
            this.labelquinniv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelquinniv.AutoSize = true;
            this.labelquinniv.Location = new System.Drawing.Point(155, 145);
            this.labelquinniv.Name = "labelquinniv";
            this.labelquinniv.Size = new System.Drawing.Size(105, 13);
            this.labelquinniv.TabIndex = 12;
            this.labelquinniv.Text = "Título (Quinto Nivel):";
            // 
            // textcuarniv
            // 
            this.textcuarniv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textcuarniv.Location = new System.Drawing.Point(272, 116);
            this.textcuarniv.Name = "textcuarniv";
            this.textcuarniv.Size = new System.Drawing.Size(144, 20);
            this.textcuarniv.TabIndex = 11;
            this.textcuarniv.TextChanged += new System.EventHandler(this.textcuarniv_TextChanged);
            // 
            // labelcuarniv
            // 
            this.labelcuarniv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelcuarniv.AutoSize = true;
            this.labelcuarniv.Location = new System.Drawing.Point(155, 119);
            this.labelcuarniv.Name = "labelcuarniv";
            this.labelcuarniv.Size = new System.Drawing.Size(105, 13);
            this.labelcuarniv.TabIndex = 10;
            this.labelcuarniv.Text = "Título (Cuarto Nivel):";
            // 
            // texttercniv
            // 
            this.texttercniv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.texttercniv.Location = new System.Drawing.Point(272, 90);
            this.texttercniv.Name = "texttercniv";
            this.texttercniv.Size = new System.Drawing.Size(144, 20);
            this.texttercniv.TabIndex = 9;
            this.texttercniv.TextChanged += new System.EventHandler(this.texttercniv_TextChanged);
            // 
            // textapel
            // 
            this.textapel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textapel.Location = new System.Drawing.Point(272, 64);
            this.textapel.Name = "textapel";
            this.textapel.Size = new System.Drawing.Size(144, 20);
            this.textapel.TabIndex = 8;
            this.textapel.TextChanged += new System.EventHandler(this.textapel_TextChanged);
            // 
            // textnomb
            // 
            this.textnomb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textnomb.Location = new System.Drawing.Point(272, 38);
            this.textnomb.Name = "textnomb";
            this.textnomb.Size = new System.Drawing.Size(144, 20);
            this.textnomb.TabIndex = 7;
            this.textnomb.TextChanged += new System.EventHandler(this.textnomb_TextChanged);
            // 
            // textced
            // 
            this.textced.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textced.Location = new System.Drawing.Point(272, 12);
            this.textced.Name = "textced";
            this.textced.Size = new System.Drawing.Size(144, 20);
            this.textced.TabIndex = 6;
            this.textced.TextChanged += new System.EventHandler(this.textced_TextChanged);
            // 
            // buttoncancel
            // 
            this.buttoncancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttoncancel.Location = new System.Drawing.Point(341, 249);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(75, 23);
            this.buttoncancel.TabIndex = 5;
            this.buttoncancel.Text = "Cancelar";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // buttoncreate
            // 
            this.buttoncreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttoncreate.Location = new System.Drawing.Point(341, 220);
            this.buttoncreate.Name = "buttoncreate";
            this.buttoncreate.Size = new System.Drawing.Size(75, 23);
            this.buttoncreate.TabIndex = 4;
            this.buttoncreate.Text = "Crear";
            this.buttoncreate.UseVisualStyleBackColor = true;
            this.buttoncreate.Click += new System.EventHandler(this.buttoncreate_Click);
            // 
            // labelterniv
            // 
            this.labelterniv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelterniv.AutoSize = true;
            this.labelterniv.Location = new System.Drawing.Point(155, 93);
            this.labelterniv.Name = "labelterniv";
            this.labelterniv.Size = new System.Drawing.Size(105, 13);
            this.labelterniv.TabIndex = 3;
            this.labelterniv.Text = "Título (Tercer Nivel):";
            // 
            // labelapel
            // 
            this.labelapel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelapel.AutoSize = true;
            this.labelapel.Location = new System.Drawing.Point(155, 67);
            this.labelapel.Name = "labelapel";
            this.labelapel.Size = new System.Drawing.Size(52, 13);
            this.labelapel.TabIndex = 2;
            this.labelapel.Text = "Apellidos:";
            // 
            // labelnomb
            // 
            this.labelnomb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelnomb.AutoSize = true;
            this.labelnomb.Location = new System.Drawing.Point(155, 41);
            this.labelnomb.Name = "labelnomb";
            this.labelnomb.Size = new System.Drawing.Size(52, 13);
            this.labelnomb.TabIndex = 1;
            this.labelnomb.Text = "Nombres:";
            // 
            // labelced
            // 
            this.labelced.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelced.AutoSize = true;
            this.labelced.Location = new System.Drawing.Point(155, 15);
            this.labelced.Name = "labelced";
            this.labelced.Size = new System.Drawing.Size(43, 13);
            this.labelced.TabIndex = 0;
            this.labelced.Text = "Cédula:";
            // 
            // loginwind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.grpBoxCteAcc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.labelpassw);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.cteuser);
            this.Controls.Add(this.ingresar);
            this.Controls.Add(this.menubarlogin);
            this.MainMenuStrip = this.menubarlogin;
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "loginwind";
            this.Text = "Gestión Académica";
            this.Load += new System.EventHandler(this.loginwind_Load);
            this.menubarlogin.ResumeLayout(false);
            this.menubarlogin.PerformLayout();
            this.grpBoxCteAcc.ResumeLayout(false);
            this.grpBoxCteAcc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).EndInit();
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
        private System.Windows.Forms.GroupBox grpBoxCteAcc;
        private System.Windows.Forms.Button addPicButton;
        private System.Windows.Forms.PictureBox userpic;
        private System.Windows.Forms.Label labelcont;
        private System.Windows.Forms.TextBox textcont;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.TextBox textquinniv;
        private System.Windows.Forms.Label labelquinniv;
        private System.Windows.Forms.TextBox textcuarniv;
        private System.Windows.Forms.Label labelcuarniv;
        private System.Windows.Forms.TextBox texttercniv;
        private System.Windows.Forms.TextBox textapel;
        private System.Windows.Forms.TextBox textnomb;
        private System.Windows.Forms.TextBox textced;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.Button buttoncreate;
        private System.Windows.Forms.Label labelterniv;
        private System.Windows.Forms.Label labelapel;
        private System.Windows.Forms.Label labelnomb;
        private System.Windows.Forms.Label labelced;
    }
}

