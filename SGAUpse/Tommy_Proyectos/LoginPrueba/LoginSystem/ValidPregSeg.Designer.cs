namespace LoginSystem
{
    partial class ValidPregSeg
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
            this.grpBoxValPregSeg = new System.Windows.Forms.GroupBox();
            this.buttonValidar = new System.Windows.Forms.Button();
            this.buttonCancelValid = new System.Windows.Forms.Button();
            this.textPregValid = new System.Windows.Forms.TextBox();
            this.textRespValid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBoxValPregSeg.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxValPregSeg
            // 
            this.grpBoxValPregSeg.Controls.Add(this.label2);
            this.grpBoxValPregSeg.Controls.Add(this.label1);
            this.grpBoxValPregSeg.Controls.Add(this.textRespValid);
            this.grpBoxValPregSeg.Controls.Add(this.textPregValid);
            this.grpBoxValPregSeg.Controls.Add(this.buttonCancelValid);
            this.grpBoxValPregSeg.Controls.Add(this.buttonValidar);
            this.grpBoxValPregSeg.Location = new System.Drawing.Point(12, 12);
            this.grpBoxValPregSeg.Name = "grpBoxValPregSeg";
            this.grpBoxValPregSeg.Size = new System.Drawing.Size(503, 183);
            this.grpBoxValPregSeg.TabIndex = 0;
            this.grpBoxValPregSeg.TabStop = false;
            this.grpBoxValPregSeg.Text = "Validación de Preguntas de Seguridad";
            // 
            // buttonValidar
            // 
            this.buttonValidar.Location = new System.Drawing.Point(405, 126);
            this.buttonValidar.Name = "buttonValidar";
            this.buttonValidar.Size = new System.Drawing.Size(92, 23);
            this.buttonValidar.TabIndex = 0;
            this.buttonValidar.Text = "Validar";
            this.buttonValidar.UseVisualStyleBackColor = true;
            this.buttonValidar.Click += new System.EventHandler(this.buttonValidar_Click);
            // 
            // buttonCancelValid
            // 
            this.buttonCancelValid.Location = new System.Drawing.Point(405, 155);
            this.buttonCancelValid.Name = "buttonCancelValid";
            this.buttonCancelValid.Size = new System.Drawing.Size(92, 22);
            this.buttonCancelValid.TabIndex = 1;
            this.buttonCancelValid.Text = "Cancelar";
            this.buttonCancelValid.UseVisualStyleBackColor = true;
            this.buttonCancelValid.Click += new System.EventHandler(this.buttonCancelValid_Click);
            // 
            // textPregValid
            // 
            this.textPregValid.Enabled = false;
            this.textPregValid.Location = new System.Drawing.Point(6, 46);
            this.textPregValid.Name = "textPregValid";
            this.textPregValid.Size = new System.Drawing.Size(491, 20);
            this.textPregValid.TabIndex = 2;
            // 
            // textRespValid
            // 
            this.textRespValid.Location = new System.Drawing.Point(6, 100);
            this.textRespValid.Name = "textRespValid";
            this.textRespValid.Size = new System.Drawing.Size(491, 20);
            this.textRespValid.TabIndex = 3;
            this.textRespValid.TextChanged += new System.EventHandler(this.textRespValid_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(6, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Respuesta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pregunta:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ValidPregSeg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 207);
            this.Controls.Add(this.grpBoxValPregSeg);
            this.Name = "ValidPregSeg";
            this.Text = "Sistema de Gestión Académica";
            this.grpBoxValPregSeg.ResumeLayout(false);
            this.grpBoxValPregSeg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxValPregSeg;
        private System.Windows.Forms.Button buttonValidar;
        private System.Windows.Forms.TextBox textPregValid;
        private System.Windows.Forms.Button buttonCancelValid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textRespValid;
    }
}