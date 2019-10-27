using Builder.Types;
using System.Collections.Generic;

namespace Builder
{
    // Product
    public class Coffee
    {
        public CoffeeType Type { get; set; }
        public CoffeeSize Size { get; set; }
        public CoffeeSweetness Sweetness { get; set; }
        public List<CoffeeAddon> Addons { get; set; }

        public Coffee()
        {
            Addons = new List<CoffeeAddon>();
        }

        public override string ToString()
        {
            return $"Type: {Type}\n" +
                $"Size: {Size}\n" +
                $"Sweetness: {Sweetness}\n" +
                $"Addons: { (Addons.Count > 0 ? string.Join(',', Addons.ToArray()) : "No addons") }";
        }
    }
}