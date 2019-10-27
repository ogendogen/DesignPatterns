using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    // Abstract Builder
    interface ICoffeeBuilder
    {
        void ChooseEspresso();
        void ChooseLatte();
        void ChooseCappuccino();

        void ChooseBig();
        void ChooseSmall();

        void PutNoSugar();
        void PutOneSpoonOfSugar();
        void PutTwoSpoonsOfSugar();

        void AddDoubleCoffee();
        void AddCinamon();
        void AddExtraMilk();

        Coffee GetCoffee();
    }
}
