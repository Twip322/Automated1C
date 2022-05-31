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
            this.btnLoads = new System.Windows.Forms.Button();
            this.btnNeedTicket = new System.Windows.Forms.Button();
            this.btnTrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNom
            // 
            this.btnNom.Location = new System.Drawing.Point(68, 48);
            this.btnNom.Name = "btnNom";
            this.btnNom.Size = new System.Drawing.Size(253, 23);
            this.btnNom.TabIndex = 0;
            this.btnNom.Text = "Номенклатура";
            this.btnNom.UseVisualStyleBackColor = true;
            this.btnNom.Click += new System.EventHandler(this.btnNom_Click);
            // 
            // btnLoads
            // 
            this.btnLoads.Location = new System.Drawing.Point(68, 193);
            this.btnLoads.Name = "btnLoads";
            this.btnLoads.Size = new System.Drawing.Size(253, 23);
            this.btnLoads.TabIndex = 1;
            this.btnLoads.Text = "Операции и загрузки";
            this.btnLoads.UseVisualStyleBackColor = true;
            this.btnLoads.Click += new System.EventHandler(this.btnDoAll_Click);
            // 
            // btnNeedTicket
            // 
            this.btnNeedTicket.Location = new System.Drawing.Point(68, 77);
            this.btnNeedTicket.Name = "btnNeedTicket";
            this.btnNeedTicket.Size = new System.Drawing.Size(253, 23);
            this.btnNeedTicket.TabIndex = 2;
            this.btnNeedTicket.Text = "Накладная-требование";
            this.btnNeedTicket.UseVisualStyleBackColor = true;
            this.btnNeedTicket.Click += new System.EventHandler(this.btnNeedTicket_Click);
            // 
            // btnTrade
            // 
            this.btnTrade.Location = new System.Drawing.Point(68, 106);
            this.btnTrade.Name = "btnTrade";
            this.btnTrade.Size = new System.Drawing.Size(253, 23);
            this.btnTrade.TabIndex = 3;
            this.btnTrade.Text = "Отчеты О Розничных Продажах";
            this.btnTrade.UseVisualStyleBackColor = true;
            this.btnTrade.Click += new System.EventHandler(this.btnTrade_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 228);
            this.Controls.Add(this.btnTrade);
            this.Controls.Add(this.btnNeedTicket);
            this.Controls.Add(this.btnLoads);
            this.Controls.Add(this.btnNom);
            this.Name = "FormMain";
            this.Text = "Главная";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNom;
        private System.Windows.Forms.Button btnLoads;
        private System.Windows.Forms.Button btnNeedTicket;
        private System.Windows.Forms.Button btnTrade;
    }
}