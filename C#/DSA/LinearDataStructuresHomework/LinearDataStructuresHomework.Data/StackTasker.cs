using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearDataStructuresHomework.Data.Contracts;

namespace LinearDataStructuresHomework.Data
{
    public class StackTasker : ITasker, IStackTasker
    {
        private readonly IReadWriteProvider provider;
        private readonly Stack<int> innerStack;
        public StackTasker(IReadWriteProvider provider)
        {
            this.provider = provider;
            this.innerStack = new Stack<int>();
        }

        public int InnerCollectionCount
        {
            get { return this.innerStack.Count; }
        }

        public IEnumerable<int> Reverse()
        {
            var copy = this.Copy();

            var length = copy.Count;

            var reversed = new Stack<int>();

            for (int i = 0; i < length; i++)
            {
                reversed.Push(copy.Pop());
            }

            return reversed;
        }

        public void Fill(uint n)
        {
            var message = "Please enter a number: ";
            for (int i = 0; i < n; i++)
            {
                this.provider.WriteLine(message);
                var currentLineValue = this.provider.ReadLine();

                var givenNumber = 0;
                var isValid = int.TryParse(currentLineValue, out givenNumber);

                this.innerStack.Push(givenNumber);
            }
        }

        private Stack<int> Copy()
        {
            var copy = new Stack<int>();

            foreach (var element in this.innerStack)
            {
                copy.Push(element);
            }

            return copy;
        }
    }
}
