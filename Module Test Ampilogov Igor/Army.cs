using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Module_Test_Ampilogov_Igor
{
    public class Army
    {
        protected int cost;
        protected int speed;
        protected string name;

        public Army(int Cost, int Speed)
        {
            this.cost = Cost;
            this.speed = Speed; 
        }

        public virtual int Costing() { return cost; }

        public virtual int Speeding() { return speed; }

        public virtual string Show() { return ""; }
    }
}
