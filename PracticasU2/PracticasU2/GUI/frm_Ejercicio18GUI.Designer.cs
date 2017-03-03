namespace PracticasU2.GUI
{
    partial class frm_Ejercicio18GUI
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
            this.lbl_NEmpleados = new System.Windows.Forms.Label();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_Jovenes = new System.Windows.Forms.Label();
            this.txt_Jovenes = new System.Windows.Forms.TextBox();
            this.txt_Maduros = new System.Windows.Forms.TextBox();
            this.lbl_Maduros = new System.Windows.Forms.Label();
            this.txt_Mayores = new System.Windows.Forms.TextBox();
            this.lbl_Mayores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_NEmpleados
            // 
            this.lbl_NEmpleados.AutoSize = true;
            this.lbl_NEmpleados.Location = new System.Drawing.Point(29, 16);
            this.lbl_NEmpleados.Name = "lbl_NEmpleados";
            this.lbl_NEmpleados.Size = new System.Drawing.Size(113, 13);
            this.lbl_NEmpleados.TabIndex = 0;
            this.lbl_NEmpleados.Text = "Numero de empleados";
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(157, 13);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(100, 20);
            this.txt_Numero.TabIndex = 1;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(106, 51);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 2;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lbl_Jovenes
            // 
            this.lbl_Jovenes.AutoSize = true;
            this.lbl_Jovenes.Location = new System.Drawing.Point(53, 106);
            this.lbl_Jovenes.Name = "lbl_Jovenes";
            this.lbl_Jovenes.Size = new System.Drawing.Size(47, 13);
            this.lbl_Jovenes.TabIndex = 3;
            this.lbl_Jovenes.Text = "Jovenes";
            this.lbl_Jovenes.Click += new System.EventHandler(this.lbl_Jovenes_Click);
            // 
            // txt_Jovenes
            // 
            this.txt_Jovenes.Location = new System.Drawing.Point(106, 103);
            this.txt_Jovenes.Name = "txt_Jovenes";
            this.txt_Jovenes.Size = new System.Drawing.Size(100, 20);
            this.txt_Jovenes.TabIndex = 4;
            // 
            // txt_Maduros
            // 
            this.txt_Maduros.Location = new System.Drawing.Point(106, 133);
            this.txt_Maduros.Name = "txt_Maduros";
            this.txt_Maduros.Size = new System.Drawing.Size(100, 20);
            this.txt_Maduros.TabIndex = 6;
            // 
            // lbl_Maduros
            // 
            this.lbl_Maduros.AutoSize = true;
            this.lbl_Maduros.Location = new System.Drawing.Point(53, 136);
            this.lbl_Maduros.Name = "lbl_Maduros";
            this.lbl_Maduros.Size = new System.Drawing.Size(48, 13);
            this.lbl_Maduros.TabIndex = 5;
            this.lbl_Maduros.Text = "Maduros";
            // 
            // txt_Mayores
            // 
            this.txt_Mayores.Location = new System.Drawing.Point(105, 164);
            this.txt_Mayores.Name = "txt_Mayores";
            this.txt_Mayores.Size = new System.Drawing.Size(100, 20);
            this.txt_Mayores.TabIndex = 8;
            // 
            // lbl_Mayores
            // 
            this.lbl_Mayores.AutoSize = true;
            this.lbl_Mayores.Location = new System.Drawing.Point(52, 167);
            this.lbl_Mayores.Name = "lbl_Mayores";
            this.lbl_Mayores.Size = new System.Drawing.Size(47, 13);
            this.lbl_Mayores.TabIndex = 7;
            this.lbl_Mayores.Text = "Mayores";
            // 
            // frm_Ejercicio18GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 226);
            this.Controls.Add(this.txt_Mayores);
            this.Controls.Add(this.lbl_Mayores);
            this.Controls.Add(this.txt_Maduros);
            this.Controls.Add(this.lbl_Maduros);
            this.Controls.Add(this.txt_Jovenes);
            this.Controls.Add(this.lbl_Jovenes);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.lbl_NEmpleados);
            this.Name = "frm_Ejercicio18GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NEmpleados;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_Jovenes;
        private System.Windows.Forms.TextBox txt_Jovenes;
        private System.Windows.Forms.TextBox txt_Maduros;
        private System.Windows.Forms.Label lbl_Maduros;
        private System.Windows.Forms.TextBox txt_Mayores;
        private System.Windows.Forms.Label lbl_Mayores;
    }
}