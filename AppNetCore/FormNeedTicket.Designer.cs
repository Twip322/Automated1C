
namespace AppNetCore
{
    partial class FormNeedTicket
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
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.comboBoxNomenclature = new System.Windows.Forms.ComboBox();
            this.dataGridViewNeedTicket = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNeedTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(477, 66);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(121, 23);
            this.textBoxCount.TabIndex = 1;
            // 
            // comboBoxNomenclature
            // 
            this.comboBoxNomenclature.FormattingEnabled = true;
            this.comboBoxNomenclature.Location = new System.Drawing.Point(477, 28);
            this.comboBoxNomenclature.Name = "comboBoxNomenclature";
            this.comboBoxNomenclature.Size = new System.Drawing.Size(121, 23);
            this.comboBoxNomenclature.TabIndex = 2;
            // 
            // dataGridViewNeedTicket
            // 
            this.dataGridViewNeedTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNeedTicket.Location = new System.Drawing.Point(12, 28);
            this.dataGridViewNeedTicket.Name = "dataGridViewNeedTicket";
            this.dataGridViewNeedTicket.RowTemplate.Height = 25;
            this.dataGridViewNeedTicket.Size = new System.Drawing.Size(355, 224);
            this.dataGridViewNeedTicket.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(477, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(12, 271);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(121, 23);
            this.btnDo.TabIndex = 5;
            this.btnDo.Text = "Провести";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // FormNeedTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 306);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewNeedTicket);
            this.Controls.Add(this.comboBoxNomenclature);
            this.Controls.Add(this.textBoxCount);
            this.Name = "FormNeedTicket";
            this.Text = "Накладная-требование";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNeedTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.ComboBox comboBoxNomenclature;
        private System.Windows.Forms.DataGridView dataGridViewNeedTicket;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDo;
    }
}