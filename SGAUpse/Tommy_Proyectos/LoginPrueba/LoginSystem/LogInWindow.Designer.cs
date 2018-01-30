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
            this.ingresarComoAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitmenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxCteAcc = new System.Windows.Forms.GroupBox();
            this.buttonVerDatos = new System.Windows.Forms.Button();
            this.grpBoxPregSeg = new System.Windows.Forms.GroupBox();
            this.labelPreg5 = new System.Windows.Forms.Label();
            this.labelPreg4 = new System.Windows.Forms.Label();
            this.labelPreg3 = new System.Windows.Forms.Label();
            this.labelPreg2 = new System.Windows.Forms.Label();
            this.textRespPreg5 = new System.Windows.Forms.TextBox();
            this.textRespPreg4 = new System.Windows.Forms.TextBox();
            this.textRespPreg3 = new System.Windows.Forms.TextBox();
            this.textRespPreg2 = new System.Windows.Forms.TextBox();
            this.textRespPreg1 = new System.Windows.Forms.TextBox();
            this.cmbBoxPreg5 = new System.Windows.Forms.ComboBox();
            this.cmbBoxPreg4 = new System.Windows.Forms.ComboBox();
            this.cmbBoxPreg3 = new System.Windows.Forms.ComboBox();
            this.cmbBoxPreg2 = new System.Windows.Forms.ComboBox();
            this.cmbBoxPreg1 = new System.Windows.Forms.ComboBox();
            this.labelPreg1 = new System.Windows.Forms.Label();
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
            this.passrecov = new System.Windows.Forms.Button();
            this.grpBoxRecPass = new System.Windows.Forms.GroupBox();
            this.grpBoxRecPassCorreo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonPassRecCancel = new System.Windows.Forms.Button();
            this.buttonPassRecAccept = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBoxRecPassMet = new System.Windows.Forms.ComboBox();
            this.grpBoxLogIn = new System.Windows.Forms.GroupBox();
            this.checkBoxAdminLogin = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menubarlogin.SuspendLayout();
            this.grpBoxCteAcc.SuspendLayout();
            this.grpBoxPregSeg.SuspendLayout();
            this.grpBoxRecPass.SuspendLayout();
            this.grpBoxRecPassCorreo.SuspendLayout();
            this.grpBoxLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // ingresar
            // 
            this.ingresar.Location = new System.Drawing.Point(260, 167);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(113, 23);
            this.ingresar.TabIndex = 0;
            this.ingresar.Text = "Ingresar";
            this.ingresar.UseVisualStyleBackColor = true;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // cteuser
            // 
            this.cteuser.Location = new System.Drawing.Point(260, 197);
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
            this.labeluser.Location = new System.Drawing.Point(57, 48);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(46, 13);
            this.labeluser.TabIndex = 2;
            this.labeluser.Text = "Usuario:";
            // 
            // labelpassw
            // 
            this.labelpassw.AutoSize = true;
            this.labelpassw.Location = new System.Drawing.Point(57, 84);
            this.labelpassw.Name = "labelpassw";
            this.labelpassw.Size = new System.Drawing.Size(64, 13);
            this.labelpassw.TabIndex = 3;
            this.labelpassw.Text = "Contraseña:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(189, 45);
            this.username.MaximumSize = new System.Drawing.Size(149, 20);
            this.username.MinimumSize = new System.Drawing.Size(149, 20);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(149, 20);
            this.username.TabIndex = 4;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(189, 81);
            this.password.MaximumSize = new System.Drawing.Size(149, 20);
            this.password.MinimumSize = new System.Drawing.Size(149, 20);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(149, 20);
            this.password.TabIndex = 5;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 16);
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
            this.menubarlogin.Size = new System.Drawing.Size(834, 24);
            this.menubarlogin.TabIndex = 7;
            this.menubarlogin.Text = "menuStrip1";
            this.menubarlogin.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menubarlogin_ItemClicked);
            // 
            // filemenu
            // 
            this.filemenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarComoAdministradorToolStripMenuItem,
            this.exitmenuitem});
            this.filemenu.Name = "filemenu";
            this.filemenu.Size = new System.Drawing.Size(37, 20);
            this.filemenu.Text = "&File";
            // 
            // ingresarComoAdministradorToolStripMenuItem
            // 
            this.ingresarComoAdministradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorToolStripMenuItem,
            this.docenteToolStripMenuItem});
            this.ingresarComoAdministradorToolStripMenuItem.Name = "ingresarComoAdministradorToolStripMenuItem";
            this.ingresarComoAdministradorToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.ingresarComoAdministradorToolStripMenuItem.Text = "Ingresar como...";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // docenteToolStripMenuItem
            // 
            this.docenteToolStripMenuItem.Name = "docenteToolStripMenuItem";
            this.docenteToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.docenteToolStripMenuItem.Text = "Docente";
            // 
            // exitmenuitem
            // 
            this.exitmenuitem.Name = "exitmenuitem";
            this.exitmenuitem.Size = new System.Drawing.Size(159, 22);
            this.exitmenuitem.Text = "&Exit";
            this.exitmenuitem.Click += new System.EventHandler(this.exitmenuitem_Click);
            // 
            // grpBoxCteAcc
            // 
            this.grpBoxCteAcc.Controls.Add(this.buttonVerDatos);
            this.grpBoxCteAcc.Controls.Add(this.grpBoxPregSeg);
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
            this.grpBoxCteAcc.Location = new System.Drawing.Point(397, 29);
            this.grpBoxCteAcc.Name = "grpBoxCteAcc";
            this.grpBoxCteAcc.Size = new System.Drawing.Size(425, 577);
            this.grpBoxCteAcc.TabIndex = 32;
            this.grpBoxCteAcc.TabStop = false;
            this.grpBoxCteAcc.Text = "Sistema de Gestión Académica";
            this.grpBoxCteAcc.Visible = false;
            // 
            // buttonVerDatos
            // 
            this.buttonVerDatos.Location = new System.Drawing.Point(292, 198);
            this.buttonVerDatos.Name = "buttonVerDatos";
            this.buttonVerDatos.Size = new System.Drawing.Size(127, 20);
            this.buttonVerDatos.TabIndex = 36;
            this.buttonVerDatos.Text = "Verificar Datos";
            this.buttonVerDatos.UseVisualStyleBackColor = true;
            this.buttonVerDatos.Click += new System.EventHandler(this.buttonVerDatos_Click);
            // 
            // grpBoxPregSeg
            // 
            this.grpBoxPregSeg.Controls.Add(this.labelPreg5);
            this.grpBoxPregSeg.Controls.Add(this.labelPreg4);
            this.grpBoxPregSeg.Controls.Add(this.labelPreg3);
            this.grpBoxPregSeg.Controls.Add(this.labelPreg2);
            this.grpBoxPregSeg.Controls.Add(this.textRespPreg5);
            this.grpBoxPregSeg.Controls.Add(this.textRespPreg4);
            this.grpBoxPregSeg.Controls.Add(this.textRespPreg3);
            this.grpBoxPregSeg.Controls.Add(this.textRespPreg2);
            this.grpBoxPregSeg.Controls.Add(this.textRespPreg1);
            this.grpBoxPregSeg.Controls.Add(this.cmbBoxPreg5);
            this.grpBoxPregSeg.Controls.Add(this.cmbBoxPreg4);
            this.grpBoxPregSeg.Controls.Add(this.cmbBoxPreg3);
            this.grpBoxPregSeg.Controls.Add(this.cmbBoxPreg2);
            this.grpBoxPregSeg.Controls.Add(this.cmbBoxPreg1);
            this.grpBoxPregSeg.Controls.Add(this.labelPreg1);
            this.grpBoxPregSeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxPregSeg.Location = new System.Drawing.Point(6, 220);
            this.grpBoxPregSeg.Name = "grpBoxPregSeg";
            this.grpBoxPregSeg.Size = new System.Drawing.Size(413, 288);
            this.grpBoxPregSeg.TabIndex = 34;
            this.grpBoxPregSeg.TabStop = false;
            this.grpBoxPregSeg.Text = "Preguntas de Seguridad";
            // 
            // labelPreg5
            // 
            this.labelPreg5.AutoSize = true;
            this.labelPreg5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreg5.Location = new System.Drawing.Point(41, 234);
            this.labelPreg5.Name = "labelPreg5";
            this.labelPreg5.Size = new System.Drawing.Size(62, 13);
            this.labelPreg5.TabIndex = 42;
            this.labelPreg5.Text = "Pregunta 5:";
            // 
            // labelPreg4
            // 
            this.labelPreg4.AutoSize = true;
            this.labelPreg4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreg4.Location = new System.Drawing.Point(41, 181);
            this.labelPreg4.Name = "labelPreg4";
            this.labelPreg4.Size = new System.Drawing.Size(62, 13);
            this.labelPreg4.TabIndex = 41;
            this.labelPreg4.Text = "Pregunta 4:";
            // 
            // labelPreg3
            // 
            this.labelPreg3.AutoSize = true;
            this.labelPreg3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreg3.Location = new System.Drawing.Point(41, 128);
            this.labelPreg3.Name = "labelPreg3";
            this.labelPreg3.Size = new System.Drawing.Size(62, 13);
            this.labelPreg3.TabIndex = 40;
            this.labelPreg3.Text = "Pregunta 3:";
            // 
            // labelPreg2
            // 
            this.labelPreg2.AutoSize = true;
            this.labelPreg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreg2.Location = new System.Drawing.Point(41, 75);
            this.labelPreg2.Name = "labelPreg2";
            this.labelPreg2.Size = new System.Drawing.Size(62, 13);
            this.labelPreg2.TabIndex = 39;
            this.labelPreg2.Text = "Pregunta 2:";
            // 
            // textRespPreg5
            // 
            this.textRespPreg5.Location = new System.Drawing.Point(136, 257);
            this.textRespPreg5.Name = "textRespPreg5";
            this.textRespPreg5.Size = new System.Drawing.Size(271, 20);
            this.textRespPreg5.TabIndex = 38;
            // 
            // textRespPreg4
            // 
            this.textRespPreg4.Location = new System.Drawing.Point(136, 205);
            this.textRespPreg4.Name = "textRespPreg4";
            this.textRespPreg4.Size = new System.Drawing.Size(271, 20);
            this.textRespPreg4.TabIndex = 37;
            this.textRespPreg4.TextChanged += new System.EventHandler(this.textRespPreg4_TextChanged);
            // 
            // textRespPreg3
            // 
            this.textRespPreg3.Location = new System.Drawing.Point(136, 152);
            this.textRespPreg3.Name = "textRespPreg3";
            this.textRespPreg3.Size = new System.Drawing.Size(271, 20);
            this.textRespPreg3.TabIndex = 36;
            // 
            // textRespPreg2
            // 
            this.textRespPreg2.Location = new System.Drawing.Point(136, 99);
            this.textRespPreg2.Name = "textRespPreg2";
            this.textRespPreg2.Size = new System.Drawing.Size(271, 20);
            this.textRespPreg2.TabIndex = 35;
            // 
            // textRespPreg1
            // 
            this.textRespPreg1.Location = new System.Drawing.Point(136, 46);
            this.textRespPreg1.Name = "textRespPreg1";
            this.textRespPreg1.Size = new System.Drawing.Size(271, 20);
            this.textRespPreg1.TabIndex = 34;
            // 
            // cmbBoxPreg5
            // 
            this.cmbBoxPreg5.FormattingEnabled = true;
            this.cmbBoxPreg5.Items.AddRange(new object[] {
            "¿Animal preferido?",
            "¿Medio de transporte preferido?",
            "¿Marca de ropa preferida?",
            "¿Prenda de vestir preferida?",
            "¿Caricatura preferida de la infancia?"});
            this.cmbBoxPreg5.Location = new System.Drawing.Point(136, 231);
            this.cmbBoxPreg5.Name = "cmbBoxPreg5";
            this.cmbBoxPreg5.Size = new System.Drawing.Size(271, 21);
            this.cmbBoxPreg5.TabIndex = 33;
            // 
            // cmbBoxPreg4
            // 
            this.cmbBoxPreg4.FormattingEnabled = true;
            this.cmbBoxPreg4.Items.AddRange(new object[] {
            "¿Estado o provincia donde ha residido la mayor parte de su vida?",
            "¿Ciudad donde ha residido la mayor parte de su vida?",
            "¿Lugar más preferido para visitar?",
            "¿Dirección del lugar donde ha residido la mayor parte de su vida?",
            "¿Lugar menos preferido para visitar?"});
            this.cmbBoxPreg4.Location = new System.Drawing.Point(136, 178);
            this.cmbBoxPreg4.Name = "cmbBoxPreg4";
            this.cmbBoxPreg4.Size = new System.Drawing.Size(271, 21);
            this.cmbBoxPreg4.TabIndex = 32;
            // 
            // cmbBoxPreg3
            // 
            this.cmbBoxPreg3.FormattingEnabled = true;
            this.cmbBoxPreg3.Items.AddRange(new object[] {
            "¿Su grupo musical favorito?",
            "¿Su pasatiempo favorito?",
            "¿Su deporte favorito?",
            "¿Su comida favorita?",
            "¿Su postre favorito?"});
            this.cmbBoxPreg3.Location = new System.Drawing.Point(136, 125);
            this.cmbBoxPreg3.Name = "cmbBoxPreg3";
            this.cmbBoxPreg3.Size = new System.Drawing.Size(271, 21);
            this.cmbBoxPreg3.TabIndex = 31;
            // 
            // cmbBoxPreg2
            // 
            this.cmbBoxPreg2.FormattingEnabled = true;
            this.cmbBoxPreg2.Items.AddRange(new object[] {
            "¿Cuál es el año de nacimiento de su abuelo paterno?",
            "¿Cuál es el año de nacimiento de su abuelo materno?",
            "¿Cómo se llama la escuela donde estudió?",
            "¿En qué tipo de vivienda vive actualmente?",
            "¿Cuál es la marca de su primer vehículo?"});
            this.cmbBoxPreg2.Location = new System.Drawing.Point(136, 72);
            this.cmbBoxPreg2.Name = "cmbBoxPreg2";
            this.cmbBoxPreg2.Size = new System.Drawing.Size(271, 21);
            this.cmbBoxPreg2.TabIndex = 30;
            // 
            // cmbBoxPreg1
            // 
            this.cmbBoxPreg1.AllowDrop = true;
            this.cmbBoxPreg1.FormattingEnabled = true;
            this.cmbBoxPreg1.Items.AddRange(new object[] {
            "¿Cuál es su color favorito?",
            "¿Cómo se llamaba su papá?",
            "¿Dónde vivía cuando era niño/a?",
            "¿Dónde estudió la escuela?",
            "¿En qué año se graduó de la Educación Secundaria?"});
            this.cmbBoxPreg1.Location = new System.Drawing.Point(136, 19);
            this.cmbBoxPreg1.Name = "cmbBoxPreg1";
            this.cmbBoxPreg1.Size = new System.Drawing.Size(271, 21);
            this.cmbBoxPreg1.TabIndex = 0;
            // 
            // labelPreg1
            // 
            this.labelPreg1.AutoSize = true;
            this.labelPreg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreg1.Location = new System.Drawing.Point(41, 22);
            this.labelPreg1.Name = "labelPreg1";
            this.labelPreg1.Size = new System.Drawing.Size(62, 13);
            this.labelPreg1.TabIndex = 29;
            this.labelPreg1.Text = "Pregunta 1:";
            // 
            // labelcont
            // 
            this.labelcont.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelcont.AutoSize = true;
            this.labelcont.Location = new System.Drawing.Point(25, 201);
            this.labelcont.Name = "labelcont";
            this.labelcont.Size = new System.Drawing.Size(64, 13);
            this.labelcont.TabIndex = 17;
            this.labelcont.Text = "Contraseña:";
            // 
            // textcont
            // 
            this.textcont.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textcont.Location = new System.Drawing.Point(142, 198);
            this.textcont.Name = "textcont";
            this.textcont.Size = new System.Drawing.Size(144, 20);
            this.textcont.TabIndex = 16;
            this.textcont.UseSystemPasswordChar = true;
            this.textcont.TextChanged += new System.EventHandler(this.textcont_TextChanged);
            // 
            // textusername
            // 
            this.textusername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textusername.Location = new System.Drawing.Point(142, 172);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(144, 20);
            this.textusername.TabIndex = 15;
            this.textusername.TextChanged += new System.EventHandler(this.textusername_TextChanged);
            // 
            // labelusername
            // 
            this.labelusername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelusername.AutoSize = true;
            this.labelusername.Location = new System.Drawing.Point(25, 175);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(46, 13);
            this.labelusername.TabIndex = 14;
            this.labelusername.Text = "Usuario:";
            // 
            // textquinniv
            // 
            this.textquinniv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textquinniv.Location = new System.Drawing.Point(142, 146);
            this.textquinniv.Name = "textquinniv";
            this.textquinniv.Size = new System.Drawing.Size(144, 20);
            this.textquinniv.TabIndex = 13;
            this.textquinniv.TextChanged += new System.EventHandler(this.textquinniv_TextChanged);
            // 
            // labelquinniv
            // 
            this.labelquinniv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelquinniv.AutoSize = true;
            this.labelquinniv.Location = new System.Drawing.Point(25, 149);
            this.labelquinniv.Name = "labelquinniv";
            this.labelquinniv.Size = new System.Drawing.Size(105, 13);
            this.labelquinniv.TabIndex = 12;
            this.labelquinniv.Text = "Título (Quinto Nivel):";
            // 
            // textcuarniv
            // 
            this.textcuarniv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textcuarniv.Location = new System.Drawing.Point(142, 120);
            this.textcuarniv.Name = "textcuarniv";
            this.textcuarniv.Size = new System.Drawing.Size(144, 20);
            this.textcuarniv.TabIndex = 11;
            this.textcuarniv.TextChanged += new System.EventHandler(this.textcuarniv_TextChanged);
            // 
            // labelcuarniv
            // 
            this.labelcuarniv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelcuarniv.AutoSize = true;
            this.labelcuarniv.Location = new System.Drawing.Point(25, 123);
            this.labelcuarniv.Name = "labelcuarniv";
            this.labelcuarniv.Size = new System.Drawing.Size(105, 13);
            this.labelcuarniv.TabIndex = 10;
            this.labelcuarniv.Text = "Título (Cuarto Nivel):";
            // 
            // texttercniv
            // 
            this.texttercniv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.texttercniv.Location = new System.Drawing.Point(142, 94);
            this.texttercniv.Name = "texttercniv";
            this.texttercniv.Size = new System.Drawing.Size(144, 20);
            this.texttercniv.TabIndex = 9;
            this.texttercniv.TextChanged += new System.EventHandler(this.texttercniv_TextChanged);
            // 
            // textapel
            // 
            this.textapel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textapel.Location = new System.Drawing.Point(142, 68);
            this.textapel.Name = "textapel";
            this.textapel.Size = new System.Drawing.Size(144, 20);
            this.textapel.TabIndex = 8;
            this.textapel.TextChanged += new System.EventHandler(this.textapel_TextChanged);
            // 
            // textnomb
            // 
            this.textnomb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textnomb.Location = new System.Drawing.Point(142, 42);
            this.textnomb.Name = "textnomb";
            this.textnomb.Size = new System.Drawing.Size(144, 20);
            this.textnomb.TabIndex = 7;
            this.textnomb.TextChanged += new System.EventHandler(this.textnomb_TextChanged);
            // 
            // textced
            // 
            this.textced.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textced.Location = new System.Drawing.Point(142, 16);
            this.textced.Name = "textced";
            this.textced.Size = new System.Drawing.Size(144, 20);
            this.textced.TabIndex = 6;
            this.textced.TextChanged += new System.EventHandler(this.textced_TextChanged);
            // 
            // buttoncancel
            // 
            this.buttoncancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttoncancel.Location = new System.Drawing.Point(344, 548);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(75, 23);
            this.buttoncancel.TabIndex = 5;
            this.buttoncancel.Text = "Cancelar";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // buttoncreate
            // 
            this.buttoncreate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttoncreate.Location = new System.Drawing.Point(344, 519);
            this.buttoncreate.Name = "buttoncreate";
            this.buttoncreate.Size = new System.Drawing.Size(75, 23);
            this.buttoncreate.TabIndex = 4;
            this.buttoncreate.Text = "Crear";
            this.buttoncreate.UseVisualStyleBackColor = true;
            this.buttoncreate.Click += new System.EventHandler(this.buttoncreate_Click);
            // 
            // labelterniv
            // 
            this.labelterniv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelterniv.AutoSize = true;
            this.labelterniv.Location = new System.Drawing.Point(25, 97);
            this.labelterniv.Name = "labelterniv";
            this.labelterniv.Size = new System.Drawing.Size(105, 13);
            this.labelterniv.TabIndex = 3;
            this.labelterniv.Text = "Título (Tercer Nivel):";
            // 
            // labelapel
            // 
            this.labelapel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelapel.AutoSize = true;
            this.labelapel.Location = new System.Drawing.Point(25, 71);
            this.labelapel.Name = "labelapel";
            this.labelapel.Size = new System.Drawing.Size(52, 13);
            this.labelapel.TabIndex = 2;
            this.labelapel.Text = "Apellidos:";
            // 
            // labelnomb
            // 
            this.labelnomb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelnomb.AutoSize = true;
            this.labelnomb.Location = new System.Drawing.Point(25, 45);
            this.labelnomb.Name = "labelnomb";
            this.labelnomb.Size = new System.Drawing.Size(52, 13);
            this.labelnomb.TabIndex = 1;
            this.labelnomb.Text = "Nombres:";
            // 
            // labelced
            // 
            this.labelced.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelced.AutoSize = true;
            this.labelced.Location = new System.Drawing.Point(25, 19);
            this.labelced.Name = "labelced";
            this.labelced.Size = new System.Drawing.Size(43, 13);
            this.labelced.TabIndex = 0;
            this.labelced.Text = "Cédula:";
            // 
            // passrecov
            // 
            this.passrecov.Location = new System.Drawing.Point(6, 184);
            this.passrecov.Name = "passrecov";
            this.passrecov.Size = new System.Drawing.Size(113, 36);
            this.passrecov.TabIndex = 33;
            this.passrecov.Text = "Recuperar Contraseña";
            this.passrecov.UseVisualStyleBackColor = true;
            this.passrecov.Click += new System.EventHandler(this.passrecov_Click);
            // 
            // grpBoxRecPass
            // 
            this.grpBoxRecPass.Controls.Add(this.grpBoxRecPassCorreo);
            this.grpBoxRecPass.Controls.Add(this.buttonPassRecCancel);
            this.grpBoxRecPass.Controls.Add(this.buttonPassRecAccept);
            this.grpBoxRecPass.Controls.Add(this.label2);
            this.grpBoxRecPass.Controls.Add(this.cmbBoxRecPassMet);
            this.grpBoxRecPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxRecPass.Location = new System.Drawing.Point(12, 261);
            this.grpBoxRecPass.Name = "grpBoxRecPass";
            this.grpBoxRecPass.Size = new System.Drawing.Size(379, 345);
            this.grpBoxRecPass.TabIndex = 34;
            this.grpBoxRecPass.TabStop = false;
            this.grpBoxRecPass.Text = "Recuperar Contraseña";
            this.grpBoxRecPass.Visible = false;
            this.grpBoxRecPass.Enter += new System.EventHandler(this.grpBoxRecPass_Enter);
            // 
            // grpBoxRecPassCorreo
            // 
            this.grpBoxRecPassCorreo.Controls.Add(this.label3);
            this.grpBoxRecPassCorreo.Controls.Add(this.textBox1);
            this.grpBoxRecPassCorreo.Location = new System.Drawing.Point(6, 61);
            this.grpBoxRecPassCorreo.Name = "grpBoxRecPassCorreo";
            this.grpBoxRecPassCorreo.Size = new System.Drawing.Size(367, 99);
            this.grpBoxRecPassCorreo.TabIndex = 6;
            this.grpBoxRecPassCorreo.TabStop = false;
            this.grpBoxRecPassCorreo.Text = "Recuperación de contraseña por correo electrónico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese su dirección de correo electrónico:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 20);
            this.textBox1.TabIndex = 5;
            // 
            // buttonPassRecCancel
            // 
            this.buttonPassRecCancel.Enabled = false;
            this.buttonPassRecCancel.Location = new System.Drawing.Point(241, 309);
            this.buttonPassRecCancel.Name = "buttonPassRecCancel";
            this.buttonPassRecCancel.Size = new System.Drawing.Size(132, 29);
            this.buttonPassRecCancel.TabIndex = 3;
            this.buttonPassRecCancel.Text = "Cancelar";
            this.buttonPassRecCancel.UseVisualStyleBackColor = true;
            // 
            // buttonPassRecAccept
            // 
            this.buttonPassRecAccept.Enabled = false;
            this.buttonPassRecAccept.Location = new System.Drawing.Point(241, 278);
            this.buttonPassRecAccept.Name = "buttonPassRecAccept";
            this.buttonPassRecAccept.Size = new System.Drawing.Size(132, 29);
            this.buttonPassRecAccept.TabIndex = 2;
            this.buttonPassRecAccept.Text = "Aceptar";
            this.buttonPassRecAccept.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "¿Cómo desea recuperar su Contraseña?";
            // 
            // cmbBoxRecPassMet
            // 
            this.cmbBoxRecPassMet.FormattingEnabled = true;
            this.cmbBoxRecPassMet.Items.AddRange(new object[] {
            "Enviar contraseña provisional al correo...",
            "Solicitar contraseña actual al administrador..."});
            this.cmbBoxRecPassMet.Location = new System.Drawing.Point(6, 34);
            this.cmbBoxRecPassMet.Name = "cmbBoxRecPassMet";
            this.cmbBoxRecPassMet.Size = new System.Drawing.Size(367, 21);
            this.cmbBoxRecPassMet.TabIndex = 0;
            this.cmbBoxRecPassMet.SelectedIndexChanged += new System.EventHandler(this.cmbBoxRecPassMet_SelectedIndexChanged);
            // 
            // grpBoxLogIn
            // 
            this.grpBoxLogIn.Controls.Add(this.label4);
            this.grpBoxLogIn.Controls.Add(this.textBox2);
            this.grpBoxLogIn.Controls.Add(this.checkBoxAdminLogin);
            this.grpBoxLogIn.Controls.Add(this.passrecov);
            this.grpBoxLogIn.Controls.Add(this.label1);
            this.grpBoxLogIn.Controls.Add(this.labeluser);
            this.grpBoxLogIn.Controls.Add(this.password);
            this.grpBoxLogIn.Controls.Add(this.labelpassw);
            this.grpBoxLogIn.Controls.Add(this.username);
            this.grpBoxLogIn.Controls.Add(this.cteuser);
            this.grpBoxLogIn.Controls.Add(this.ingresar);
            this.grpBoxLogIn.Location = new System.Drawing.Point(12, 29);
            this.grpBoxLogIn.Name = "grpBoxLogIn";
            this.grpBoxLogIn.Size = new System.Drawing.Size(379, 226);
            this.grpBoxLogIn.TabIndex = 35;
            this.grpBoxLogIn.TabStop = false;
            // 
            // checkBoxAdminLogin
            // 
            this.checkBoxAdminLogin.AutoSize = true;
            this.checkBoxAdminLogin.Location = new System.Drawing.Point(134, 144);
            this.checkBoxAdminLogin.Name = "checkBoxAdminLogin";
            this.checkBoxAdminLogin.Size = new System.Drawing.Size(159, 17);
            this.checkBoxAdminLogin.TabIndex = 34;
            this.checkBoxAdminLogin.Text = "Ingresar como Administrador";
            this.checkBoxAdminLogin.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(189, 116);
            this.textBox2.MaximumSize = new System.Drawing.Size(149, 20);
            this.textBox2.MinimumSize = new System.Drawing.Size(149, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 20);
            this.textBox2.TabIndex = 35;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Código de Autenticación:";
            // 
            // loginwind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.grpBoxLogIn);
            this.Controls.Add(this.grpBoxRecPass);
            this.Controls.Add(this.grpBoxCteAcc);
            this.Controls.Add(this.menubarlogin);
            this.MainMenuStrip = this.menubarlogin;
            this.MaximumSize = new System.Drawing.Size(850, 650);
            this.MinimumSize = new System.Drawing.Size(413, 300);
            this.Name = "loginwind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Académica";
            this.Load += new System.EventHandler(this.loginwind_Load);
            this.menubarlogin.ResumeLayout(false);
            this.menubarlogin.PerformLayout();
            this.grpBoxCteAcc.ResumeLayout(false);
            this.grpBoxCteAcc.PerformLayout();
            this.grpBoxPregSeg.ResumeLayout(false);
            this.grpBoxPregSeg.PerformLayout();
            this.grpBoxRecPass.ResumeLayout(false);
            this.grpBoxRecPass.PerformLayout();
            this.grpBoxRecPassCorreo.ResumeLayout(false);
            this.grpBoxRecPassCorreo.PerformLayout();
            this.grpBoxLogIn.ResumeLayout(false);
            this.grpBoxLogIn.PerformLayout();
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
        private System.Windows.Forms.Label labelterniv;
        private System.Windows.Forms.Label labelapel;
        private System.Windows.Forms.Label labelnomb;
        private System.Windows.Forms.Label labelced;
        private System.Windows.Forms.Button passrecov;
        private System.Windows.Forms.GroupBox grpBoxRecPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoxRecPassMet;
        private System.Windows.Forms.GroupBox grpBoxPregSeg;
        private System.Windows.Forms.TextBox textRespPreg5;
        private System.Windows.Forms.TextBox textRespPreg4;
        private System.Windows.Forms.TextBox textRespPreg3;
        private System.Windows.Forms.TextBox textRespPreg2;
        private System.Windows.Forms.TextBox textRespPreg1;
        private System.Windows.Forms.ComboBox cmbBoxPreg5;
        private System.Windows.Forms.ComboBox cmbBoxPreg4;
        private System.Windows.Forms.ComboBox cmbBoxPreg3;
        private System.Windows.Forms.ComboBox cmbBoxPreg2;
        private System.Windows.Forms.ComboBox cmbBoxPreg1;
        private System.Windows.Forms.Label labelPreg1;
        private System.Windows.Forms.Label labelPreg5;
        private System.Windows.Forms.Label labelPreg4;
        private System.Windows.Forms.Label labelPreg3;
        private System.Windows.Forms.Label labelPreg2;
        private System.Windows.Forms.GroupBox grpBoxLogIn;
        private System.Windows.Forms.Button buttonPassRecAccept;
        private System.Windows.Forms.Button buttonPassRecCancel;
        private System.Windows.Forms.ToolStripMenuItem ingresarComoAdministradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        public System.Windows.Forms.GroupBox grpBoxCteAcc;
        public System.Windows.Forms.Button buttonVerDatos;
        public System.Windows.Forms.Button buttoncreate;
        private System.Windows.Forms.GroupBox grpBoxRecPassCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBoxAdminLogin;
    }
}

