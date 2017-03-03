namespace PracticasU2.GUI
{
    partial class frm_Ejercicio16GUI
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
            this.clt_Lista1 = new System.Windows.Forms.CheckedListBox();
            this.btn_Move = new System.Windows.Forms.Button();
            this.lst_Lista2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // clt_Lista1
            // 
            this.clt_Lista1.FormattingEnabled = true;
            this.clt_Lista1.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eigth",
            "Nine",
            "Ten"});
            this.clt_Lista1.Location = new System.Drawing.Point(12, 12);
            this.clt_Lista1.Name = "clt_Lista1";
            this.clt_Lista1.Size = new System.Drawing.Size(120, 154);
            this.clt_Lista1.TabIndex = 0;
            // 
            // btn_Move
            // 
            this.btn_Move.Location = new System.Drawing.Point(186, 77);
            this.btn_Move.Name = "btn_Move";
            this.btn_Move.Size = new System.Drawing.Size(75, 23);
            this.btn_Move.TabIndex = 2;
            this.btn_Move.Text = "Move";
            this.btn_Move.UseVisualStyleBackColor = true;
            this.btn_Move.Click += new System.EventHandler(this.btn_Move_Click);
            // 
            // lst_Lista2
            // 
            this.lst_Lista2.FormattingEnabled = true;
            this.lst_Lista2.Location = new System.Drawing.Point(322, 12);
            this.lst_Lista2.Name = "lst_Lista2";
            this.lst_Lista2.Size = new System.Drawing.Size(120, 147);
            this.lst_Lista2.TabIndex = 3;
            // 
            // frm_Ejercicio16GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 261);
            this.Controls.Add(this.lst_Lista2);
            this.Controls.Add(this.btn_Move);
            this.Controls.Add(this.clt_Lista1);
            this.Name = "frm_Ejercicio16GUI";
            this.Text = "List Boxes";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckedListBox clt_Lista1;
        private System.Windows.Forms.Button btn_Move;
        public System.Windows.Forms.ListBox lst_Lista2;
    }
}