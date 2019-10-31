using System;
namespace RecieptGenerator
{

    //Constructor for individual items
    //This reduces redundancy when creating multiple objects

    class Item
    {   
        public string name;
        public double price;
        public bool taxExempt;
        public bool import;
        public double itemTaxAdjustedPrice;
        public double itemTaxOnly;
        // menthod that takes in taxExempt, import, and item price to determine
        //tax rate & round to the nearest .05
        public static double taxCalc(bool i, bool e, double p)
        {
            double taxRate = 0.00;
            double total;
            if (i == true)
            {
                taxRate += 0.05;
            }
            if (e == false)
            {
                taxRate += 0.10;
            }
            total = p += (taxRate * p);
            return Math.Round(total * 20) / 20; 
        }

        public Item(string itemName, double itemPrice, bool itemTaxExempt, bool itemImport)
        {
            name = itemName;
            price = itemPrice;
            taxExempt = itemTaxExempt;
            import = itemImport;
            itemTaxAdjustedPrice = taxCalc(import, taxExempt, price);
            itemTaxOnly = itemTaxAdjustedPrice - price;
        }
    }
}
