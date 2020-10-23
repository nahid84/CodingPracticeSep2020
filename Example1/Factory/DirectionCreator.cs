using CodingPracticeSep2020.Example1.Directions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingPracticeSep2020.Example1.Factory
{
    public class DirectionCreator
    {
        private readonly Dictionary<Options, Func<Direction>> directionRegister;

        public DirectionCreator()
        {
            directionRegister = new Dictionary<Options, Func<Direction>>();
        }

        public Options[] GetRegisteredDirections() => directionRegister.Keys.ToArray();

        public Direction Create(Options direction) => directionRegister[direction]();

        public void RegisterDirection(Options direction, Func<Direction> regDirection)
        {
            if (regDirection == null) return;

            directionRegister.Add(direction, regDirection);
        }

        public void RegisterDirection<T>(Options direction) where T : Direction, new()
        {
            directionRegister.Add(direction, () => new T());
        }
        
        public void RegisterDefaultDirections()
        {
            directionRegister.Add(Options.UP, () => new MoveUp());
            directionRegister.Add(Options.DOWN, () => new MoveDown());
            directionRegister.Add(Options.LEFT, () => new MoveLeft());
            directionRegister.Add(Options.RIGHT, () => new MoveRight());
        }
    }
}
