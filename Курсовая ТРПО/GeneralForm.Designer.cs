
namespace Курсовая_ТРПО
{
    partial class GeneralForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.EditPrice_button = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Result_label = new System.Windows.Forms.Label();
            this.Min_Label = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namebank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sell_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selled_cu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ppurchased_cu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.Button();
            this.Tabel_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.MintCream;
            this.Add_button.Location = new System.Drawing.Point(762, 11);
            this.Add_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(192, 26);
            this.Add_button.TabIndex = 4;
            this.Add_button.Text = "Добавить ";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.MintCream;
            this.Delete_button.Location = new System.Drawing.Point(762, 41);
            this.Delete_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(192, 26);
            this.Delete_button.TabIndex = 5;
            this.Delete_button.Text = "Удалить ";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.BackColor = System.Drawing.Color.MintCream;
            this.Edit_button.Location = new System.Drawing.Point(762, 70);
            this.Edit_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(192, 26);
            this.Edit_button.TabIndex = 7;
            this.Edit_button.Text = "Редактировать ";
            this.Edit_button.UseVisualStyleBackColor = false;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // EditPrice_button
            // 
            this.EditPrice_button.BackColor = System.Drawing.Color.MintCream;
            this.EditPrice_button.Location = new System.Drawing.Point(762, 100);
            this.EditPrice_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditPrice_button.Name = "EditPrice_button";
            this.EditPrice_button.Size = new System.Drawing.Size(192, 26);
            this.EditPrice_button.TabIndex = 8;
            this.EditPrice_button.Text = "Изменть курс покупки";
            this.EditPrice_button.UseVisualStyleBackColor = false;
            this.EditPrice_button.Click += new System.EventHandler(this.EditPrice_button_Click);
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.MintCream;
            this.Refresh.Location = new System.Drawing.Point(762, 255);
            this.Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(192, 26);
            this.Refresh.TabIndex = 9;
            this.Refresh.Text = "Обновить данные таблицы";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(762, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Общая сумма продажи\r\nвсех банков:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Result_label
            // 
            this.Result_label.AutoSize = true;
            this.Result_label.Location = new System.Drawing.Point(857, 175);
            this.Result_label.Name = "Result_label";
            this.Result_label.Size = new System.Drawing.Size(0, 15);
            this.Result_label.TabIndex = 14;
            // 
            // Min_Label
            // 
            this.Min_Label.AutoSize = true;
            this.Min_Label.Location = new System.Drawing.Point(762, 220);
            this.Min_Label.Name = "Min_Label";
            this.Min_Label.Size = new System.Drawing.Size(141, 30);
            this.Min_Label.TabIndex = 15;
            this.Min_Label.Text = "Максимальная разница \r\nкурса:";
            this.Min_Label.Click += new System.EventHandler(this.Min_Label_Click);
            // 
            // Code
            // 
            this.Code.HeaderText = "Код банка";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Code.Width = 125;
            // 
            // Namebank
            // 
            this.Namebank.HeaderText = "Название";
            this.Namebank.MinimumWidth = 6;
            this.Namebank.Name = "Namebank";
            this.Namebank.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Namebank.Width = 125;
            // 
            // Sell_rate
            // 
            this.Sell_rate.HeaderText = "Курс продажи";
            this.Sell_rate.MinimumWidth = 6;
            this.Sell_rate.Name = "Sell_rate";
            this.Sell_rate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sell_rate.Width = 125;
            // 
            // Purchase_rate
            // 
            this.Purchase_rate.HeaderText = "Курс покупки";
            this.Purchase_rate.MinimumWidth = 6;
            this.Purchase_rate.Name = "Purchase_rate";
            this.Purchase_rate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Purchase_rate.Width = 125;
            // 
            // Selled_cu
            // 
            this.Selled_cu.HeaderText = "Кол-во проданных у.е.";
            this.Selled_cu.Name = "Selled_cu";
            this.Selled_cu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Ppurchased_cu
            // 
            this.Ppurchased_cu.HeaderText = "Кол-во купленных у.е.";
            this.Ppurchased_cu.MinimumWidth = 6;
            this.Ppurchased_cu.Name = "Ppurchased_cu";
            this.Ppurchased_cu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ppurchased_cu.Width = 125;
            // 
            // Table
            // 
            this.Table.BackgroundColor = System.Drawing.Color.MintCream;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Namebank,
            this.Sell_rate,
            this.Purchase_rate,
            this.Selled_cu,
            this.Ppurchased_cu});
            this.Table.Location = new System.Drawing.Point(12, 9);
            this.Table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 51;
            this.Table.Size = new System.Drawing.Size(744, 312);
            this.Table.TabIndex = 0;
            this.Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(762, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "Суммарное количество \r\nпроданных у.е.:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(869, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 14;
            // 
            // Results
            // 
            this.Results.BackColor = System.Drawing.Color.MintCream;
            this.Results.Location = new System.Drawing.Point(762, 130);
            this.Results.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(192, 26);
            this.Results.TabIndex = 8;
            this.Results.Text = "Определить параметры";
            this.Results.UseVisualStyleBackColor = false;
            this.Results.Click += new System.EventHandler(this.Results_Click);
            // 
            // Tabel_Button
            // 
            this.Tabel_Button.BackColor = System.Drawing.Color.MintCream;
            this.Tabel_Button.Location = new System.Drawing.Point(762, 285);
            this.Tabel_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tabel_Button.Name = "Tabel_Button";
            this.Tabel_Button.Size = new System.Drawing.Size(192, 26);
            this.Tabel_Button.TabIndex = 8;
            this.Tabel_Button.Text = "Создать таблицу";
            this.Tabel_Button.UseVisualStyleBackColor = false;
            this.Tabel_Button.Click += new System.EventHandler(this.Table_button_Click);
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(965, 329);
            this.Controls.Add(this.Tabel_Button);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Min_Label);
            this.Controls.Add(this.Result_label);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.EditPrice_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GeneralForm";
            this.Text = "Экспорт товаров";
            this.Activated += new System.EventHandler(this.GeneralForm_Activated);
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button EditPrice_button;
        private new System.Windows.Forms.Button Refresh;
        public System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Result_label;
        private System.Windows.Forms.Label Min_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namebank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sell_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selled_cu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ppurchased_cu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Results;
        private System.Windows.Forms.Button Tabel_Button;
    }
}

