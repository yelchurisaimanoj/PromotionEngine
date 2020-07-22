using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, double> itemsByPrice = new Dictionary<char, double>();
            itemsByPrice.Add('A', 50);
            itemsByPrice.Add('B', 30);
            itemsByPrice.Add('C', 20);
            itemsByPrice.Add('D', 15);
            var sku = new SKU(itemsByPrice);
            //Scenerio-1
            sku.AddToSKU('A');
            sku.AddToSKU('B');
            sku.AddToSKU('C');
            var promo =new PromotionStrategy();
            
            Console.WriteLine("Scenerio - 1 : "+promo.GetOrderValue(sku));
            //reset the basket
            sku.ResetSKU();
            sku.AddToSKU('A');
            sku.AddToSKU('A');
            sku.AddToSKU('A');
            sku.AddToSKU('A');
            sku.AddToSKU('A');
            sku.AddToSKU('B');
            sku.AddToSKU('B');
            sku.AddToSKU('B');
            sku.AddToSKU('B');
            sku.AddToSKU('B');
            sku.AddToSKU('C');
            Console.WriteLine("Scenerio - 2 : " + promo.GetOrderValue(sku));
            //reset the basket
            sku.ResetSKU();

            sku.AddToSKU('A');
            sku.AddToSKU('A');
            sku.AddToSKU('A');
            sku.AddToSKU('B');
            sku.AddToSKU('B');
            sku.AddToSKU('B');
            sku.AddToSKU('B');
            sku.AddToSKU('B');
            sku.AddToSKU('C');
            sku.AddToSKU('D');
            Console.WriteLine("Scenerio - 3 : " + promo.GetOrderValue(sku));

            Console.ReadLine();
        }
    }
}
