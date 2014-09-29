using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryAutomovil.mundo.interfaces;
using AbstractFactoryAutomovil.mundo.clases;

namespace AbstractFactoryAutomovil.mundo.fabricas
{
    class FabricaAudi : IFabricaDePartes
    {

        public IAuto crearAuto()
        {
            return new AutoAudi();
        }

        public IMotor crearMotor()
        {
            return new MotorAudi();
        }

        public ICarroceria crearCarroceria()
        {
            return new CarroceriaAudi();
        }
    }
}
