namespace PracticasU2.GUI
{
    partial class frm_Ejercicio19GUI
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
            this.lbl_Multiplos = new System.Windows.Forms.Label();
            this.txt_Multiplos = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Multiplos
            // 
            this.lbl_Multiplos.AutoSize = true;
            this.lbl_Multiplos.Location = new System.Drawing.Point(45, 63);
            this.lbl_Multiplos.Name = "lbl_Multiplos";
            this.lbl_Multiplos.Size = new System.Drawing.Size(48, 13);
            this.lbl_Multiplos.TabIndex = 0;
            this.lbl_Multiplos.Text = "Multiplos";
            // 
            // txt_Multiplos
            // 
            this.txt_Multiplos.Location = new System.Drawing.Point(99, 56);
            this.txt_Multiplos.Name = "txt_Multiplos";
            this.txt_Multiplos.Size = new System.Drawing.Size(131, 20);
            this.txt_Multiplos.TabIndex = 1;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(99, 12);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 2;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // frm_Ejercicio19GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Multiplos);
            this.Controls.Add(this.lbl_Multiplos);
            this.Name = "frm_Ejercicio19GUI";
            this.Text = "Multiplos de 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Multiplos;
        private System.Windows.Forms.TextBox txt_Multiplos;
        private System.Windows.Forms.Button btn_Calcular;
    }
}