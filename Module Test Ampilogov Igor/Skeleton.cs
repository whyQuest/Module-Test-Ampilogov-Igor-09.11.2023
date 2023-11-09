using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Test_Ampilogov_Igor
{
    public class Skeleton : Army
    {
        public Skeleton(int Cost, int Speed) : base(Cost, Speed)
        {
            this.cost = Cost;
            this.speed = Speed;
            this.name = "Скелет";
        }

        public override int Costing()
        {
            int Human_Soul = 1;
            int Meat = 5;

            cost = Human_Soul + Meat;

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
