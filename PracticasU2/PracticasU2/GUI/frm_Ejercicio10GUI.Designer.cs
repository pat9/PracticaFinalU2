namespace PracticasU2.GUI
{
    partial class frm_Ejercicio10GUI
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
            this.btn_C = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_C
            // 
            this.btn_C.Location = new System.Drawing.Point(19, 17);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(48, 232);
            this.btn_C.TabIndex = 0;
            this.btn_C.Text = "C\r\n\r\n";
            this.btn_C.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            this.btn_C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_Ejercicio10GUI_KeyPress);
            // 
            // frm_Ejercicio10GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_C);
            this.Name = "frm_Ejercicio10GUI";
            this.Text = "Piano";
            this.Load += new System.EventHandler(this.frm_Ejercicio10GUI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Ejercicio10GUI_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_Ejercicio10GUI_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_C;
    }
}