namespace CodingPracticeSep2020.Example1.Directions
{
    public abstract class Direction
    {
        public Direction(string moveName)
        {
            MoveName = moveName;
        }

        public string MoveName { get; private set; }
    }
}
