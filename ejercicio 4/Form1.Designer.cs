
namespace ejercicio_4
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
            this.suma = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.potencia = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(66, 202);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(55, 40);
            this.suma.TabIndex = 0;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.button1_Click);
            // 
            // resta
            // 
            this.resta.Location = new System.Drawing.Point(66, 248);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(55, 40);
            this.resta.TabIndex = 1;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // multiplicacion
            // 
            this.multiplicacion.Location = new System.Drawing.Point(127, 202);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(55, 40);
            this.multiplicacion.TabIndex = 2;
            this.multiplicacion.Text = "x";
            this.multiplicacion.UseVisualStyleBackColor = true;
            this.multiplicacion.Click += new System.EventHandler(this.multiplicacion_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(127, 248);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(55, 40);
            this.division.TabIndex = 3;
            this.division.Text = "%";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // potencia
            // 
            this.potencia.Location = new System.Drawing.Point(188, 202);
            this.potencia.Name = "potencia";
            this.potencia.Size = new System.Drawing.Size(55, 40);
            this.potencia.TabIndex = 4;
            this.potencia.Text = "a^b";
            this.potencia.UseVisualStyleBackColor = true;
            this.potencia.Click += new System.EventHandler(this.potencia_Click);
            // 
            // raiz
            // 
            this.raiz.Location = new System.Drawing.Point(188, 248);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(55, 40);
            this.raiz.TabIndex = 5;
            this.raiz.Text = "√";
            this.raiz.UseVisualStyleBackColor = true;
            this.raiz.Click += new System.EventHandler(this.raiz_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(66, 294);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(177, 40);
            this.limpiar.TabIndex = 6;
            this.limpiar.Text = "C";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(142, 127);
            this.textBox.Name = "textBox";
            this.textBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox.Size = new System.Drawing.Size(92, 20);
            this.textBox.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textResultado
            // 
            this.textResultado.Location = new System.Drawing.Point(33, 82);
            this.textResultado.Name = "textResultado";
            this.textResultado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textResultado.Size = new System.Drawing.Size(249, 20);
            this.textResultado.TabIndex = 9;
            this.textResultado.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Valor a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Valor b";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 389);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.potencia);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button multiplicacion;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button potencia;
        private System.Windows.Forms.Button raiz;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

