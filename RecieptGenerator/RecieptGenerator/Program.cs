using System;

namespace RecieptGenerator
{
    class Program
    {
        

        static void Main(string[] args)
        {
            double basketOneTax;
            double basketOneSubtotal = 0.00;
            double basketOneTotal = 0.00;

            double basketTwoTax = 0.00;
            double basketTwoSubtotal = 0.00;
            double basketTwoTotal = 0.00;

            double basketThreeTax = 0.00;
            double basketThreeSubtotal = 0.00;
            double basketThreeTotal = 0.00;

            //Shopping Basket #1

            Console.WriteLine("========================================================");
            Console.WriteLine("Shopping Basket #1");
            Console.WriteLine("========================================================");
            Item One = new Item("1 book", 12.49, true, false);
            Item Two = new Item("1 music CD", 14.99, false, false);
            Item Three = new Item("1 chocolate bar", 0.85, false, false);

            Console.WriteLine(One.name + "  $" +  One.itemTaxAdjustedPrice);
            Console.WriteLine(Two.name + "  $" + Two.itemTaxAdjustedPrice);
            Console.WriteLine(Three.name + "  $" + Three.itemTaxAdjustedPrice);

            basketOneTax = One.itemTaxOnly + Two.itemTaxOnly + Three.itemTaxOnly;
            basketOneSubtotal = One.price + Two.price + Three.price;
            basketOneTotal = One.itemTaxAdjustedPrice + Two.itemTaxAdjustedPrice + Three.itemTaxAdjustedPrice;

            Console.WriteLine("Total Tax     $" + basketOneTax);
            Console.WriteLine("Subtotal     $" + basketOneSubtotal);
            Console.WriteLine("Total     $" + basketOneTotal);

            Console.WriteLine("========================================================");
            Console.WriteLine("End");
            Console.WriteLine("========================================================");

            Console.WriteLine("========================================================");
            Console.WriteLine("Shopping Basket #2");
            Console.WriteLine("========================================================");

            //Shopping Basket #2
            Item Four = new Item("1 imported box of chocolates", 10.00, false, true);
            Item Five = new Item("1 imported bottle of perfume", 47.50, false, true);

            Console.WriteLine(Four.name + "  $" + Four.itemTaxAdjustedPrice);
            Console.WriteLine(Five.name + "  $" + Five.itemTaxAdjustedPrice);

            basketTwoTax = Four.itemTaxOnly + Five.itemTaxOnly;
            basketTwoSubtotal = Four.price + Five.price;
            basketTwoTotal = Four.itemTaxAdjustedPrice + Five.itemTaxAdjustedPrice;

            Console.WriteLine("Total Tax     $" + basketTwoTax);
            Console.WriteLine("Subtotal     $" + basketTwoSubtotal);
            Console.WriteLine("Total     $" + basketTwoTotal);


            Console.WriteLine("========================================================");
            Console.WriteLine("End");
            Console.WriteLine("========================================================");


            Console.WriteLine("========================================================");
            Console.WriteLine("Shopping Basket #3");
            Console.WriteLine("========================================================");
            //Shopping Basket #3
            Item Six = new Item("1 imported bottle of perfume", 27.99, false, true);
            Item Seven = new Item("1 bottle of perfume", 18.99, false, false);
            Item Eight = new Item("1 packet of headache pills", 9.75, true, false);
            Item Nine = new Item("1 imported box of chocolates", 14.99, false, false);

            Console.WriteLine(Six.name + "  $" + Six.itemTaxAdjustedPrice);
            Console.WriteLine(Seven.name + "  $" + Seven.itemTaxAdjustedPrice);
            Console.WriteLine(Eight.name + "  $" + Eight.itemTaxAdjustedPrice);
            Console.WriteLine(Nine.name + "  $" + Nine.itemTaxAdjustedPrice);

            basketThreeTax = Six.itemTaxOnly + Seven.itemTaxOnly + Eight.itemTaxOnly + Nine.itemTaxOnly;
            basketThreeSubtotal = Six.price + Seven.price + Eight.price + Nine.price;
            basketThreeTotal = Six.itemTaxAdjustedPrice + Seven.itemTaxAdjustedPrice + Eight.itemTaxAdjustedPrice + Nine.itemTaxAdjustedPrice;

            Console.WriteLine("Total Tax     $" + basketThreeTax);
            Console.WriteLine("Subtotal     $" + basketThreeSubtotal);
            Console.WriteLine("Total     $" + basketThreeTotal);

            Console.WriteLine("========================================================");
            Console.WriteLine("End");
            Console.WriteLine("========================================================");

        }
    }
}
