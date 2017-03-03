namespace PracticasU2.GUI
{
    partial class frm_Ejercicio12GUI
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
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.btn_Transformar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(12, 39);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(49, 13);
            this.lbl_Cantidad.TabIndex = 0;
            this.lbl_Cantidad.Text = "Cantidad";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(67, 36);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_Cantidad.TabIndex = 1;
            // 
            // btn_Transformar
            // 
            this.btn_Transformar.Location = new System.Drawing.Point(55, 77);
            this.btn_Transformar.Name = "btn_Transformar";
            this.btn_Transformar.Size = new System.Drawing.Size(75, 23);
            this.btn_Transformar.TabIndex = 2;
            this.btn_Transformar.Text = "Transformar";
            this.btn_Transformar.UseVisualStyleBackColor = true;
            this.btn_Transformar.Click += new System.EventHandler(this.btn_Transformar_Click);
            // 
            // frm_Ejercicio12GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 203);
            this.Controls.Add(this.btn_Transformar);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.lbl_Cantidad);
            this.Name = "frm_Ejercicio12GUI";
            this.Text = "Transformar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Button btn_Transformar;
    }
}