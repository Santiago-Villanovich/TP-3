
namespace ejercicio_9
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tirar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.numGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(61, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 47);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dado 1";
            // 
            // tirar
            // 
            this.tirar.AutoSize = true;
            this.tirar.BackColor = System.Drawing.Color.Red;
            this.tirar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tirar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tirar.Font = new System.Drawing.Font("Impact", 14F);
            this.tirar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tirar.Location = new System.Drawing.Point(61, 121);
            this.tirar.Name = "tirar";
            this.tirar.Size = new System.Drawing.Size(153, 44);
            this.tirar.TabIndex = 3;
            this.tirar.Text = "tirar dado";
            this.tirar.UseVisualStyleBackColor = false;
            this.tirar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(172, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 47);
            this.label3.TabIndex = 7;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.IndianRed;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(158, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dado 2";
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numGrid,
            this.tiradas,
            this.porcentajeGrid});
            this.grid.Location = new System.Drawing.Point(45, 171);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(194, 162);
            this.grid.TabIndex = 8;
            // 
            // numGrid
            // 
            this.numGrid.HeaderText = "Numero";
            this.numGrid.Name = "numGrid";
            this.numGrid.ReadOnly = true;
            this.numGrid.Width = 50;
            // 
            // tiradas
            // 
            this.tiradas.HeaderText = "Tiradas";
            this.tiradas.Name = "tiradas";
            this.tiradas.ReadOnly = true;
            this.tiradas.Width = 50;
            // 
            // porcentajeGrid
            // 
            this.porcentajeGrid.HeaderText = "%";
            this.porcentajeGrid.Name = "porcentajeGrid";
            this.porcentajeGrid.ReadOnly = true;
            this.porcentajeGrid.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 398);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tirar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tirar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn numGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeGrid;
    }
}

