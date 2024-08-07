using CivSimV.Civilization;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivSimV.Units
{
    public class Settler : Unit
    {
        public Settler(Civ civ) : base(civ)
        {
        }

        public void Settle()
        {
            Civilization.AddCity();
            Civilization.RemoveUnit(this);
        }
    }
}
