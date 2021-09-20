
namespace ejercicio_5
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
            this.maximo = new System.Windows.Forms.TextBox();
            this.minimo = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculador numeros primos ";
            // 
            // maximo
            // 
            this.maximo.Location = new System.Drawing.Point(59, 97);
            this.maximo.Name = "maximo";
            this.maximo.Size = new System.Drawing.Size(126, 20);
            this.maximo.TabIndex = 1;
            this.maximo.Text = "(Ingrese un valor maximo)";
            this.maximo.Click += new System.EventHandler(this.maximo_Click);
            this.maximo.TextChanged += new System.EventHandler(this.maximo_TextChanged);
            // 
            // minimo
            // 
            this.minimo.Location = new System.Drawing.Point(59, 132);
            this.minimo.Name = "minimo";
            this.minimo.Size = new System.Drawing.Size(126, 20);
            this.minimo.TabIndex = 2;
            this.minimo.Text = "(Ingrese un valor minimo)";
            this.minimo.Click += new System.EventHandler(this.minimo_Click);
            // 
            // listBox1
            // 
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(250, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(94, 160);
            this.listBox1.TabIndex = 3;
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(90, 176);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(64, 27);
            this.calcular.TabIndex = 4;
            this.calcular.Text = "calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 404);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.minimo);
            this.Controls.Add(this.maximo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maximo;
        private System.Windows.Forms.TextBox minimo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button calcular;
    }
}

