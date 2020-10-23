using CodingPracticeSep2020.Example1.Directions;
using CodingPracticeSep2020.Example1.Factory;
using System;

namespace CodingPracticeSep2020.Example1
{
    class RunExample1
    {
        static void Main(string[] args)
        {
            DirectionCreator creator = PrepareDirections();

            foreach (Options option in creator.GetRegisteredDirections())
            {
                Console.WriteLine(creator.Create(option).MoveName);
            }
        }

        static DirectionCreator PrepareDirections()
        {
            DirectionCreator dCreator = new DirectionCreator();

            dCreator.RegisterDefaultDirections();

            // Register another direction here
            dCreator.RegisterDirection<MoveCombo>(Options.COMBO);

            return dCreator;
        }
    }
}
