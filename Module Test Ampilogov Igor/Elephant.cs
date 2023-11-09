using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Module_Test_Ampilogov_Igor
{
    public class Elephant : Army
    {

        public Elephant(int Cost, int Speed) : base(Cost, Speed) 
        { 
            this.cost = Cost;
            this.speed = Speed;
            this.name = "Слон";
        }

        public override int Costing()
        {
            int Feed = 4;

            cost = Feed;
            
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
