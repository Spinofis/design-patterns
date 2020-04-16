using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Constructional.FabricMethod
{
    class EngineCreator
    {

        public Engine GetEngine(Country country)
        {
            switch (country)
            {
                case Country.Chainese:
                    return new ChaineseFactory().CreateEngine();

                case Country.Polish:
                    return new PolishFactory().CreateEngine();

                default:
                    return null;
            }
        }
    }
}
