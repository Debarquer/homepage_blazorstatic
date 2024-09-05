using static BlazorApp.Client.Pages.Game;

namespace BlazorApp.Client.Game
{
    public class Tile(char gfx, string color)
    {
        public char GFX { get; private set; } = gfx;
        public string Color { get; private set; } = color;

        public int lifetime = 0;

        virtual public void SetGfx(char gfx)
        {
            this.GFX = gfx;
        }

        virtual public void SetColor(string color)
        {
            this.Color = color;
        }

        virtual public void Update()
        {
            lifetime++;
        }

        virtual public void OnPlayerEnter()
        {
            lifetime = 0;
        }
    }

    public class TreasureTile(char gfx, string color, PlayerInventory playerInventory, OutputConsole outputConsole, Map map, MapPosition playerPosition): Tile(gfx, color)
    {
        public PlayerInventory PlayerInventory { get; private set; } = playerInventory;
        public OutputConsole OutputConsole { get; private set; } = outputConsole;
        public Map Map { get; private set; }
        public MapPosition PlayerPosition { get; private set; } = playerPosition;

        override public void OnPlayerEnter()
        {
            base.OnPlayerEnter();

            OutputConsole.output.Add("You have found a treasure chest containing 10 gold!");
            PlayerInventory.gold += 10;
            //Map.map[(PlayerPosition.row, PlayerPosition.column)].SetGfx('g');
            //Map.map[(PlayerPosition.row, PlayerPosition.column)].SetColor("green");
        }
    }
}
