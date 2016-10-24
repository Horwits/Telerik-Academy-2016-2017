namespace Math.Compare.Tests
{
    public class MathTest
    {
        public MathTest(dynamic valueOne , dynamic valueTwo)
        {
            this.ValueOne = valueOne;
            this.ValueTwo = valueTwo;
        }

        public dynamic ValueOne { get; set; }

        public dynamic ValueTwo { get; set; }

        public dynamic AddTest()
        {
            return this.ValueOne + this.ValueTwo;
        }

        public dynamic SubtractTest()
        {
            return this.ValueOne - this.ValueTwo;
        }

        public dynamic IncrementTest()
        {
            return this.ValueOne++;
        }

        public dynamic MultiplyTest()
        {
            return this.ValueOne * this.ValueTwo;
        }

        public dynamic DivideTest()
        {
            return this.ValueOne / this.ValueTwo;
        }

        public dynamic SqrtTest()
        {
            var result = System.Math.Sqrt((double)this.ValueOne);
            return result;
        }

        public dynamic LogTest()
        {
            return System.Math.Log((double)this.ValueOne);
        }

        public dynamic SinTest()
        {
            return System.Math.Sin((double)this.ValueOne);
        }
    }
}