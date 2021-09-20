
namespace ejercicio_2
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
            this.label2 = new System.Windows.Forms.Label();
            this.numero1 = new System.Windows.Forms.TextBox();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.limpiar = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.resultado2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " numero 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "numero 2";
            // 
            // numero1
            // 
            this.numero1.Location = new System.Drawing.Point(135, 46);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(228, 20);
            this.numero1.TabIndex = 2;
            this.numero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // numero2
            // 
            this.numero2.Location = new System.Drawing.Point(136, 92);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(227, 20);
            this.numero2.TabIndex = 3;
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(135, 191);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(91, 26);
            this.limpiar.TabIndex = 5;
            this.limpiar.Text = "Clear";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // igual
            // 
            this.igual.Location = new System.Drawing.Point(272, 191);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(91, 26);
            this.igual.TabIndex = 6;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // resultado2
            // 
            this.resultado2.AutoSize = true;
            this.resultado2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.resultado2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultado2.Location = new System.Drawing.Point(171, 143);
            this.resultado2.Name = "resultado2";
            this.resultado2.Size = new System.Drawing.Size(146, 15);
            this.resultado2.TabIndex = 7;
            this.resultado2.Text = "(su resultado aparecera aqui)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sumador de dos numeros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 266);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultado2);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numero1;
        private System.Windows.Forms.TextBox numero2;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Label resultado2;
        private System.Windows.Forms.Label label3;
    }
}

