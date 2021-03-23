using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeRay
{
    class Product
    {
        private int quantity;
        private string name;
        private double taxRate;
        private double price;
        private bool isImport;
        private bool isExempt;

        public Product(int quantity, string name, double price, bool isImport, bool isExempt)
        {
            this.quantity = quantity;
            this.name = name;
            this.price = price;
            this.isImport = isImport;
            this.isExempt = isExempt;

            if (isExempt == false)
            {
                this.taxRate += 10;
            } else
                this.taxRate += 0;

            if (isImport == true)
                this.taxRate += 5;
        }

        public int getQuantity()
        {
            return this.quantity;
        }

        public string getName()
        {
            return this.name;
        }

        public double getTaxRate()
        {
            double tax = (this.price * this.taxRate) / 100;
            return Math.Ceiling(tax * 20) / 20;
        }

        public double getPrice()
        {
            return this.price;
        }

        public bool getIsImport()
        {
            return this.isImport;
        }

        public bool getIsExempt()
        {
            return this.isExempt;
        }
    }
}
