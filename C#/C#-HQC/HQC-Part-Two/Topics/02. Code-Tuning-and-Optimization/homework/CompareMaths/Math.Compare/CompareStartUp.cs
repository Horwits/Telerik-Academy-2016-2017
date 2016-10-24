using System;
using System.Diagnostics;
using Math.Compare.Logger;
using Math.Compare.Tests;

namespace Math.Compare
{
    public class CompareStartUp
    {
        public static void Main(string[] args)
        {
            RunIntTest();
            RunLongTest();
            RunFloatTest();
            RunDoubleTest();
            RunDecimalTest();
        }

        public static string MesureTimeOfExecution(Func<dynamic> func)
        {
            var time = new Stopwatch();
            time.Start();
            dynamic result = func.Invoke();
            time.Stop();
            var mesuredTime = time.Elapsed.ToString();

            result = 0; // for Garbage Collector purpouses

            return mesuredTime;
        }

        public static void RunIntTest()
        {
            var intTester = new MathTest(5000000, 10212121);
            var message = string.Empty;

            ConsoleLogger.LogWithOneParameterAndCyanColor("Add int test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => intTester.AddTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Increment int test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => intTester.IncrementTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Subtract int test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => intTester.SubtractTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Divide int test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => intTester.AddTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Multiply int test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => intTester.MultiplyTest());
                ConsoleLogger.LogWithOneParameter(message);
            }
        }

        public static void RunLongTest()
        {
            var longTester = new MathTest(5000000L, 10212121L);

            var message = string.Empty;
            ConsoleLogger.LogWithOneParameterAndCyanColor("Add long test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => longTester.AddTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Increment long test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => longTester.IncrementTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Subtract long test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => longTester.SubtractTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Divide long test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => longTester.AddTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Multiply long test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => longTester.MultiplyTest());
                ConsoleLogger.LogWithOneParameter(message);
            }
        }

        public static void RunFloatTest()
        {
            var floatTester = new MathTest(5000000f, 10212121f);

            var message = string.Empty;
            ConsoleLogger.LogWithOneParameterAndCyanColor("Add float test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => floatTester.AddTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Increment float test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => floatTester.IncrementTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Subtract float test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => floatTester.SubtractTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Divide float test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => floatTester.AddTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Multiply float test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => floatTester.MultiplyTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Square root float test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => floatTester.SqrtTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Log float test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => floatTester.LogTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Sinus float test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => floatTester.SinTest());
                ConsoleLogger.LogWithOneParameter(message);
            }
        }

        public static void RunDoubleTest()
        {
            var doubleTester = new MathTest(5000000d, 10212121d);

            var message = string.Empty;
            ConsoleLogger.LogWithOneParameterAndCyanColor("Add double test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => doubleTester.AddTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Increment double test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => doubleTester.IncrementTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Subtract double test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => doubleTester.SubtractTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Divide double test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => doubleTester.AddTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Multiply double test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => doubleTester.MultiplyTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Square root double test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => doubleTester.SqrtTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Log double test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => doubleTester.LogTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Sinus double test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => doubleTester.SinTest());
                ConsoleLogger.LogWithOneParameter(message);
            }
        }

        public static void RunDecimalTest()
        {
            var decimalTester = new MathTest(5000000M, 10212121M);

            var message = string.Empty;
            ConsoleLogger.LogWithOneParameterAndCyanColor("Add decimal test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => decimalTester.AddTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Increment decimal test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => decimalTester.IncrementTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Subtract decimal test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => decimalTester.SubtractTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Divide decimal test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => decimalTester.AddTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Multiply decimal test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => decimalTester.MultiplyTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Square root decimal test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => decimalTester.SqrtTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Log decimal test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => decimalTester.LogTest());
                ConsoleLogger.LogWithOneParameter(message);
            }

            ConsoleLogger.LogWithOneParameterAndCyanColor("Sinus decimal test");
            for (int i = 0; i < 10; i++)
            {
                message = MesureTimeOfExecution(() => decimalTester.SinTest());
                ConsoleLogger.LogWithOneParameter(message);
            }
        }
    }
}
