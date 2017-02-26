namespace PracticasU2.GUI
{
    partial class frm_Ejercicio7GUI
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
            this.lst_Articulos = new System.Windows.Forms.ListBox();
            this.lbl_Articulo = new System.Windows.Forms.Label();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.txt_CodArt = new System.Windows.Forms.TextBox();
            this.txt_NombreArt = new System.Windows.Forms.TextBox();
            this.txt_PrecioArt = new System.Windows.Forms.TextBox();
            this.txt_CantArt = new System.Windows.Forms.TextBox();
            this.pic_Imagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_Articulos
            // 
            this.lst_Articulos.FormattingEnabled = true;
            this.lst_Articulos.Items.AddRange(new object[] {
            "A001",
            "A002",
            "A003",
            "A004",
            "A005",
            "A006",
            "A007",
            "A008",
            "A009",
            "A010"});
            this.lst_Articulos.Location = new System.Drawing.Point(16, 32);
            this.lst_Articulos.Name = "lst_Articulos";
            this.lst_Articulos.Size = new System.Drawing.Size(75, 186);
            this.lst_Articulos.TabIndex = 0;
            this.lst_Articulos.SelectedIndexChanged += new System.EventHandler(this.lst_Articulos_SelectedIndexChanged);
            // 
            // lbl_Articulo
            // 
            this.lbl_Articulo.AutoSize = true;
            this.lbl_Articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Articulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_Articulo.Name = "lbl_Articulo";
            this.lbl_Articulo.Size = new System.Drawing.Size(70, 20);
            this.lbl_Articulo.TabIndex = 1;
            this.lbl_Articulo.Text = "Articulos";
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Codigo.Location = new System.Drawing.Point(178, 38);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(56, 18);
            this.lbl_Codigo.TabIndex = 2;
            this.lbl_Codigo.Text = "Codigo";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(97, 88);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(137, 18);
            this.lbl_Nombre.TabIndex = 3;
            this.lbl_Nombre.Text = "Nombre del articulo";
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Precio.Location = new System.Drawing.Point(183, 140);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(51, 18);
            this.lbl_Precio.TabIndex = 4;
            this.lbl_Precio.Text = "Precio";
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cantidad.Location = new System.Drawing.Point(168, 190);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(66, 18);
            this.lbl_Cantidad.TabIndex = 5;
            this.lbl_Cantidad.Text = "Cantidad";
            // 
            // txt_CodArt
            // 
            this.txt_CodArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodArt.Location = new System.Drawing.Point(240, 32);
            this.txt_CodArt.Name = "txt_CodArt";
            this.txt_CodArt.Size = new System.Drawing.Size(100, 24);
            this.txt_CodArt.TabIndex = 6;
            // 
            // txt_NombreArt
            // 
            this.txt_NombreArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreArt.Location = new System.Drawing.Point(240, 85);
            this.txt_NombreArt.Name = "txt_NombreArt";
            this.txt_NombreArt.Size = new System.Drawing.Size(100, 24);
            this.txt_NombreArt.TabIndex = 7;
            // 
            // txt_PrecioArt
            // 
            this.txt_PrecioArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PrecioArt.Location = new System.Drawing.Point(240, 137);
            this.txt_PrecioArt.Name = "txt_PrecioArt";
            this.txt_PrecioArt.Size = new System.Drawing.Size(100, 24);
            this.txt_PrecioArt.TabIndex = 8;
            // 
            // txt_CantArt
            // 
            this.txt_CantArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CantArt.Location = new System.Drawing.Point(240, 190);
            this.txt_CantArt.Name = "txt_CantArt";
            this.txt_CantArt.Size = new System.Drawing.Size(100, 24);
            this.txt_CantArt.TabIndex = 9;
            // 
            // pic_Imagen
            // 
            this.pic_Imagen.Location = new System.Drawing.Point(377, 32);
            this.pic_Imagen.Name = "pic_Imagen";
            this.pic_Imagen.Size = new System.Drawing.Size(311, 186);
            this.pic_Imagen.TabIndex = 10;
            this.pic_Imagen.TabStop = false;
            // 
            // frm_Ejercicio7GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 236);
            this.Controls.Add(this.pic_Imagen);
            this.Controls.Add(this.txt_CantArt);
            this.Controls.Add(this.txt_PrecioArt);
            this.Controls.Add(this.txt_NombreArt);
            this.Controls.Add(this.txt_CodArt);
            this.Controls.Add(this.lbl_Cantidad);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Codigo);
            this.Controls.Add(this.lbl_Articulo);
            this.Controls.Add(this.lst_Articulos);
            this.Name = "frm_Ejercicio7GUI";
            this.Text = "Ejercicio 7";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Articulos;
        private System.Windows.Forms.Label lbl_Articulo;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_CodArt;
        private System.Windows.Forms.TextBox txt_NombreArt;
        private System.Windows.Forms.TextBox txt_PrecioArt;
        private System.Windows.Forms.TextBox txt_CantArt;
        private System.Windows.Forms.PictureBox pic_Imagen;
    }
}