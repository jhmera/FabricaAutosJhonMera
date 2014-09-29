using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryAutomovil.mundo.interfaces;

namespace AbstractFactoryAutomovil.mundo.clases
{
    class MotorAudi :IMotor
    {
        public string darNombre()
        {
            return "Motor Audi";
        }
    }
}
