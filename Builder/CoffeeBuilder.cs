using System;
using System.Collections.Generic;
using Builder.Types;

namespace Builder
{
    // Concrete Builder
    class CoffeeBuilder : ICoffeeBuilder
    {
        private CoffeeType _type;
        private CoffeeSize _size;
        private CoffeeSweetness _sweetness;
        private List<CoffeeAddon> _addons;

        public CoffeeBuilder()
        {
            _addons = new List<CoffeeAddon>();
            SetDefaultValues();
        }

        private void SetDefaultValues()
        {
            _type = CoffeeType.Espresso;
            _size = CoffeeSize.Small;
            _sweetness = CoffeeSweetness.OneSpoon;
            _addons.Clear();
        }

        public void AddCinamon()
        {
            _addons.Add(CoffeeAddon.Cinamon);
        }

        public void AddDoubleCoffee()
        {
            _addons.Add(CoffeeAddon.DoubleCoffee);
        }

        public void AddExtraMilk()
        {
            _addons.Add(CoffeeAddon.Milk);
        }

        public void ChooseCappuccino()
        {
            _type = CoffeeType.Cappuccino;
        }

        public void ChooseEspresso()
        {
            _type = CoffeeType.Espresso;
        }

        public void ChooseLatte()
        {
            _type = CoffeeType.Latte;
        }

        public void ChooseSmall()
        {
            _size = CoffeeSize.Small;
        }

        public void ChooseBig()
        {
            _size = CoffeeSize.Big;
        }

        public void PutNoSugar()
        {
            _sweetness = CoffeeSweetness.NoSugar;
        }

        public void PutOneSpoonOfSugar()
        {
            _sweetness = CoffeeSweetness.OneSpoon;
        }

        public void PutTwoSpoonsOfSugar()
        {
            _sweetness = CoffeeSweetness.TwoSpoons;
        }

        public Coffee GetCoffee()
        {
            Coffee coffee = new Coffee
            {
                Type = _type,
                Size = _size,
                Sweetness = _sweetness
            };
            coffee.Addons.AddRange(_addons);

            SetDefaultValues();

            return coffee;
        }

        public void Reset()
        {
            SetDefaultValues();
        }
    }
}
