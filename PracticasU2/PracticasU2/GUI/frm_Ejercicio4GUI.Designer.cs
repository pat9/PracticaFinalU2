namespace PracticasU2.GUI
{
    partial class frm_Ejercicio4GUI
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
            this.grb_Operaciones = new System.Windows.Forms.GroupBox();
            this.rbt_Division = new System.Windows.Forms.RadioButton();
            this.rbt_Multipliacion = new System.Windows.Forms.RadioButton();
            this.rbt_Resta = new System.Windows.Forms.RadioButton();
            this.rbt_Suma = new System.Windows.Forms.RadioButton();
            this.lbl_Numero1 = new System.Windows.Forms.Label();
            this.lbl_Numero2 = new System.Windows.Forms.Label();
            this.txt_Num1 = new System.Windows.Forms.TextBox();
            this.txt_Num2 = new System.Windows.Forms.TextBox();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.grb_Operaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_Operaciones
            // 
            this.grb_Operaciones.Controls.Add(this.rbt_Division);
            this.grb_Operaciones.Controls.Add(this.rbt_Multipliacion);
            this.grb_Operaciones.Controls.Add(this.rbt_Resta);
            this.grb_Operaciones.Controls.Add(this.rbt_Suma);
            this.grb_Operaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Operaciones.Location = new System.Drawing.Point(46, 75);
            this.grb_Operaciones.Name = "grb_Operaciones";
            this.grb_Operaciones.Size = new System.Drawing.Size(173, 131);
            this.grb_Operaciones.TabIndex = 0;
            this.grb_Operaciones.TabStop = false;
            this.grb_Operaciones.Text = "Operacion";
            // 
            // rbt_Division
            // 
            this.rbt_Division.AutoSize = true;
            this.rbt_Division.Location = new System.Drawing.Point(7, 100);
            this.rbt_Division.Name = "rbt_Division";
            this.rbt_Division.Size = new System.Drawing.Size(74, 20);
            this.rbt_Division.TabIndex = 3;
            this.rbt_Division.TabStop = true;
            this.rbt_Division.Text = "Division";
            this.rbt_Division.UseVisualStyleBackColor = true;
            this.rbt_Division.CheckedChanged += new System.EventHandler(this.rbt_Division_CheckedChanged);
            // 
            // rbt_Multipliacion
            // 
            this.rbt_Multipliacion.AutoSize = true;
            this.rbt_Multipliacion.Location = new System.Drawing.Point(7, 74);
            this.rbt_Multipliacion.Name = "rbt_Multipliacion";
            this.rbt_Multipliacion.Size = new System.Drawing.Size(107, 20);
            this.rbt_Multipliacion.TabIndex = 2;
            this.rbt_Multipliacion.TabStop = true;
            this.rbt_Multipliacion.Text = "Multiplicacion";
            this.rbt_Multipliacion.UseVisualStyleBackColor = true;
            this.rbt_Multipliacion.CheckedChanged += new System.EventHandler(this.rbt_Multipliacion_CheckedChanged);
            // 
            // rbt_Resta
            // 
            this.rbt_Resta.AutoSize = true;
            this.rbt_Resta.Location = new System.Drawing.Point(7, 48);
            this.rbt_Resta.Name = "rbt_Resta";
            this.rbt_Resta.Size = new System.Drawing.Size(62, 20);
            this.rbt_Resta.TabIndex = 1;
            this.rbt_Resta.TabStop = true;
            this.rbt_Resta.Text = "Resta";
            this.rbt_Resta.UseVisualStyleBackColor = true;
            this.rbt_Resta.CheckedChanged += new System.EventHandler(this.rbt_Resta_CheckedChanged);
            // 
            // rbt_Suma
            // 
            this.rbt_Suma.AutoSize = true;
            this.rbt_Suma.Location = new System.Drawing.Point(7, 22);
            this.rbt_Suma.Name = "rbt_Suma";
            this.rbt_Suma.Size = new System.Drawing.Size(61, 20);
            this.rbt_Suma.TabIndex = 0;
            this.rbt_Suma.TabStop = true;
            this.rbt_Suma.Text = "Suma";
            this.rbt_Suma.UseVisualStyleBackColor = true;
            this.rbt_Suma.CheckedChanged += new System.EventHandler(this.rbt_Suma_CheckedChanged);
            // 
            // lbl_Numero1
            // 
            this.lbl_Numero1.AutoSize = true;
            this.lbl_Numero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Numero1.Location = new System.Drawing.Point(30, 19);
            this.lbl_Numero1.Name = "lbl_Numero1";
            this.lbl_Numero1.Size = new System.Drawing.Size(74, 16);
            this.lbl_Numero1.TabIndex = 1;
            this.lbl_Numero1.Text = "Numero 1";
            // 
            // lbl_Numero2
            // 
            this.lbl_Numero2.AutoSize = true;
            this.lbl_Numero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Numero2.Location = new System.Drawing.Point(145, 19);
            this.lbl_Numero2.Name = "lbl_Numero2";
            this.lbl_Numero2.Size = new System.Drawing.Size(74, 16);
            this.lbl_Numero2.TabIndex = 2;
            this.lbl_Numero2.Text = "Numero 2";
            // 
            // txt_Num1
            // 
            this.txt_Num1.Location = new System.Drawing.Point(33, 38);
            this.txt_Num1.Name = "txt_Num1";
            this.txt_Num1.Size = new System.Drawing.Size(82, 20);
            this.txt_Num1.TabIndex = 3;
            // 
            // txt_Num2
            // 
            this.txt_Num2.Location = new System.Drawing.Point(148, 39);
            this.txt_Num2.Name = "txt_Num2";
            this.txt_Num2.Size = new System.Drawing.Size(82, 20);
            this.txt_Num2.TabIndex = 4;
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Location = new System.Drawing.Point(119, 226);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(94, 20);
            this.txt_Resultado.TabIndex = 6;
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(35, 226);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(79, 16);
            this.lbl_Resultado.TabIndex = 5;
            this.lbl_Resultado.Text = "Resultado";
            // 
            // frm_Ejercicio4GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 273);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.txt_Num2);
            this.Controls.Add(this.txt_Num1);
            this.Controls.Add(this.lbl_Numero2);
            this.Controls.Add(this.lbl_Numero1);
            this.Controls.Add(this.grb_Operaciones);
            this.Name = "frm_Ejercicio4GUI";
            this.Text = "Operaciones";
            this.grb_Operaciones.ResumeLayout(false);
            this.grb_Operaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Operaciones;
        private System.Windows.Forms.RadioButton rbt_Division;
        private System.Windows.Forms.RadioButton rbt_Multipliacion;
        private System.Windows.Forms.RadioButton rbt_Resta;
        private System.Windows.Forms.RadioButton rbt_Suma;
        private System.Windows.Forms.Label lbl_Numero1;
        private System.Windows.Forms.Label lbl_Numero2;
        private System.Windows.Forms.TextBox txt_Num1;
        private System.Windows.Forms.TextBox txt_Num2;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Label lbl_Resultado;
    }
}