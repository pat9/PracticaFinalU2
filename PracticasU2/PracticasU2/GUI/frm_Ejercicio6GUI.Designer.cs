namespace PracticasU2.GUI
{
    partial class frm_Ejercicio6GUI
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
            this.pic_Dado1 = new System.Windows.Forms.PictureBox();
            this.pic_Dado2 = new System.Windows.Forms.PictureBox();
            this.btn_LanzarDatos = new System.Windows.Forms.Button();
            this.dgt_Juegos = new System.Windows.Forms.DataGridView();
            this.NumeroLanzamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dado1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dado2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Dado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Dado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Juegos)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Dado1
            // 
            this.pic_Dado1.Image = global::PracticasU2.Properties.Resources.Dado1;
            this.pic_Dado1.Location = new System.Drawing.Point(81, 47);
            this.pic_Dado1.Name = "pic_Dado1";
            this.pic_Dado1.Size = new System.Drawing.Size(161, 143);
            this.pic_Dado1.TabIndex = 0;
            this.pic_Dado1.TabStop = false;
            // 
            // pic_Dado2
            // 
            this.pic_Dado2.Image = global::PracticasU2.Properties.Resources.Dado1;
            this.pic_Dado2.Location = new System.Drawing.Point(407, 47);
            this.pic_Dado2.Name = "pic_Dado2";
            this.pic_Dado2.Size = new System.Drawing.Size(161, 143);
            this.pic_Dado2.TabIndex = 1;
            this.pic_Dado2.TabStop = false;
            // 
            // btn_LanzarDatos
            // 
            this.btn_LanzarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LanzarDatos.Location = new System.Drawing.Point(249, 227);
            this.btn_LanzarDatos.Name = "btn_LanzarDatos";
            this.btn_LanzarDatos.Size = new System.Drawing.Size(152, 48);
            this.btn_LanzarDatos.TabIndex = 2;
            this.btn_LanzarDatos.Text = "Lanzar Dados";
            this.btn_LanzarDatos.UseVisualStyleBackColor = true;
            this.btn_LanzarDatos.Click += new System.EventHandler(this.btn_LanzarDatos_Click);
            // 
            // dgt_Juegos
            // 
            this.dgt_Juegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt_Juegos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroLanzamiento,
            this.Dado1,
            this.Dado2,
            this.Total});
            this.dgt_Juegos.Location = new System.Drawing.Point(37, 303);
            this.dgt_Juegos.Name = "dgt_Juegos";
            this.dgt_Juegos.Size = new System.Drawing.Size(573, 150);
            this.dgt_Juegos.TabIndex = 3;
            this.dgt_Juegos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgt_Juegos_CellContentClick);
            // 
            // NumeroLanzamiento
            // 
            this.NumeroLanzamiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NumeroLanzamiento.HeaderText = "Numero de lanzamiento";
            this.NumeroLanzamiento.Name = "NumeroLanzamiento";
            this.NumeroLanzamiento.Width = 131;
            // 
            // Dado1
            // 
            this.Dado1.HeaderText = "Dado 1";
            this.Dado1.Name = "Dado1";
            // 
            // Dado2
            // 
            this.Dado2.HeaderText = "Dado 2";
            this.Dado2.Name = "Dado2";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // frm_Ejercicio6GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(642, 480);
            this.Controls.Add(this.dgt_Juegos);
            this.Controls.Add(this.btn_LanzarDatos);
            this.Controls.Add(this.pic_Dado2);
            this.Controls.Add(this.pic_Dado1);
            this.Name = "frm_Ejercicio6GUI";
            this.Text = "Dados";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Dado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Dado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Juegos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Dado1;
        private System.Windows.Forms.PictureBox pic_Dado2;
        private System.Windows.Forms.Button btn_LanzarDatos;
        private System.Windows.Forms.DataGridView dgt_Juegos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroLanzamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dado1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dado2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}