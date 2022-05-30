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
            this.btnHardLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
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
            // btnHardLoad
            // 
            this.btnHardLoad.Location = new System.Drawing.Point(24, 10);
            this.btnHardLoad.Name = "btnHardLoad";
            this.btnHardLoad.Size = new System.Drawing.Size(121, 23);
            this.btnHardLoad.TabIndex = 1;
            this.btnHardLoad.Text = "Жёсткая Загрузка";
            this.btnHardLoad.UseVisualStyleBackColor = true;
            this.btnHardLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(615, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(615, 80);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(115, 23);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(615, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormNomenclature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 449);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnHardLoad);
            this.Controls.Add(this.dataGridViewNomenclature);
            this.Name = "FormNomenclature";
            this.Text = "FormNomenclature";
            this.Load += new System.EventHandler(this.FormNomenclature_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNomenclature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNomenclature;
        private System.Windows.Forms.Button btnHardLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
    }
}