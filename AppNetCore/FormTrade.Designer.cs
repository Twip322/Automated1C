
namespace AppNetCore
{
    partial class FormTrade
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewNeedTicket = new System.Windows.Forms.DataGridView();
            this.comboBoxNomenclature = new System.Windows.Forms.ComboBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNeedTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(489, 197);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(24, 255);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(121, 23);
            this.btnDo.TabIndex = 11;
            this.btnDo.Text = "Записать";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(489, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewNeedTicket
            // 
            this.dataGridViewNeedTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNeedTicket.Location = new System.Drawing.Point(24, 12);
            this.dataGridViewNeedTicket.Name = "dataGridViewNeedTicket";
            this.dataGridViewNeedTicket.RowTemplate.Height = 25;
            this.dataGridViewNeedTicket.Size = new System.Drawing.Size(438, 237);
            this.dataGridViewNeedTicket.TabIndex = 9;
            // 
            // comboBoxNomenclature
            // 
            this.comboBoxNomenclature.FormattingEnabled = true;
            this.comboBoxNomenclature.Location = new System.Drawing.Point(489, 33);
            this.comboBoxNomenclature.Name = "comboBoxNomenclature";
            this.comboBoxNomenclature.Size = new System.Drawing.Size(121, 23);
            this.comboBoxNomenclature.TabIndex = 8;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(489, 77);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(121, 23);
            this.textBoxCount.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(489, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 23);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Цена";
            // 
            // FormTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 296);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewNeedTicket);
            this.Controls.Add(this.comboBoxNomenclature);
            this.Controls.Add(this.textBoxCount);
            this.Name = "FormTrade";
            this.Text = "Отчёт о Продаже";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNeedTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewNeedTicket;
        private System.Windows.Forms.ComboBox comboBoxNomenclature;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}