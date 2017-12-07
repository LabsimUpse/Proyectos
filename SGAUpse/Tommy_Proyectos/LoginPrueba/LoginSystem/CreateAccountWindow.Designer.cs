namespace LoginSystem
{
    partial class cteaccwind
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
            this.labelced = new System.Windows.Forms.Label();
            this.labelnomb = new System.Windows.Forms.Label();
            this.labelapel = new System.Windows.Forms.Label();
            this.labelterniv = new System.Windows.Forms.Label();
            this.buttoncreate = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.textced = new System.Windows.Forms.TextBox();
            this.textnomb = new System.Windows.Forms.TextBox();
            this.textapel = new System.Windows.Forms.TextBox();
            this.texttercniv = new System.Windows.Forms.TextBox();
            this.textcuarniv = new System.Windows.Forms.TextBox();
            this.labelcuarniv = new System.Windows.Forms.Label();
            this.labelquinniv = new System.Windows.Forms.Label();
            this.textquinniv = new System.Windows.Forms.TextBox();
            this.labelusername = new System.Windows.Forms.Label();
            this.textusername = new System.Windows.Forms.TextBox();
            this.textcont = new System.Windows.Forms.TextBox();
            this.labelcont = new System.Windows.Forms.Label();
            this.userpic = new System.Windows.Forms.PictureBox();
            this.addPicButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // labelnomb
            // 
            this.labelnomb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelnomb.AutoSize = true;
            this.labelnomb.Location = new System.Drawing.Point(155, 41);
            this.labelnomb.Name = "labelnomb";
            this.labelnomb.Size = new System.Drawing.Size(52, 13);
            this.labelnomb.TabIndex = 1;
            this.labelnomb.Text = "Nombres:";
            this.labelnomb.Click += new System.EventHandler(this.label2_Click);
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
            // textced
            // 
            this.textced.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textced.Location = new System.Drawing.Point(272, 12);
            this.textced.Name = "textced";
            this.textced.Size = new System.Drawing.Size(144, 20);
            this.textced.TabIndex = 6;
            this.textced.TextChanged += new System.EventHandler(this.textced_TextChanged);
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
            // textapel
            // 
            this.textapel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textapel.Location = new System.Drawing.Point(272, 64);
            this.textapel.Name = "textapel";
            this.textapel.Size = new System.Drawing.Size(144, 20);
            this.textapel.TabIndex = 8;
            this.textapel.TextChanged += new System.EventHandler(this.textapel_TextChanged);
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
            // textquinniv
            // 
            this.textquinniv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textquinniv.Location = new System.Drawing.Point(272, 142);
            this.textquinniv.Name = "textquinniv";
            this.textquinniv.Size = new System.Drawing.Size(144, 20);
            this.textquinniv.TabIndex = 13;
            this.textquinniv.TextChanged += new System.EventHandler(this.textquinniv_TextChanged);
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
            // textusername
            // 
            this.textusername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textusername.Location = new System.Drawing.Point(272, 168);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(144, 20);
            this.textusername.TabIndex = 15;
            this.textusername.TextChanged += new System.EventHandler(this.textusername_TextChanged);
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
            // userpic
            // 
            this.userpic.Location = new System.Drawing.Point(6, 15);
            this.userpic.Name = "userpic";
            this.userpic.Size = new System.Drawing.Size(135, 147);
            this.userpic.TabIndex = 27;
            this.userpic.TabStop = false;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addPicButton);
            this.groupBox1.Controls.Add(this.userpic);
            this.groupBox1.Controls.Add(this.labelcont);
            this.groupBox1.Controls.Add(this.textcont);
            this.groupBox1.Controls.Add(this.textusername);
            this.groupBox1.Controls.Add(this.labelusername);
            this.groupBox1.Controls.Add(this.textquinniv);
            this.groupBox1.Controls.Add(this.labelquinniv);
            this.groupBox1.Controls.Add(this.textcuarniv);
            this.groupBox1.Controls.Add(this.labelcuarniv);
            this.groupBox1.Controls.Add(this.texttercniv);
            this.groupBox1.Controls.Add(this.textapel);
            this.groupBox1.Controls.Add(this.textnomb);
            this.groupBox1.Controls.Add(this.textced);
            this.groupBox1.Controls.Add(this.buttoncancel);
            this.groupBox1.Controls.Add(this.buttoncreate);
            this.groupBox1.Controls.Add(this.labelterniv);
            this.groupBox1.Controls.Add(this.labelapel);
            this.groupBox1.Controls.Add(this.labelnomb);
            this.groupBox1.Controls.Add(this.labelced);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 280);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sistema de Gestión Académica";
            // 
            // cteaccwind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 304);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(465, 343);
            this.MinimumSize = new System.Drawing.Size(465, 343);
            this.Name = "cteaccwind";
            this.Text = "Crear Cuenta";
            this.Load += new System.EventHandler(this.cteaccwind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelced;
        private System.Windows.Forms.Label labelnomb;
        private System.Windows.Forms.Label labelapel;
        private System.Windows.Forms.Label labelterniv;
        private System.Windows.Forms.Button buttoncreate;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.TextBox textced;
        private System.Windows.Forms.TextBox textnomb;
        private System.Windows.Forms.TextBox textapel;
        private System.Windows.Forms.TextBox texttercniv;
        private System.Windows.Forms.TextBox textcuarniv;
        private System.Windows.Forms.Label labelcuarniv;
        private System.Windows.Forms.Label labelquinniv;
        private System.Windows.Forms.TextBox textquinniv;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.TextBox textcont;
        private System.Windows.Forms.Label labelcont;
        private System.Windows.Forms.PictureBox userpic;
        private System.Windows.Forms.Button addPicButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}