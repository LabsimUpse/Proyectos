namespace LoginSystem
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // ingresar
            // 
            this.ingresar.Location = new System.Drawing.Point(172, 196);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(113, 23);
            this.ingresar.TabIndex = 0;
            this.ingresar.Text = "Ingresar";
            this.ingresar.UseVisualStyleBackColor = true;
            // 
            // cteuser
            // 
            this.cteuser.Location = new System.Drawing.Point(171, 226);
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
            this.labeluser.Location = new System.Drawing.Point(33, 99);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(46, 13);
            this.labeluser.TabIndex = 2;
            this.labeluser.Text = "Usuario:";
            // 
            // labelpassw
            // 
            this.labelpassw.AutoSize = true;
            this.labelpassw.Location = new System.Drawing.Point(33, 135);
            this.labelpassw.Name = "labelpassw";
            this.labelpassw.Size = new System.Drawing.Size(64, 13);
            this.labelpassw.TabIndex = 3;
            this.labelpassw.Text = "Contraseña:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(112, 96);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(149, 20);
            this.username.TabIndex = 4;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(112, 128);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(149, 20);
            this.password.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sistema de Gestión Académica";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.labelpassw);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.cteuser);
            this.Controls.Add(this.ingresar);
            this.Name = "Form1";
            this.Text = "Gestión Académica";
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
    }
}

