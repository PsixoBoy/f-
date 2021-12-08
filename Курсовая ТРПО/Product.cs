using System;
using System.Collections.Generic;
using System.Text;

namespace Курсовая_ТРПО
{
    public class Product
    {
        public int code_product; // шифр банка
        public string bank_name; // наименование банка
        public double selling_rate; 
        public double purchase_rate; 
        public int selled_cu;
        public int purchased_cu;
        public double summa;
        public int kolich;

        public Product(int code_product, string bank_name, double selling_rate, double purchase_rate, int selled_cu, int purchased_cu)
        {
            this.code_product = code_product;
            this.bank_name = bank_name;
            this.selling_rate = selling_rate;
            this.purchase_rate = purchase_rate;
            this.selled_cu = selled_cu;
            this.purchased_cu = purchased_cu;
            this.summa = selling_rate * selled_cu;
            this.kolich = selled_cu;
        }
        public Product(int code_product, string bank_name)
        {
              this.code_product = code_product;
              this.bank_name = bank_name;
              this.summa = selling_rate * selled_cu;
              this.kolich = selled_cu;
        }
    }
}
