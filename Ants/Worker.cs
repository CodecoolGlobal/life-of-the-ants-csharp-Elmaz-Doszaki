using Movement;

namespace Ants
{
    public class Worker : Ant
    {
        public Worker(Position position, int width) : base(position, width)
        {

        }

        public override void Act()
        {
            var direction = GetRandomDirection();
            NextMove(direction);
        }
    }
}

