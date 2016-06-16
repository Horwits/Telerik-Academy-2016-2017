namespace Collections.Models
{
    using System;
    using System.Text;

    public class Matrix<T>
        where T : struct
    {
        private T[,] data;
        private int rowsCount;
        private int colsCount;

        public Matrix(int rows, int cols)
        {
            this.rowsCount = rows;
            this.colsCount = cols;
            this.data = new T[this.rowsCount, this.colsCount];
        }

        public T this[int row, int col]
        {
            get
            {
                return this.data[row, col];
            }

            set
            {
                this.data[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            var firstDimantionOne = firstMatrix.GetLength(0);
            var firstDimantionTwo = firstMatrix.GetLength(1);

            var secondDimantionOne = secondMatrix.GetLength(0);
            var secondDimantionTwo = secondMatrix.GetLength(1);

            bool areDimantionsEqual = 
                firstDimantionOne == firstDimantionTwo ||
                secondDimantionOne == secondDimantionTwo;

            if (!areDimantionsEqual)
            {
                throw new ArgumentException("Matrices dimantions has to be identical.");
            }

            var resultedMatrix = new Matrix<T>(firstDimantionOne, secondDimantionTwo);

            for (int r = 0; r < firstDimantionOne; r++)
            {
                for (int c = 0; c < firstDimantionTwo; c++)
                {
                    resultedMatrix[r, c] = 
                        (dynamic)firstMatrix[r, c] + (dynamic)secondMatrix[r, c];
                }
            }

            return resultedMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            var firstDimantionOne = firstMatrix.GetLength(0);
            var firstDimantionTwo = firstMatrix.GetLength(1);

            var secondDimantionOne = secondMatrix.GetLength(0);
            var secondDimantionTwo = secondMatrix.GetLength(1);

            bool areDimantionsEqual = 
                firstDimantionOne == secondDimantionOne ||
                firstDimantionTwo == secondDimantionTwo;

            if (!areDimantionsEqual)
            {
                throw new ArgumentException("Matrices dimantions has to be identical.");
            }

            var resultedMatrix = new Matrix<T>(firstDimantionOne, secondDimantionTwo);

            for (int r = 0; r < firstDimantionOne; r++)
            {
                for (int c = 0; c < firstDimantionTwo; c++)
                {
                    T currentMax = firstMatrix[r, c],
                        currentMin = secondMatrix[r, c];

                    if ((dynamic)currentMin > (dynamic)currentMax)
                    {
                        currentMax = secondMatrix[r, c];
                        currentMin = firstMatrix[r, c];
                    }

                    resultedMatrix[r, c] = (dynamic)currentMax - (dynamic)currentMin;
                }
            }

            return resultedMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            var firstDimantionOne = firstMatrix.GetLength(0);
            var firstDimantionTwo = firstMatrix.GetLength(1);

            var secondDimantionOne = secondMatrix.GetLength(0);
            var secondDimantionTwo = secondMatrix.GetLength(1);

            bool areRowsOfFirstEqualToColsOfSecond = 
                firstDimantionOne == secondDimantionTwo;

            if (!areRowsOfFirstEqualToColsOfSecond)
            {
                throw new ArgumentException("Operation cannot be performed.");
            }

            var resultedMatrix = new Matrix<T>(firstDimantionOne, secondDimantionTwo);

            for (int r = 0; r < resultedMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < resultedMatrix.GetLength(1); c++)
                {
                    for (int i = 0; i < firstMatrix.GetLength(1); i++)
                    {
                        resultedMatrix[r, c] += 
                            (dynamic)firstMatrix[r, i] * (dynamic)secondMatrix[i, c];
                    }
                }
            }

            return resultedMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException();
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (Convert.ToInt32(matrix[row, col]) == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException();
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (Convert.ToInt32(matrix[row, col]) == 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public int GetLength(int dimantion)
        {
            var value = 0;

            if (dimantion == 0)
            {
                value = this.rowsCount;
            }
            else if (dimantion == 1)
            {
                value = this.colsCount;
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid dimantion.");
            }

            return value;
        }

        public override string ToString()
        {
            var printInfo = new StringBuilder();
            for (int r = 0; r < this.data.GetLength(0); r++)
            {
                for (int c = 0; c < this.data.GetLength(1); c++)
                {
                    printInfo.Append(this.data[r, c]);

                    if (c < this.data.GetLength(1) - 1)
                    {
                        printInfo.Append(" ");
                    }
                }

                if (r < this.data.GetLength(0) - 1)
                {
                    printInfo.AppendLine();
                }
            }

            return printInfo.ToString();
        }
    }
}
