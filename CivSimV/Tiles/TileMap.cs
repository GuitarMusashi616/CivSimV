using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivSimV.Tiles
{
    public class TileMap
    {
        public Dictionary<Tuple<int, int>, Tile> tiles = new Dictionary<Tuple<int, int>, Tile>();

        public void AddTile(Tile tile)
        {
            tiles.Add(Tuple.Create(tile.X, tile.Y), tile);
        }

        public Tile? GetTile(int x, int y)
        {
            var tuple = Tuple.Create(x, y);

            if (tiles.ContainsKey(tuple))
            {
                return tiles[tuple];
            }
            return null;
        }
    }
}
