using CivSimV.Civilization;
using CivSimV.Decisions;
using CivSimV.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivSimV.GameAI
{
    public class Game : IStrategy
    {

        public Game()
        {

        }

        public Civ AddCivilization(Nation nation)
        {
            var civ = new Civ(nation, this);
            Civilizations.Add(civ);
            return civ;
        }

        public List<Decision> PendingDecisions()
        {
            throw new NotImplementedException();
        }

        public List<Civ> Civilizations { get; } = new List<Civ>();
        public TileMap TileMap { get; set; } = new TileMap();
    }
}
