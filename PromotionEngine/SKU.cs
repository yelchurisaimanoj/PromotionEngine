using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class SKU
    {
        private List<char> items = new List<char>();
        Dictionary<char, double> itemByPrice = new Dictionary<char, double>();

        public SKU(Dictionary<char, double> itemsByPrice)
        {
            this.itemByPrice = itemsByPrice;
        }

        public void AddToSKU(char item)
        {
            items.Add(item);
        }

        public List<char> GetSKU()
        {
            return items;
        }

        public Dictionary<char, double> GetItemByPrice()
        {
            return itemByPrice;
        }
    }

}
