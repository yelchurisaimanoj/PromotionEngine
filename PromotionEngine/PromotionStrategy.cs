using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class PromotionStrategy
    {
        Dictionary<char, int> itemsByCount = new Dictionary<char, int>();
        public double GetOrderValue(SKU sku)
        {
            foreach (var item in sku.GetSKU())
            {
                if (itemsByCount.ContainsKey(item))
                    itemsByCount[item]++;
                else
                    itemsByCount.Add(item, 1);
            }

            return GetPrice(sku);
        }

        private double GetPrice(SKU sku)
        {
            var priceListByItem = sku.GetItemByPrice();

            double totalPrice = 0;
            int totalC = 0, totalD = 0;
            foreach (var item in itemsByCount)
            {
                if (item.Key == 'A')
                {
                    var totalA = item.Value;
                    var priceA = priceListByItem['A'];
                    totalPrice += (totalA / 3) * 130 + (totalA % 3) * priceA;
                }
                else if (item.Key == 'B')
                {
                    var totalB = item.Value;
                    var priceB = priceListByItem['B'];
                    totalPrice += (totalB / 2) * 45 + (totalB % 2) * priceB;
                }
                else if (item.Key == 'C')
                {
                    totalC = item.Value;
                }
                else if (item.Key == 'D')
                {
                    totalD = item.Value;
                }
            }

            while (totalC != 0 && totalD != 0)
            {
                totalPrice += 30;
                totalC--;
                totalD--;
            }

            if (totalC != 0)
                totalPrice += totalC * priceListByItem['C'];
            if (totalD != 0)
                totalPrice += totalD * priceListByItem['D'];

            return totalPrice;
        }
    }
}
