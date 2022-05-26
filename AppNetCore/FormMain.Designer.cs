namespace AppNetCore
{
    partial class FormMain
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
            this.btnNom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNom
            // 
            this.btnNom.Location = new System.Drawing.Point(68, 26);
            this.btnNom.Name = "btnNom";
            this.btnNom.Size = new System.Drawing.Size(253, 23);
            this.btnNom.TabIndex = 0;
            this.btnNom.Text = "Номенклатура";
            this.btnNom.UseVisualStyleBackColor = true;
            this.btnNom.Click += new System.EventHandler(this.btnNom_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 228);
            this.Controls.Add(this.btnNom);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNom;
    }
}