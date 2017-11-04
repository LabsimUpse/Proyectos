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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textced = new System.Windows.Forms.TextBox();
            this.texttitun = new System.Windows.Forms.TextBox();
            this.textapel = new System.Windows.Forms.TextBox();
            this.textnomb = new System.Windows.Forms.TextBox();
            this.textuser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Título Universitario:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textced
            // 
            this.textced.Location = new System.Drawing.Point(128, 27);
            this.textced.Name = "textced";
            this.textced.Size = new System.Drawing.Size(144, 20);
            this.textced.TabIndex = 6;
            this.textced.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // texttitun
            // 
            this.texttitun.Location = new System.Drawing.Point(128, 105);
            this.texttitun.Name = "texttitun";
            this.texttitun.Size = new System.Drawing.Size(144, 20);
            this.texttitun.TabIndex = 7;
            this.texttitun.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textapel
            // 
            this.textapel.Location = new System.Drawing.Point(128, 79);
            this.textapel.Name = "textapel";
            this.textapel.Size = new System.Drawing.Size(144, 20);
            this.textapel.TabIndex = 8;
            this.textapel.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textnomb
            // 
            this.textnomb.Location = new System.Drawing.Point(128, 53);
            this.textnomb.Name = "textnomb";
            this.textnomb.Size = new System.Drawing.Size(144, 20);
            this.textnomb.TabIndex = 9;
            this.textnomb.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textuser
            // 
            this.textuser.Location = new System.Drawing.Point(128, 131);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(144, 20);
            this.textuser.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Usuario:";
            // 
            // cteaccwind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textnomb);
            this.Controls.Add(this.textapel);
            this.Controls.Add(this.texttitun);
            this.Controls.Add(this.textced);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cteaccwind";
            this.Text = "Crear Cuenta";
            this.Load += new System.EventHandler(this.cteaccwind_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textced;
        private System.Windows.Forms.TextBox texttitun;
        private System.Windows.Forms.TextBox textapel;
        private System.Windows.Forms.TextBox textnomb;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.Label label5;
    }
}