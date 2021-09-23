
namespace ejercicio_10
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
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selector = new System.Windows.Forms.ComboBox();
            this.celsius = new System.Windows.Forms.Button();
            this.fahrenheit = new System.Windows.Forms.Button();
            this.kelvin = new System.Windows.Forms.Button();
            this.rankine = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.nuevaTemp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.input.Location = new System.Drawing.Point(36, 78);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(59, 23);
            this.input.TabIndex = 0;
            this.input.Text = "0";
            this.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(32, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese la temperatura ";
            // 
            // selector
            // 
            this.selector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.selector.FormattingEnabled = true;
            this.selector.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin",
            "Rankine"});
            this.selector.Location = new System.Drawing.Point(101, 78);
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(94, 24);
            this.selector.TabIndex = 2;
            this.selector.Text = "temperatura";
            this.selector.SelectedIndexChanged += new System.EventHandler(this.selector_SelectedIndexChanged);
            // 
            // celsius
            // 
            this.celsius.Location = new System.Drawing.Point(49, 174);
            this.celsius.Name = "celsius";
            this.celsius.Size = new System.Drawing.Size(66, 27);
            this.celsius.TabIndex = 3;
            this.celsius.Text = "Celsius";
            this.celsius.UseVisualStyleBackColor = true;
            this.celsius.Click += new System.EventHandler(this.celsius_Click);
            // 
            // fahrenheit
            // 
            this.fahrenheit.Location = new System.Drawing.Point(121, 174);
            this.fahrenheit.Name = "fahrenheit";
            this.fahrenheit.Size = new System.Drawing.Size(66, 27);
            this.fahrenheit.TabIndex = 4;
            this.fahrenheit.Text = "Fahrenheit";
            this.fahrenheit.UseVisualStyleBackColor = true;
            this.fahrenheit.Click += new System.EventHandler(this.fahrenheit_Click);
            // 
            // kelvin
            // 
            this.kelvin.Location = new System.Drawing.Point(49, 207);
            this.kelvin.Name = "kelvin";
            this.kelvin.Size = new System.Drawing.Size(66, 27);
            this.kelvin.TabIndex = 5;
            this.kelvin.Text = "Kelvin";
            this.kelvin.UseVisualStyleBackColor = true;
            this.kelvin.Click += new System.EventHandler(this.kelvin_Click);
            // 
            // rankine
            // 
            this.rankine.Location = new System.Drawing.Point(121, 207);
            this.rankine.Name = "rankine";
            this.rankine.Size = new System.Drawing.Size(66, 27);
            this.rankine.TabIndex = 6;
            this.rankine.Text = "Rankine";
            this.rankine.UseVisualStyleBackColor = true;
            this.rankine.Click += new System.EventHandler(this.rankine_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(80, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pasaje a:";
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.output.Location = new System.Drawing.Point(57, 283);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(58, 23);
            this.output.TabIndex = 8;
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nuevaTemp
            // 
            this.nuevaTemp.AutoSize = true;
            this.nuevaTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nuevaTemp.Location = new System.Drawing.Point(121, 283);
            this.nuevaTemp.Name = "nuevaTemp";
            this.nuevaTemp.Size = new System.Drawing.Size(51, 20);
            this.nuevaTemp.TabIndex = 9;
            this.nuevaTemp.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 371);
            this.Controls.Add(this.nuevaTemp);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rankine);
            this.Controls.Add(this.kelvin);
            this.Controls.Add(this.fahrenheit);
            this.Controls.Add(this.celsius);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selector;
        private System.Windows.Forms.Button celsius;
        private System.Windows.Forms.Button fahrenheit;
        private System.Windows.Forms.Button kelvin;
        private System.Windows.Forms.Button rankine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label nuevaTemp;
    }
}

