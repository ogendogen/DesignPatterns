using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    // Director
    public class CoffeeMachine
    {
        private ICoffeeBuilder _coffeeBuilder;

        public CoffeeMachine()
        {
            _coffeeBuilder = new CoffeeBuilder();
        }

        public Coffee GetBigEspressoWithTwoSpoonsAndCinamon()
        {
            _coffeeBuilder.ChooseEspresso();
            _coffeeBuilder.ChooseBig();
            _coffeeBuilder.PutTwoSpoonsOfSugar();
            _coffeeBuilder.AddCinamon();

            return _coffeeBuilder.GetCoffee();
        }

        public Coffee GetSmallLatteWithNoSugarExtraMilkAndDoubleCoffee()
        {
            _coffeeBuilder.ChooseLatte();
            _coffeeBuilder.ChooseSmall();
            _coffeeBuilder.PutNoSugar();
            _coffeeBuilder.AddExtraMilk();
            _coffeeBuilder.AddDoubleCoffee();

            return _coffeeBuilder.GetCoffee();
        }

        public Coffee GetBigCappuccinoWithOneSpoon()
        {
            _coffeeBuilder.ChooseCappuccino();
            _coffeeBuilder.ChooseBig();
            _coffeeBuilder.PutOneSpoonOfSugar();

            return _coffeeBuilder.GetCoffee();
        }
    }
}
