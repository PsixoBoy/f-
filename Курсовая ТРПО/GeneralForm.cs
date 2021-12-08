using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_ТРПО
{
    public partial class GeneralForm : Form
    {
        public static List<Product> table_of_products = new List<Product>();
        public static List<Product> SortList = new List<Product>();
        

        public GeneralForm()
        {
            InitializeComponent();
            ShowList(table_of_products);
            Product product = new Product(1, "CreditBank", 130, 100, 1000, 1000);
            // product = new Product(2, "BlessBank", 100, 80, 100, 200);
            table_of_products.Add(product);
            product = new Product(2, "BlessBank", 100, 80, 100, 200);
            table_of_products.Add(product);



        }
        
        
        private void Add_button_Click(object sender, EventArgs e)
        {
            Shablon_Add shablon_Add = new Shablon_Add();
            shablon_Add.Show();
        }
        public void ShowList(List<Product> table)
        {
            Table.Rows.Clear();
            if (SortList.Count == 0)
            {
                foreach (Product item in table)
                    Table.Rows.Add(item.code_product, item.bank_name, item.selling_rate, item.purchase_rate, item.selled_cu, item.purchased_cu);
            }
            else
                foreach (Product item in SortList)
                    Table.Rows.Add(item.code_product, item.bank_name, item.selling_rate, item.purchase_rate, item.selled_cu, item.purchased_cu);
        }

        public void Refresh_Click(object sender, EventArgs e)
        {
            ShowList(table_of_products);
        }

        private void GeneralForm_Activated(object sender, EventArgs e)
        {
            ShowList(table_of_products);
            double min = double.MinValue;
            foreach (Product item in table_of_products)
                if (item.selling_rate - item.purchase_rate > min)
                    min = item.selling_rate - item.purchase_rate;

            if (min != double.MaxValue)
                Min_Label.Text = $"Макс. разница курса\nравна: {min}";
            else
                Min_Label.Text = "Макс. разница курса\nравна:";
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            Shablon_Delete shablon_Delete = new Shablon_Delete();
            shablon_Delete.Show();
        }

        private void Results_Click(object sender, EventArgs e)
        {
            double min = double.MinValue;
            foreach (Product item in table_of_products)
                if (item.selling_rate - item.purchase_rate > min)
                    min = item.selling_rate - item.purchase_rate;

            if (min != double.MaxValue)
                Min_Label.Text = $"Макс. разница курса\nравна: {min}";
            else
                Min_Label.Text = "Макс. разница курса\nравна:";

            double sum = 0;
            int kol = 0;
            
                foreach (Product item in table_of_products)
                {

                    kol += item.selled_cu;
                    sum += item.selled_cu * item.selling_rate;

                    Result_label.Text = $"{sum}";
                    label3.Text = $"{kol}";
                }
                Result_label.Text = $"{sum}";
                label3.Text = $"{kol}";
          
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            Edit_Form edit_Form = new Edit_Form();
            edit_Form.Show();
        }

        private void EditPrice_button_Click(object sender, EventArgs e)
        {
            Inscrease inscrease = new Inscrease();
            inscrease.Show();
        }

        private void Table_button_Click(object sender, EventArgs e)
        {
            thenewtable table = new thenewtable();
            table.Show();
        }


        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GeneralForm_Load(object sender, EventArgs e)
        {

        }

        private void Min_Label_Click(object sender, EventArgs e)
        {

        }
    }
}
