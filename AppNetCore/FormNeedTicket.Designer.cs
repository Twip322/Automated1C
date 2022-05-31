
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNeedTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(477, 84);
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
            this.dataGridViewNeedTicket.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewNeedTicket.Name = "dataGridViewNeedTicket";
            this.dataGridViewNeedTicket.RowTemplate.Height = 25;
            this.dataGridViewNeedTicket.Size = new System.Drawing.Size(355, 224);
            this.dataGridViewNeedTicket.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(477, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(12, 255);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(121, 23);
            this.btnDo.TabIndex = 5;
            this.btnDo.Text = "Провести";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(477, 154);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Количество";
            // 
            // FormNeedTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 306);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}