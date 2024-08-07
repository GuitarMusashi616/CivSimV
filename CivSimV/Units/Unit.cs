using CivSimV.Civilization;
using CivSimV.Decisions;
using CivSimV.GameAI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivSimV.Units
{
    public class Unit
    {
        public Civ Civilization { get; init; }

        public List<UnitAction> actionQueue = new List<UnitAction>();
        public ReadOnlyCollection<UnitAction> ActionQueue => actionQueue.AsReadOnly();

        public Unit(Civ civ)
        {
            Civilization = civ;
        }

        public Decision? QueryDecision()
        {
            if (actionQueue.Count == 0)
            {
                return new Decision(DecisionType.SETTLE, this, GetType());
            }
            return null;
        }
    }
}
