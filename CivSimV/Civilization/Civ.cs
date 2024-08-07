using CivSimV.Cities;
using CivSimV.GameAI;
using CivSimV.Tiles;
using CivSimV.Units;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivSimV.Civilization
{
    public class Civ
    {
        private readonly List<City> cities = new List<City>();
        private readonly List<Unit> units = new List<Unit>();

        public Civ(Nation nation, Game game)
        {
            this.Nation = nation;
            this.Game = game;
        }

        public void AddCity()
        {
            var city = new City();
            cities.Add(city);
        }

        public void RemoveUnit(Unit unit)
        {
            units.Remove(unit);
        }

        public Game Game { get; init; }
        public Nation Nation { get; init; }

        public ReadOnlyCollection<City> Cities => cities.AsReadOnly();
        public ReadOnlyCollection<Unit> Units => units.AsReadOnly();
    }
}
