
namespace AppNetCore
{
    partial class FormOperations
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDoAll = new System.Windows.Forms.Button();
            this.btnDoNom = new System.Windows.Forms.Button();
            this.btnDoNeeds = new System.Windows.Forms.Button();
            this.btnDoTrades = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(362, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnDoAll
            // 
            this.btnDoAll.Location = new System.Drawing.Point(400, 27);
            this.btnDoAll.Name = "btnDoAll";
            this.btnDoAll.Size = new System.Drawing.Size(215, 23);
            this.btnDoAll.TabIndex = 1;
            this.btnDoAll.Text = "Провести Все";
            this.btnDoAll.UseVisualStyleBackColor = true;
            this.btnDoAll.Click += new System.EventHandler(this.btnDoAll_Click);
            // 
            // btnDoNom
            // 
            this.btnDoNom.Location = new System.Drawing.Point(400, 56);
            this.btnDoNom.Name = "btnDoNom";
            this.btnDoNom.Size = new System.Drawing.Size(215, 23);
            this.btnDoNom.TabIndex = 2;
            this.btnDoNom.Text = "Провести Номенклатуру";
            this.btnDoNom.UseVisualStyleBackColor = true;
            this.btnDoNom.Click += new System.EventHandler(this.btnDoNom_Click);
            // 
            // btnDoNeeds
            // 
            this.btnDoNeeds.Location = new System.Drawing.Point(400, 85);
            this.btnDoNeeds.Name = "btnDoNeeds";
            this.btnDoNeeds.Size = new System.Drawing.Size(215, 23);
            this.btnDoNeeds.TabIndex = 3;
            this.btnDoNeeds.Text = "Провести Требование-Накладные";
            this.btnDoNeeds.UseVisualStyleBackColor = true;
            this.btnDoNeeds.Click += new System.EventHandler(this.btnDoNeeds_Click);
            // 
            // btnDoTrades
            // 
            this.btnDoTrades.Location = new System.Drawing.Point(400, 114);
            this.btnDoTrades.Name = "btnDoTrades";
            this.btnDoTrades.Size = new System.Drawing.Size(215, 23);
            this.btnDoTrades.TabIndex = 4;
            this.btnDoTrades.Text = "Провести Отчёты о Торговле";
            this.btnDoTrades.UseVisualStyleBackColor = true;
            this.btnDoTrades.Click += new System.EventHandler(this.btnDoTrades_Click);
            // 
            // FormOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 352);
            this.Controls.Add(this.btnDoTrades);
            this.Controls.Add(this.btnDoNeeds);
            this.Controls.Add(this.btnDoNom);
            this.Controls.Add(this.btnDoAll);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormOperations";
            this.Text = "Операции";
            this.Load += new System.EventHandler(this.FormOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDoAll;
        private System.Windows.Forms.Button btnDoNom;
        private System.Windows.Forms.Button btnDoNeeds;
        private System.Windows.Forms.Button btnDoTrades;
    }
}