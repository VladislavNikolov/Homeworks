namespace MinesweeperGame
{
    public class Ranking
    {
        public Ranking(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public string Name { get; private set; }

        public int Points { get; private set; }       
    }
}
