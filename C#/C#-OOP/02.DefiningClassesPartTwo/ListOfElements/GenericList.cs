namespace ListOfElements
{
    using System;
    using System.Text;

    public class GenericList<T> where T : IComparable<T>
    {
        private int capacity;
        private T[] innerArray;
        private int nextIndex = 0;

        public GenericList(int capacity)
        {
            this.capacity = capacity;
            this.innerArray = new T[this.capacity];
        }

        public T this[int index]
        {
            get
            {
                if (index >= this.capacity || index < 0)
                {
                    throw new IndexOutOfRangeException("Index has to be equal or bigger than zero and less than max capacity.");
                }

                return this.innerArray[index];
            }

            set
            {
                this.innerArray[index] = value;
            }
        }

        public void Add(T element)
        {
            if (this.nextIndex >= this.capacity - 1)
            {
                this.AutoGrow();
            }

            this.innerArray[this.nextIndex] = element;
            this.nextIndex++;
        }

        public void Clear()
        {
            var length = this.innerArray.Length;
            this.innerArray = new T[length];

            // for (int i = 0; i < length; i++)
            // {
            //     this.innerArray[i] = default(T);
            // }

            // Array.Clear(this.innerArray, 0, this.innerArray.Length);
        }

        public int Find(T element)
        {
            for (int i = 0; i < this.innerArray.Length; i++)
            {
                if (element.Equals(this.innerArray[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, T value)
        {
            if (this.nextIndex == this.innerArray.Length)
            {
                this.AutoGrow();
            }

            for (int i = this.nextIndex; i >= index && i > 0; i--)
            {
                this.innerArray[i] = this.innerArray[i - 1];
            }

            this.innerArray[index] = value;
            this.nextIndex++;
        }

        public void RemoveAt(int index)
        {
            var innerLength = this.innerArray.Length;
            if (index >= innerLength || index < 0)
            {
                throw new IndexOutOfRangeException("The value of the given index is not valid.");
            }

            var copyWithoutRemovedValue = new T[innerLength - 1];
            for (int i = 0; i < index; i++)
            {
                copyWithoutRemovedValue[i] = this.innerArray[i];
            }

            for (int i = index + 1; i < innerLength; i++)
            {
                copyWithoutRemovedValue[i - 1] = this.innerArray[i];
            }

            this.innerArray = copyWithoutRemovedValue;
            this.nextIndex--;
        }

        public T Min()
        {
            var min = this.innerArray[0];
            for (int i = 0; i < this.nextIndex; i++)
            {
                if (min.CompareTo(this.innerArray[i]) > 0)
                {
                    min = this.innerArray[i];
                }
            }

            return min;
        }

        public T Max()
        {
            var max = this.innerArray[0];
            for (int i = 0; i < this.nextIndex; i++)
            {
                if (max.CompareTo(this.innerArray[i]) < 0)
                {
                    max = this.innerArray[i];
                }
            }

            return max;
        }

        public override string ToString()
        {
            var printInfo = new StringBuilder();

            for (int i = 0; i < this.nextIndex; i++)
            {
                if (i == this.nextIndex - 1)
                {
                    printInfo.Append(this.innerArray[i]);
                }
                else
                {
                    printInfo.Append(this.innerArray[i]).Append(", ");
                }
            }

            return printInfo.ToString();
        }

        private void AutoGrow()
        {
            var copyOldCapacity = this.capacity;
            this.capacity *= 2;
            var newInnerArray = this.CopyOldInnerArray(this.capacity, copyOldCapacity);

            this.innerArray = newInnerArray;
        }

        private T[] CopyOldInnerArray(int newCapacity, int oldCapacity)
        {
            if (newCapacity < 0)
            {
                throw new IndexOutOfRangeException("Invalid capacity number.");
            }

            var newInnerArray = new T[newCapacity];

            for (int i = 0; i < oldCapacity; i++)
            {
                newInnerArray[i] = this.innerArray[i];
            }

            return newInnerArray;
        }
    }
}
