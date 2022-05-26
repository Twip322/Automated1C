namespace AppNetCore
{
    partial class FormNomenclature
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
            this.dataGridViewNomenclature = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNomenclature)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNomenclature
            // 
            this.dataGridViewNomenclature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNomenclature.Location = new System.Drawing.Point(24, 39);
            this.dataGridViewNomenclature.Name = "dataGridViewNomenclature";
            this.dataGridViewNomenclature.Size = new System.Drawing.Size(585, 382);
            this.dataGridViewNomenclature.TabIndex = 0;
            this.dataGridViewNomenclature.Text = "dataGridView1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormNomenclature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewNomenclature);
            this.Name = "FormNomenclature";
            this.Text = "FormNomenclature";
            this.Load += new System.EventHandler(this.FormNomenclature_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNomenclature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNomenclature;
        private System.Windows.Forms.Button button1;
    }
}