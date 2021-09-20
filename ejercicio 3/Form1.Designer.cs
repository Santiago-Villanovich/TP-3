
namespace ejercicio_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.TextBox();
            this.sumar = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.textoNumeros = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ingresar los valores a sumar a continuacion";
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(166, 70);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(207, 20);
            this.numero.TabIndex = 1;
            // 
            // sumar
            // 
            this.sumar.Location = new System.Drawing.Point(195, 113);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(60, 37);
            this.sumar.TabIndex = 2;
            this.sumar.Text = "+";
            this.sumar.UseVisualStyleBackColor = true;
            this.sumar.Click += new System.EventHandler(this.sumar_Click);
            // 
            // resta
            // 
            this.resta.Location = new System.Drawing.Point(281, 113);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(60, 37);
            this.resta.TabIndex = 3;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // igual
            // 
            this.igual.Location = new System.Drawing.Point(195, 156);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(146, 36);
            this.igual.TabIndex = 4;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.resultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultado.Location = new System.Drawing.Point(195, 279);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(146, 15);
            this.resultado.TabIndex = 5;
            this.resultado.Text = "(su resultado aparecera aqui)";
            // 
            // textoNumeros
            // 
            this.textoNumeros.Location = new System.Drawing.Point(105, 221);
            this.textoNumeros.Name = "textoNumeros";
            this.textoNumeros.Size = new System.Drawing.Size(312, 20);
            this.textoNumeros.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 405);
            this.Controls.Add(this.textoNumeros);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.TextBox textoNumeros;
    }
}

