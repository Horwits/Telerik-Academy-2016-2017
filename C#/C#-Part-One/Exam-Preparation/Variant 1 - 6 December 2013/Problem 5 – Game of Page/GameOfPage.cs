using System;
using System.Text;

class GameOfPage
{
    static void Main()
    {
        StringBuilder[] pageTray = new StringBuilder[16];

        for (int i = 0; i < 16; i++)
        {
            pageTray[i] = new StringBuilder();
            pageTray[i].Append(Console.ReadLine());
        }

        decimal bill = 0;
        while (true)
        {
            var command = Console.ReadLine();

            if (command == "paypal")
            {
                Console.WriteLine("{0:f2}", bill);
                break;
            }

            byte currentRow = byte.Parse(Console.ReadLine());
            byte currentCol = byte.Parse(Console.ReadLine());

            bool isWholeCookie =
                currentRow + 1 < 16 &&
                currentRow - 1 >= 0 &&
                currentCol + 1 < 16 &&
                currentCol - 1 >= 0 &&
                (pageTray[currentRow][currentCol] == '1' &&
                pageTray[currentRow][currentCol - 1] == '1' &&
                pageTray[currentRow][currentCol + 1] == '1') &&
                (pageTray[currentRow - 1][currentCol] == '1' &&
                pageTray[currentRow - 1][currentCol - 1] == '1' &&
                pageTray[currentRow - 1][currentCol + 1] == '1') &&
                (pageTray[currentRow + 1][currentCol] == '1' &&
                pageTray[currentRow + 1][currentCol - 1] == '1' &&
                pageTray[currentRow + 1][currentCol + 1] == '1');

            bool isCrumbTopLeft =
                pageTray[currentRow][currentCol] == '1' &&
                ((currentCol - 1 < 0 && currentRow - 1 < 0) &&
                pageTray[currentRow][currentCol + 1] == '0' &&
                pageTray[currentRow + 1][currentCol] == '0' &&
                pageTray[currentRow + 1][currentCol + 1] == '0');

            bool isCrumbTopRight =
                pageTray[currentRow][currentCol] == '1' &&
                ((currentCol + 1 > 15 && currentRow - 1 < 0) &&
                pageTray[currentRow][currentCol - 1] == '0' &&
                pageTray[currentRow + 1][currentCol] == '0' &&
                pageTray[currentRow + 1][currentCol - 1] == '0');

            bool isCrumbBottomLeft =
                pageTray[currentRow][currentCol] == '1' &&
                ((currentCol - 1 < 0 && currentRow + 1 > 15) &&
                pageTray[currentRow][currentCol + 1] == '0' &&
                pageTray[currentRow - 1][currentCol] == '0' &&
                pageTray[currentRow - 1][currentCol + 1] == '0');

            bool isCrumbBottomRight =
                pageTray[currentRow][currentCol] == '1' &&
                ((currentCol + 1 > 15 && currentRow + 1 > 15) &&
                pageTray[currentRow][currentCol - 1] == '0' &&
                pageTray[currentRow - 1][currentCol] == '0' &&
                pageTray[currentRow - 1][currentCol - 1] == '0');

            bool isCrumbWithoutTop =
                pageTray[currentRow][currentCol] == '1' &&
                ((currentCol + 1 < 16 && currentCol - 1 >= 0 && currentRow - 1 < 0)) &&
                ((pageTray[currentRow][currentCol - 1] == '0' &&
                pageTray[currentRow][currentCol + 1] == '0') &&
                (pageTray[currentRow + 1][currentCol] == '0' &&
                pageTray[currentRow + 1][currentCol - 1] == '0' &&
                pageTray[currentRow + 1][currentCol + 1] == '0'));

            bool isCrumbWithoutBottom =
                pageTray[currentRow][currentCol] == '1' &&
                ((currentCol + 1 < 16 && currentCol - 1 >= 0 && currentRow + 1 > 15)) &&
                ((pageTray[currentRow][currentCol - 1] == '0' &&
                pageTray[currentRow][currentCol + 1] == '0') &&
                (pageTray[currentRow - 1][currentCol] == '0' &&
                pageTray[currentRow - 1][currentCol - 1] == '0' &&
                pageTray[currentRow - 1][currentCol + 1] == '0'));

            bool isCrumb =
                currentRow + 1 < 16 &&
                currentRow - 1 >= 0 &&
                currentCol + 1 < 16 &&
                currentCol - 1 >= 0 &&
                (pageTray[currentRow][currentCol] == '1' &&
                pageTray[currentRow][currentCol - 1] == '0' &&
                pageTray[currentRow][currentCol + 1] == '0') &&
                (pageTray[currentRow - 1][currentCol] == '0' &&
                pageTray[currentRow - 1][currentCol - 1] == '0' &&
                pageTray[currentRow - 1][currentCol + 1] == '0') &&
                (pageTray[currentRow + 1][currentCol] == '0' &&
                pageTray[currentRow + 1][currentCol - 1] == '0' &&
                pageTray[currentRow + 1][currentCol + 1] == '0');

            char currentCentralPosition = pageTray[currentRow][currentCol];

            if (command == "what is" && currentCentralPosition == '1')
            {
                if (isWholeCookie)
                {
                    Console.WriteLine("cookie");
                }
                else if (
                    isCrumb ||
                    isCrumbTopLeft ||
                    isCrumbTopRight ||
                    isCrumbBottomLeft ||
                    isCrumbBottomRight ||
                    isCrumbWithoutTop ||
                    isCrumbWithoutBottom
                    )
                {
                    Console.WriteLine("cookie crumb");
                }
                else
                {
                    Console.WriteLine("broken cookie");
                }
            }

            if (command == "buy")
            {
                if (isWholeCookie)
                {
                    decimal cookieValue = 1.79m;
                    bill += cookieValue;

                    pageTray[currentRow][currentCol] = '0';
                    pageTray[currentRow][currentCol - 1] = '0';
                    pageTray[currentRow][currentCol + 1] = '0';
                    pageTray[currentRow - 1][currentCol] = '0';
                    pageTray[currentRow - 1][currentCol - 1] = '0';
                    pageTray[currentRow - 1][currentCol + 1] = '0';
                    pageTray[currentRow + 1][currentCol] = '0';
                    pageTray[currentRow + 1][currentCol - 1] = '0';
                    pageTray[currentRow + 1][currentCol + 1] = '0';
                }
                else
                {
                    Console.WriteLine("page");
                }
            }

            if (currentCentralPosition == '0' && command != "buy")
            {
                Console.WriteLine("smile");
            }
        }
    }
}
