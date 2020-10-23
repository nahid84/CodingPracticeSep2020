using CodingPracticeSep2020.Example2.Exceptions;
using System;

namespace CodingPracticeSep2020.Example2
{
    class RunExample2
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = PrepareIntStack();

            Console.WriteLine($"Pop = { intStack.Pop() }");
            Console.WriteLine($"Pop = { intStack.Pop() }");
            Console.WriteLine($"Peek = { intStack.Peek() }");
            Console.WriteLine($"Pop = { intStack.Pop() }");

            intStack = PrepareIntStack();
            StackOverflow(intStack);

            intStack = PrepareIntStack();
            StackUnderflow(intStack);

            intStack = PrepareIntStack();
            StackUnderflowWhileEmpty(intStack);
        }

        static Stack<int> PrepareIntStack()
        {
            Stack<int> intStack = new Stack<int>(3);

            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);

            return intStack;
        }

        static void StackOverflow(Stack<int> intStack)
        {
            try
            {
                intStack.Push(4);
            } 
            catch(ExceededSizeException)
            {
                Console.WriteLine("Overflow exception occured...");
            }
        }

        static void StackUnderflow(Stack<int> intStack)
        {
            try
            {
                intStack.Pop();
                intStack.Pop();
                intStack.Pop();
                intStack.Pop();
            }
            catch (ExpenditureProhibitedException)
            {
                Console.WriteLine("Underflow exception occured...");
            }
        }

        static void StackUnderflowWhileEmpty(Stack<int> intStack)
        {
            try
            {
                intStack.Pop();
                intStack.Pop();
                intStack.Pop();

                intStack.Peek();
            }
            catch (ExpenditureProhibitedException)
            {
                Console.WriteLine("Underflow exception occured while peeking from empty stack...");
            }
        }
    }
}
