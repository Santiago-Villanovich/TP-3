
namespace ejercicio_7
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.monto = new System.Windows.Forms.TextBox();
            this.tasa = new System.Windows.Forms.TextBox();
            this.dias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ingresar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.usuario = new System.Windows.Forms.TextBox();
            this.Nusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasaColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interesesColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nusuario,
            this.montoColumna,
            this.tasaColumna,
            this.diasColumna,
            this.interesesColumna});
            this.grid.Location = new System.Drawing.Point(63, 246);
            this.grid.Name = "grid";
            this.grid.RowHeadersVisible = false;
            this.grid.Size = new System.Drawing.Size(502, 145);
            this.grid.TabIndex = 0;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(159, 147);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(146, 20);
            this.monto.TabIndex = 1;
            // 
            // tasa
            // 
            this.tasa.Location = new System.Drawing.Point(159, 173);
            this.tasa.Name = "tasa";
            this.tasa.Size = new System.Drawing.Size(146, 20);
            this.tasa.TabIndex = 2;
            // 
            // dias
            // 
            this.dias.Location = new System.Drawing.Point(159, 199);
            this.dias.Name = "dias";
            this.dias.Size = new System.Drawing.Size(146, 20);
            this.dias.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Monto :\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tasa nominal actual :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "dias :";
            // 
            // ingresar
            // 
            this.ingresar.BackColor = System.Drawing.SystemColors.GrayText;
            this.ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ingresar.Location = new System.Drawing.Point(396, 137);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(132, 26);
            this.ingresar.TabIndex = 7;
            this.ingresar.Text = "Ingresar datos";
            this.ingresar.UseVisualStyleBackColor = false;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.SystemColors.GrayText;
            this.limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.limpiar.Location = new System.Drawing.Point(396, 169);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(132, 26);
            this.limpiar.TabIndex = 8;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = false;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(159, 93);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(146, 20);
            this.usuario.TabIndex = 9;
            // 
            // Nusuario
            // 
            this.Nusuario.HeaderText = "Numero de usuario";
            this.Nusuario.Name = "Nusuario";
            this.Nusuario.ReadOnly = true;
            // 
            // montoColumna
            // 
            this.montoColumna.HeaderText = "Monto";
            this.montoColumna.Name = "montoColumna";
            this.montoColumna.ReadOnly = true;
            // 
            // tasaColumna
            // 
            this.tasaColumna.HeaderText = "Tasa nominal actual";
            this.tasaColumna.Name = "tasaColumna";
            this.tasaColumna.ReadOnly = true;
            // 
            // diasColumna
            // 
            this.diasColumna.HeaderText = "Duracion de la imposicion";
            this.diasColumna.Name = "diasColumna";
            this.diasColumna.ReadOnly = true;
            // 
            // interesesColumna
            // 
            this.interesesColumna.HeaderText = "Intereses del plazo fijo";
            this.interesesColumna.Name = "interesesColumna";
            this.interesesColumna.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Usuario :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 403);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.ingresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dias);
            this.Controls.Add(this.tasa);
            this.Controls.Add(this.monto);
            this.Controls.Add(this.grid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox monto;
        private System.Windows.Forms.TextBox tasa;
        private System.Windows.Forms.TextBox dias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ingresar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasaColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn interesesColumna;
        private System.Windows.Forms.Label label4;
    }
}

