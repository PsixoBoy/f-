﻿
namespace Курсовая_ТРПО
{
    partial class Edit_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Code_Box = new System.Windows.Forms.TextBox();
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Selling_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Purchase_Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.scu_Box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Sort_Button = new System.Windows.Forms.Button();
            this.pcu_Box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите код банка который хотите отредактировать, и заполните \r\nполя, которые нуж" +
    "но изменить:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Код банка";
            // 
            // Code_Box
            // 
            this.Code_Box.Location = new System.Drawing.Point(189, 50);
            this.Code_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Code_Box.Name = "Code_Box";
            this.Code_Box.Size = new System.Drawing.Size(286, 23);
            this.Code_Box.TabIndex = 2;
            // 
            // Name_Box
            // 
            this.Name_Box.Location = new System.Drawing.Point(189, 76);
            this.Name_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(286, 23);
            this.Name_Box.TabIndex = 4;
            this.Name_Box.TextChanged += new System.EventHandler(this.Name_Box_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Название";
            // 
            // Selling_Box
            // 
            this.Selling_Box.Location = new System.Drawing.Point(189, 100);
            this.Selling_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Selling_Box.Name = "Selling_Box";
            this.Selling_Box.Size = new System.Drawing.Size(286, 23);
            this.Selling_Box.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Курс продажи";
            // 
            // Purchase_Box
            // 
            this.Purchase_Box.Location = new System.Drawing.Point(189, 125);
            this.Purchase_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Purchase_Box.Name = "Purchase_Box";
            this.Purchase_Box.Size = new System.Drawing.Size(286, 23);
            this.Purchase_Box.TabIndex = 8;
            this.Purchase_Box.TextChanged += new System.EventHandler(this.Purchase_Box_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(11, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Курс покупки";
            // 
            // scu_Box
            // 
            this.scu_Box.Location = new System.Drawing.Point(189, 149);
            this.scu_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scu_Box.Name = "scu_Box";
            this.scu_Box.Size = new System.Drawing.Size(286, 23);
            this.scu_Box.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(11, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Проданное кол-во у.е.";
            // 
            // Sort_Button
            // 
            this.Sort_Button.BackColor = System.Drawing.Color.MintCream;
            this.Sort_Button.Location = new System.Drawing.Point(273, 204);
            this.Sort_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sort_Button.Name = "Sort_Button";
            this.Sort_Button.Size = new System.Drawing.Size(122, 26);
            this.Sort_Button.TabIndex = 11;
            this.Sort_Button.Text = "Редактировать";
            this.Sort_Button.UseVisualStyleBackColor = false;
            this.Sort_Button.Click += new System.EventHandler(this.Sort_Button_Click);
            // 
            // pcu_Box
            // 
            this.pcu_Box.Location = new System.Drawing.Point(189, 176);
            this.pcu_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcu_Box.Name = "pcu_Box";
            this.pcu_Box.Size = new System.Drawing.Size(286, 23);
            this.pcu_Box.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Купленное кол-во у.е.";
            // 
            // Edit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(520, 241);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pcu_Box);
            this.Controls.Add(this.Sort_Button);
            this.Controls.Add(this.scu_Box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Purchase_Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Selling_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Name_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Code_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Edit_Form";
            this.Text = "Edit_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Code_Box;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Selling_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Purchase_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox scu_Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Sort_Button;
        private System.Windows.Forms.TextBox pcu_Box;
        private System.Windows.Forms.Label label7;
    }
}