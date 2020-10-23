using CodingPracticeSep2020.Example2.Exceptions;

namespace CodingPracticeSep2020.Example2
{
    public class Stack<T>
    {
        private T[] stackArray;
        private int maximumLength;
        public int Size { get; private set; }
        public Stack(int maximumLength)
        {
            Size = -1;
            this.maximumLength = maximumLength;
            stackArray = new T[maximumLength];
        }
        public void Push(T value)
        {
            if (++Size >= maximumLength)
                throw new ExceededSizeException();

            stackArray[Size] = value;
        }

        public T Pop()
        {
            if (Size < 0)
                throw new ExpenditureProhibitedException();

            return stackArray[Size--];
        }

        public T Peek()
        {
            if (Size < 0)
                throw new ExpenditureProhibitedException();

            return stackArray[Size];
        }
    }

}
