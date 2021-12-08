namespace Курсовая_ТРПО
{
    partial class thenewtable
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
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namebank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Newdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Newdata)).BeginInit();
            this.SuspendLayout();
            // 
            // Code
            // 
            this.Code.HeaderText = "Код";
            this.Code.Name = "Code";
            // 
            // Namebank
            // 
            this.Namebank.HeaderText = "Название";
            this.Namebank.Name = "Namebank";
            // 
            // Summ
            // 
            this.Summ.HeaderText = "Сумма продажи";
            this.Summ.Name = "Summ";
            // 
            // Kolvo
            // 
            this.Kolvo.HeaderText = "Кол-во проданных у.е.";
            this.Kolvo.Name = "Kolvo";
            // 
            // thenewtable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(509, 272);
            // 
            // Newdata
            // 
            this.Newdata.BackgroundColor = System.Drawing.Color.MintCream;
            this.Newdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Newdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Namebank,
            this.Summ,
            this.Kolvo});
            this.Newdata.Location = new System.Drawing.Point(26, 22);
            this.Newdata.Name = "Newdata";
            this.Newdata.Size = new System.Drawing.Size(445, 238);
            this.Newdata.TabIndex = 0;
            this.Newdata.Text = "Newdata";
            this.Newdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Newdata_CellContentClick);
            this.Controls.Add(this.Newdata);
            this.Name = "thenewtable";
            this.Text = "thenewtable";
            this.Load += new System.EventHandler(this.thenewtable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Newdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Newdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namebank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolvo;
    }
}