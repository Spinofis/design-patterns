using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Constructional.FabricMethod
{
    class Client
    {

        public Car OrderCar(Country wheelCountry, Country engineCountry)
        {
            WheelCreator wheelCreator = new WheelCreator();
            EngineCreator engineCreator = new EngineCreator();
            Car car = new Car();
            car.engine = engineCreator.GetEngine(engineCountry);
            car.wheel = wheelCreator.GetWheel(wheelCountry);

            return car;
        }
    }
}
