namespace PracticasU2.GUI
{
    partial class frm_Ejercicio3GUI
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
            this.lbl_X = new System.Windows.Forms.Label();
            this.lbl_Y = new System.Windows.Forms.Label();
            this.lbl_Z = new System.Windows.Forms.Label();
            this.txt_X = new System.Windows.Forms.TextBox();
            this.txt_Y = new System.Windows.Forms.TextBox();
            this.txt_Z = new System.Windows.Forms.TextBox();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.Location = new System.Drawing.Point(13, 40);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(14, 13);
            this.lbl_X.TabIndex = 0;
            this.lbl_X.Text = "X";
            // 
            // lbl_Y
            // 
            this.lbl_Y.AutoSize = true;
            this.lbl_Y.Location = new System.Drawing.Point(12, 66);
            this.lbl_Y.Name = "lbl_Y";
            this.lbl_Y.Size = new System.Drawing.Size(14, 13);
            this.lbl_Y.TabIndex = 1;
            this.lbl_Y.Text = "Y";
            // 
            // lbl_Z
            // 
            this.lbl_Z.AutoSize = true;
            this.lbl_Z.Location = new System.Drawing.Point(13, 92);
            this.lbl_Z.Name = "lbl_Z";
            this.lbl_Z.Size = new System.Drawing.Size(14, 13);
            this.lbl_Z.TabIndex = 2;
            this.lbl_Z.Text = "Z";
            // 
            // txt_X
            // 
            this.txt_X.Location = new System.Drawing.Point(33, 37);
            this.txt_X.Name = "txt_X";
            this.txt_X.Size = new System.Drawing.Size(100, 20);
            this.txt_X.TabIndex = 3;
            // 
            // txt_Y
            // 
            this.txt_Y.Location = new System.Drawing.Point(33, 63);
            this.txt_Y.Name = "txt_Y";
            this.txt_Y.Size = new System.Drawing.Size(100, 20);
            this.txt_Y.TabIndex = 4;
            // 
            // txt_Z
            // 
            this.txt_Z.Location = new System.Drawing.Point(33, 89);
            this.txt_Z.Name = "txt_Z";
            this.txt_Z.Size = new System.Drawing.Size(100, 20);
            this.txt_Z.TabIndex = 5;
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Location = new System.Drawing.Point(33, 138);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(100, 20);
            this.txt_Resultado.TabIndex = 6;
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(33, 116);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(55, 13);
            this.lbl_Resultado.TabIndex = 7;
            this.lbl_Resultado.Text = "Resultado";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(162, 135);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 8;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // frm_Ejercicio3GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.txt_Z);
            this.Controls.Add(this.txt_Y);
            this.Controls.Add(this.txt_X);
            this.Controls.Add(this.lbl_Z);
            this.Controls.Add(this.lbl_Y);
            this.Controls.Add(this.lbl_X);
            this.Name = "frm_Ejercicio3GUI";
            this.Text = "frm_Ejercicio3GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_X;
        private System.Windows.Forms.Label lbl_Y;
        private System.Windows.Forms.Label lbl_Z;
        private System.Windows.Forms.TextBox txt_X;
        private System.Windows.Forms.TextBox txt_Y;
        private System.Windows.Forms.TextBox txt_Z;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Button btn_Calcular;
    }
}