namespace Collections.Models
{
    using System;

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

            bool isNotPerformable = firstDimantionOne != firstDimantionTwo || secondDimantionOne != secondDimantionTwo;
            if (isNotPerformable)
            {
                throw new InvalidOperationException("Operation cannot be performed.");
            }

            var resultedMatrix = new Matrix<T>(firstDimantionOne, secondDimantionTwo);

            // TODO: Implement
            // for (int row = 0; row < firstDimantionOne; row++)
            // {
            //     for (int col = 0; col < firstDimantionTwo; col++)
            //     {
            //         resultedMatrix = firstMatrix[row, col] + secondMatrix[row, col];
            //     }
            // }


            return resultedMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            var firstDimantionOne = firstMatrix.GetLength(0);
            var firstDimantionTwo = firstMatrix.GetLength(1);

            var secondDimantionOne = secondMatrix.GetLength(0);
            var secondDimantionTwo = secondMatrix.GetLength(1);

            bool isNotPerformable = firstDimantionOne != firstDimantionTwo || secondDimantionOne != secondDimantionTwo;
            if (isNotPerformable)
            {
                throw new InvalidOperationException("Operation cannot be performed.");
            }

            var resultedMatrix = new Matrix<T>(firstDimantionOne, secondDimantionTwo);

            // TODO: Implement

            return resultedMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            var firstDimantionOne = firstMatrix.GetLength(0);
            var firstDimantionTwo = firstMatrix.GetLength(1);

            var secondDimantionOne = secondMatrix.GetLength(0);
            var secondDimantionTwo = secondMatrix.GetLength(1);

            bool isNotPerformable = firstDimantionOne != firstDimantionTwo || secondDimantionOne != secondDimantionTwo;
            if (isNotPerformable)
            {
                throw new InvalidOperationException("Operation cannot be performed.");
            }

            var resultedMatrix = new Matrix<T>(firstDimantionOne, secondDimantionTwo);

            // TODO: Implement

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
    }
}
