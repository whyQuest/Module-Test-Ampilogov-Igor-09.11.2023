using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Module_Test_Ampilogov_Igor
{
    public class Infantry : Army
    {
        public Infantry(int Cost, int Speed) : base(Cost, Speed)
        {
            this.cost = Cost;
            this.speed = Speed;
            this.name = "Піхота";
        }

        public override int Costing()
        {
            return cost;
        }

        public override int Speeding()
        {
            return speed;
        }

        public override string Show()
        {
            return "Назва війська: " + name + "; Вартість утримання: " + Costing().ToString() + "; Швидкість: " + Speeding().ToString();
        }

    }
}
