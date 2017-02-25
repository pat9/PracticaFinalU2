namespace PracticasU2.GUI
{
    partial class frm_Ejercicio2GUI
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
            this.grb_Libros = new System.Windows.Forms.GroupBox();
            this.chk_Libro5 = new System.Windows.Forms.CheckBox();
            this.chk_Libro4 = new System.Windows.Forms.CheckBox();
            this.chk_Libro3 = new System.Windows.Forms.CheckBox();
            this.chk_Libro2 = new System.Windows.Forms.CheckBox();
            this.chk_Libro1 = new System.Windows.Forms.CheckBox();
            this.lbl_NumLib = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txt_NumLib = new System.Windows.Forms.TextBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_Simbolo = new System.Windows.Forms.Label();
            this.grb_Libros.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_Libros
            // 
            this.grb_Libros.Controls.Add(this.chk_Libro5);
            this.grb_Libros.Controls.Add(this.chk_Libro4);
            this.grb_Libros.Controls.Add(this.chk_Libro3);
            this.grb_Libros.Controls.Add(this.chk_Libro2);
            this.grb_Libros.Controls.Add(this.chk_Libro1);
            this.grb_Libros.Location = new System.Drawing.Point(22, 13);
            this.grb_Libros.Name = "grb_Libros";
            this.grb_Libros.Size = new System.Drawing.Size(131, 147);
            this.grb_Libros.TabIndex = 0;
            this.grb_Libros.TabStop = false;
            this.grb_Libros.Text = "Libros";
            this.grb_Libros.Enter += new System.EventHandler(this.grb_Libros_Enter);
            // 
            // chk_Libro5
            // 
            this.chk_Libro5.AutoSize = true;
            this.chk_Libro5.Location = new System.Drawing.Point(6, 110);
            this.chk_Libro5.Name = "chk_Libro5";
            this.chk_Libro5.Size = new System.Drawing.Size(89, 17);
            this.chk_Libro5.TabIndex = 4;
            this.chk_Libro5.Text = "Node.js $160";
            this.chk_Libro5.UseVisualStyleBackColor = true;
            this.chk_Libro5.CheckedChanged += new System.EventHandler(this.chk_Libro5_CheckedChanged);
            // 
            // chk_Libro4
            // 
            this.chk_Libro4.AutoSize = true;
            this.chk_Libro4.Location = new System.Drawing.Point(7, 87);
            this.chk_Libro4.Name = "chk_Libro4";
            this.chk_Libro4.Size = new System.Drawing.Size(89, 17);
            this.chk_Libro4.TabIndex = 3;
            this.chk_Libro4.Text = "Andorid $150";
            this.chk_Libro4.UseVisualStyleBackColor = true;
            this.chk_Libro4.CheckedChanged += new System.EventHandler(this.chk_Libro4_CheckedChanged);
            // 
            // chk_Libro3
            // 
            this.chk_Libro3.AutoSize = true;
            this.chk_Libro3.Location = new System.Drawing.Point(6, 66);
            this.chk_Libro3.Name = "chk_Libro3";
            this.chk_Libro3.Size = new System.Drawing.Size(67, 17);
            this.chk_Libro3.TabIndex = 2;
            this.chk_Libro3.Text = "C# $300";
            this.chk_Libro3.UseVisualStyleBackColor = true;
            this.chk_Libro3.CheckedChanged += new System.EventHandler(this.chk_Libro3_CheckedChanged);
            // 
            // chk_Libro2
            // 
            this.chk_Libro2.AutoSize = true;
            this.chk_Libro2.Location = new System.Drawing.Point(7, 43);
            this.chk_Libro2.Name = "chk_Libro2";
            this.chk_Libro2.Size = new System.Drawing.Size(76, 17);
            this.chk_Libro2.TabIndex = 1;
            this.chk_Libro2.Text = "Java $150";
            this.chk_Libro2.UseVisualStyleBackColor = true;
            this.chk_Libro2.CheckedChanged += new System.EventHandler(this.chk_Libro2_CheckedChanged);
            // 
            // chk_Libro1
            // 
            this.chk_Libro1.AutoSize = true;
            this.chk_Libro1.Location = new System.Drawing.Point(7, 20);
            this.chk_Libro1.Name = "chk_Libro1";
            this.chk_Libro1.Size = new System.Drawing.Size(84, 17);
            this.chk_Libro1.TabIndex = 0;
            this.chk_Libro1.Text = "Oracle $250";
            this.chk_Libro1.UseVisualStyleBackColor = true;
            this.chk_Libro1.CheckedChanged += new System.EventHandler(this.chk_Libro1_CheckedChanged);
            // 
            // lbl_NumLib
            // 
            this.lbl_NumLib.AutoSize = true;
            this.lbl_NumLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumLib.Location = new System.Drawing.Point(181, 22);
            this.lbl_NumLib.Name = "lbl_NumLib";
            this.lbl_NumLib.Size = new System.Drawing.Size(156, 24);
            this.lbl_NumLib.TabIndex = 1;
            this.lbl_NumLib.Text = "Numero de libros";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(361, 19);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(51, 24);
            this.lbl_Total.TabIndex = 2;
            this.lbl_Total.Text = "Total";
            // 
            // txt_NumLib
            // 
            this.txt_NumLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumLib.Location = new System.Drawing.Point(200, 46);
            this.txt_NumLib.Name = "txt_NumLib";
            this.txt_NumLib.Size = new System.Drawing.Size(111, 29);
            this.txt_NumLib.TabIndex = 3;
            // 
            // txt_Total
            // 
            this.txt_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.Location = new System.Drawing.Point(365, 46);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(100, 29);
            this.txt_Total.TabIndex = 4;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(228, 100);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(194, 37);
            this.btn_Calcular.TabIndex = 5;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lbl_Simbolo
            // 
            this.lbl_Simbolo.AutoSize = true;
            this.lbl_Simbolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Simbolo.Location = new System.Drawing.Point(339, 46);
            this.lbl_Simbolo.Name = "lbl_Simbolo";
            this.lbl_Simbolo.Size = new System.Drawing.Size(20, 24);
            this.lbl_Simbolo.TabIndex = 6;
            this.lbl_Simbolo.Text = "$";
            // 
            // frm_Ejercicio2GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 167);
            this.Controls.Add(this.lbl_Simbolo);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.txt_NumLib);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_NumLib);
            this.Controls.Add(this.grb_Libros);
            this.Name = "frm_Ejercicio2GUI";
            this.Text = "Libros";
            this.grb_Libros.ResumeLayout(false);
            this.grb_Libros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Libros;
        private System.Windows.Forms.CheckBox chk_Libro5;
        private System.Windows.Forms.CheckBox chk_Libro4;
        private System.Windows.Forms.CheckBox chk_Libro3;
        private System.Windows.Forms.CheckBox chk_Libro2;
        private System.Windows.Forms.CheckBox chk_Libro1;
        private System.Windows.Forms.Label lbl_NumLib;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox txt_NumLib;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_Simbolo;
    }
}