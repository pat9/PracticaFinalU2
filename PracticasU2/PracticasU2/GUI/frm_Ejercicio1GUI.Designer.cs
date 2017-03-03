namespace PracticasU2.GUI
{
    partial class frm_Ejercicio1GUI
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
            this.lbl_SueldoMen = new System.Windows.Forms.Label();
            this.lbl_Incentivo = new System.Windows.Forms.Label();
            this.txt_SueldoMensual = new System.Windows.Forms.TextBox();
            this.txt_Incentivo = new System.Windows.Forms.TextBox();
            this.grb_Bonificacion = new System.Windows.Forms.GroupBox();
            this.rbt_50 = new System.Windows.Forms.RadioButton();
            this.rbt_20 = new System.Windows.Forms.RadioButton();
            this.rbt_10 = new System.Windows.Forms.RadioButton();
            this.lbl_SueldoNeto = new System.Windows.Forms.Label();
            this.txt_SueldoNeto = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_SignoPeso = new System.Windows.Forms.Label();
            this.grb_Bonificacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_SueldoMen
            // 
            this.lbl_SueldoMen.AutoSize = true;
            this.lbl_SueldoMen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SueldoMen.Location = new System.Drawing.Point(26, 30);
            this.lbl_SueldoMen.Name = "lbl_SueldoMen";
            this.lbl_SueldoMen.Size = new System.Drawing.Size(114, 18);
            this.lbl_SueldoMen.TabIndex = 0;
            this.lbl_SueldoMen.Text = "Sueldo Mensual";
            // 
            // lbl_Incentivo
            // 
            this.lbl_Incentivo.AutoSize = true;
            this.lbl_Incentivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Incentivo.Location = new System.Drawing.Point(26, 74);
            this.lbl_Incentivo.Name = "lbl_Incentivo";
            this.lbl_Incentivo.Size = new System.Drawing.Size(66, 18);
            this.lbl_Incentivo.TabIndex = 1;
            this.lbl_Incentivo.Text = "Incentivo";
            // 
            // txt_SueldoMensual
            // 
            this.txt_SueldoMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SueldoMensual.Location = new System.Drawing.Point(29, 51);
            this.txt_SueldoMensual.Name = "txt_SueldoMensual";
            this.txt_SueldoMensual.Size = new System.Drawing.Size(100, 24);
            this.txt_SueldoMensual.TabIndex = 2;
            // 
            // txt_Incentivo
            // 
            this.txt_Incentivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Incentivo.Location = new System.Drawing.Point(29, 95);
            this.txt_Incentivo.Name = "txt_Incentivo";
            this.txt_Incentivo.Size = new System.Drawing.Size(100, 24);
            this.txt_Incentivo.TabIndex = 3;
            // 
            // grb_Bonificacion
            // 
            this.grb_Bonificacion.Controls.Add(this.rbt_50);
            this.grb_Bonificacion.Controls.Add(this.rbt_20);
            this.grb_Bonificacion.Controls.Add(this.rbt_10);
            this.grb_Bonificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Bonificacion.Location = new System.Drawing.Point(147, 30);
            this.grb_Bonificacion.Name = "grb_Bonificacion";
            this.grb_Bonificacion.Size = new System.Drawing.Size(106, 100);
            this.grb_Bonificacion.TabIndex = 4;
            this.grb_Bonificacion.TabStop = false;
            this.grb_Bonificacion.Text = "Bonificacion";
            // 
            // rbt_50
            // 
            this.rbt_50.AutoSize = true;
            this.rbt_50.Location = new System.Drawing.Point(6, 65);
            this.rbt_50.Name = "rbt_50";
            this.rbt_50.Size = new System.Drawing.Size(55, 22);
            this.rbt_50.TabIndex = 2;
            this.rbt_50.TabStop = true;
            this.rbt_50.Text = "50%";
            this.rbt_50.UseVisualStyleBackColor = true;
            // 
            // rbt_20
            // 
            this.rbt_20.AutoSize = true;
            this.rbt_20.Location = new System.Drawing.Point(6, 42);
            this.rbt_20.Name = "rbt_20";
            this.rbt_20.Size = new System.Drawing.Size(55, 22);
            this.rbt_20.TabIndex = 1;
            this.rbt_20.TabStop = true;
            this.rbt_20.Text = "20%";
            this.rbt_20.UseVisualStyleBackColor = true;
            // 
            // rbt_10
            // 
            this.rbt_10.AutoSize = true;
            this.rbt_10.Location = new System.Drawing.Point(7, 19);
            this.rbt_10.Name = "rbt_10";
            this.rbt_10.Size = new System.Drawing.Size(55, 22);
            this.rbt_10.TabIndex = 0;
            this.rbt_10.TabStop = true;
            this.rbt_10.Text = "10%";
            this.rbt_10.UseVisualStyleBackColor = true;
            // 
            // lbl_SueldoNeto
            // 
            this.lbl_SueldoNeto.AutoSize = true;
            this.lbl_SueldoNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SueldoNeto.Location = new System.Drawing.Point(306, 30);
            this.lbl_SueldoNeto.Name = "lbl_SueldoNeto";
            this.lbl_SueldoNeto.Size = new System.Drawing.Size(115, 24);
            this.lbl_SueldoNeto.TabIndex = 5;
            this.lbl_SueldoNeto.Text = "Sueldo Neto";
            // 
            // txt_SueldoNeto
            // 
            this.txt_SueldoNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SueldoNeto.Location = new System.Drawing.Point(310, 58);
            this.txt_SueldoNeto.Name = "txt_SueldoNeto";
            this.txt_SueldoNeto.Size = new System.Drawing.Size(100, 29);
            this.txt_SueldoNeto.TabIndex = 6;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(272, 95);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(138, 25);
            this.btn_Calcular.TabIndex = 7;
            this.btn_Calcular.Text = "Calcular Salario Neto";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lbl_SignoPeso
            // 
            this.lbl_SignoPeso.AutoSize = true;
            this.lbl_SignoPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SignoPeso.Location = new System.Drawing.Point(284, 61);
            this.lbl_SignoPeso.Name = "lbl_SignoPeso";
            this.lbl_SignoPeso.Size = new System.Drawing.Size(20, 24);
            this.lbl_SignoPeso.TabIndex = 8;
            this.lbl_SignoPeso.Text = "$";
            // 
            // frm_Ejercicio1GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 149);
            this.Controls.Add(this.lbl_SignoPeso);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_SueldoNeto);
            this.Controls.Add(this.lbl_SueldoNeto);
            this.Controls.Add(this.grb_Bonificacion);
            this.Controls.Add(this.txt_Incentivo);
            this.Controls.Add(this.txt_SueldoMensual);
            this.Controls.Add(this.lbl_Incentivo);
            this.Controls.Add(this.lbl_SueldoMen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Ejercicio1GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 1";
            this.grb_Bonificacion.ResumeLayout(false);
            this.grb_Bonificacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SueldoMen;
        private System.Windows.Forms.Label lbl_Incentivo;
        private System.Windows.Forms.TextBox txt_SueldoMensual;
        private System.Windows.Forms.TextBox txt_Incentivo;
        private System.Windows.Forms.GroupBox grb_Bonificacion;
        private System.Windows.Forms.RadioButton rbt_50;
        private System.Windows.Forms.RadioButton rbt_20;
        private System.Windows.Forms.RadioButton rbt_10;
        private System.Windows.Forms.Label lbl_SueldoNeto;
        private System.Windows.Forms.TextBox txt_SueldoNeto;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_SignoPeso;
    }
}