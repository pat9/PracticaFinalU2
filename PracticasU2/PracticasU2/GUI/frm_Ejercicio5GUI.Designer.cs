namespace PracticasU2.GUI
{
    partial class frm_Ejercicio5GUI
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
            this.lst_Libros = new System.Windows.Forms.ListBox();
            this.lst_LibroCompra = new System.Windows.Forms.ListBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Quitar = new System.Windows.Forms.Button();
            this.lbl_Libros = new System.Windows.Forms.Label();
            this.lbl_Librocompra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_Libros
            // 
            this.lst_Libros.FormattingEnabled = true;
            this.lst_Libros.Items.AddRange(new object[] {
            "SQL SERVER 2008",
            "BASE DE DATOS AVANZADAS",
            "ORACLE",
            "VISUAL STUDIO 2010",
            "OFICCE",
            "MACROMEDIA FLASH MX",
            "WINDOWS 2008",
            "TIMERS",
            "TEXTO DE CUENTOS ",
            "HOJAS DE CALCULO"});
            this.lst_Libros.Location = new System.Drawing.Point(12, 33);
            this.lst_Libros.Name = "lst_Libros";
            this.lst_Libros.Size = new System.Drawing.Size(225, 212);
            this.lst_Libros.TabIndex = 0;
            // 
            // lst_LibroCompra
            // 
            this.lst_LibroCompra.FormattingEnabled = true;
            this.lst_LibroCompra.Location = new System.Drawing.Point(387, 33);
            this.lst_LibroCompra.Name = "lst_LibroCompra";
            this.lst_LibroCompra.Size = new System.Drawing.Size(225, 212);
            this.lst_LibroCompra.TabIndex = 1;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Location = new System.Drawing.Point(272, 66);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 29);
            this.btn_Agregar.TabIndex = 2;
            this.btn_Agregar.Text = ">>>";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Quitar
            // 
            this.btn_Quitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quitar.Location = new System.Drawing.Point(272, 122);
            this.btn_Quitar.Name = "btn_Quitar";
            this.btn_Quitar.Size = new System.Drawing.Size(75, 29);
            this.btn_Quitar.TabIndex = 3;
            this.btn_Quitar.Text = "<<<";
            this.btn_Quitar.UseVisualStyleBackColor = true;
            this.btn_Quitar.Click += new System.EventHandler(this.btn_Quitar_Click);
            // 
            // lbl_Libros
            // 
            this.lbl_Libros.AutoSize = true;
            this.lbl_Libros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Libros.Location = new System.Drawing.Point(21, 12);
            this.lbl_Libros.Name = "lbl_Libros";
            this.lbl_Libros.Size = new System.Drawing.Size(49, 18);
            this.lbl_Libros.TabIndex = 4;
            this.lbl_Libros.Text = "Libros";
            // 
            // lbl_Librocompra
            // 
            this.lbl_Librocompra.AutoSize = true;
            this.lbl_Librocompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Librocompra.Location = new System.Drawing.Point(384, 9);
            this.lbl_Librocompra.Name = "lbl_Librocompra";
            this.lbl_Librocompra.Size = new System.Drawing.Size(135, 18);
            this.lbl_Librocompra.TabIndex = 5;
            this.lbl_Librocompra.Text = "Libros por comprar";
            // 
            // frm_Ejercicio5GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 261);
            this.Controls.Add(this.lbl_Librocompra);
            this.Controls.Add(this.lbl_Libros);
            this.Controls.Add(this.btn_Quitar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lst_LibroCompra);
            this.Controls.Add(this.lst_Libros);
            this.Name = "frm_Ejercicio5GUI";
            this.Text = "Libros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Libros;
        private System.Windows.Forms.ListBox lst_LibroCompra;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Quitar;
        private System.Windows.Forms.Label lbl_Libros;
        private System.Windows.Forms.Label lbl_Librocompra;
    }
}