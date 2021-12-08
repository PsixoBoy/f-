
namespace Курсовая_ТРПО
{
    partial class Inscrease
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
            this.Code_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Price_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Price_Box = new System.Windows.Forms.TextBox();
            this.Sort_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите код банка, которому нужно увеличить цену:";
            // 
            // Code_Box
            // 
            this.Code_Box.Location = new System.Drawing.Point(365, 10);
            this.Code_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Code_Box.Name = "Code_Box";
            this.Code_Box.Size = new System.Drawing.Size(133, 23);
            this.Code_Box.TabIndex = 1;
            this.Code_Box.TextChanged += new System.EventHandler(this.Changes);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цена курса на данный момент:";
            // 
            // Price_Label
            // 
            this.Price_Label.AutoSize = true;
            this.Price_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Price_Label.ForeColor = System.Drawing.Color.LightCyan;
            this.Price_Label.Location = new System.Drawing.Point(225, 40);
            this.Price_Label.Name = "Price_Label";
            this.Price_Label.Size = new System.Drawing.Size(0, 19);
            this.Price_Label.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Поменять курс на:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Price_Box
            // 
            this.Price_Box.Location = new System.Drawing.Point(144, 75);
            this.Price_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Price_Box.Name = "Price_Box";
            this.Price_Box.Size = new System.Drawing.Size(87, 23);
            this.Price_Box.TabIndex = 5;
            this.Price_Box.TextChanged += new System.EventHandler(this.Price_Box_TextChanged);
            // 
            // Sort_Button
            // 
            this.Sort_Button.BackColor = System.Drawing.Color.MintCream;
            this.Sort_Button.Location = new System.Drawing.Point(210, 116);
            this.Sort_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sort_Button.Name = "Sort_Button";
            this.Sort_Button.Size = new System.Drawing.Size(122, 26);
            this.Sort_Button.TabIndex = 12;
            this.Sort_Button.Text = "Увеличить";
            this.Sort_Button.UseVisualStyleBackColor = false;
            this.Sort_Button.Click += new System.EventHandler(this.Sort_Button_Click);
            // 
            // Inscrease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(505, 142);
            this.Controls.Add(this.Sort_Button);
            this.Controls.Add(this.Price_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Price_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Code_Box);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inscrease";
            this.Text = "Inscrease";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Code_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Price_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Price_Box;
        private System.Windows.Forms.Button Sort_Button;
    }
}