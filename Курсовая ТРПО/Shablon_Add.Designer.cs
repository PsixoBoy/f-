
namespace Курсовая_ТРПО
{
    partial class Shablon_Add
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
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Selling_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Purchase_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.scu_Box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pcu_Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование банка";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Name_Box
            // 
            this.Name_Box.Location = new System.Drawing.Point(240, 9);
            this.Name_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(379, 23);
            this.Name_Box.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(116, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Курс продажи";
            // 
            // Selling_Box
            // 
            this.Selling_Box.Location = new System.Drawing.Point(240, 33);
            this.Selling_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Selling_Box.Name = "Selling_Box";
            this.Selling_Box.Size = new System.Drawing.Size(379, 23);
            this.Selling_Box.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(120, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Курс покупки";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Purchase_Box
            // 
            this.Purchase_Box.Location = new System.Drawing.Point(240, 57);
            this.Purchase_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Purchase_Box.Name = "Purchase_Box";
            this.Purchase_Box.Size = new System.Drawing.Size(379, 23);
            this.Purchase_Box.TabIndex = 5;
            this.Purchase_Box.TextChanged += new System.EventHandler(this.Purchase_Box_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(66, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Кол-во купленных у.е.";
            // 
            // scu_Box
            // 
            this.scu_Box.Location = new System.Drawing.Point(240, 81);
            this.scu_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scu_Box.Name = "scu_Box";
            this.scu_Box.Size = new System.Drawing.Size(379, 23);
            this.scu_Box.TabIndex = 7;
            this.scu_Box.TextChanged += new System.EventHandler(this.Price_Box_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.Location = new System.Drawing.Point(383, 147);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pcu_Box
            // 
            this.pcu_Box.Location = new System.Drawing.Point(240, 105);
            this.pcu_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcu_Box.Name = "pcu_Box";
            this.pcu_Box.Size = new System.Drawing.Size(379, 23);
            this.pcu_Box.TabIndex = 7;
            this.pcu_Box.TextChanged += new System.EventHandler(this.Price_Box_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(63, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Кол-во проданных у.е.";
            // 
            // Shablon_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(652, 172);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pcu_Box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scu_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Purchase_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Selling_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name_Box);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(672, 215);
            this.MinimumSize = new System.Drawing.Size(672, 215);
            this.Name = "Shablon_Add";
            this.Text = "Добавление запси в таблицу";
            this.Load += new System.EventHandler(this.Shablon_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Selling_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Purchase_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox scu_Box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pcu_Box;
        private System.Windows.Forms.Label label5;
    }
}