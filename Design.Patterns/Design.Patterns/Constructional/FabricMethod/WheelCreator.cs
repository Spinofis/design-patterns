using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Constructional.FabricMethod
{
    class WheelCreator
    {
        public Wheel GetWheel(Country country)
        {
            switch (country)
            {
                case Country.Chainese:
                    return new ChaineseFactory().CreateWheel();

                case Country.Polish:
                    return new PolishFactory().CreateWheel();

                default:
                    return null;
            }
        }
    }
}
