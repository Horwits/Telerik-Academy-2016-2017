namespace Homework.Task_2
{
    using System;
    using Chef;
    using Chef.Contracts;

    public class TaskTwo
    {
        public const int MinX = 5;
        public const int MaxX = 100;

        public const int MinY = 2;
        public const int MaxY = 50;

        public void CheckIfPotatoIsReadyToBeCooked(Potato potato, IChef chef)
        {
            var isPotatoNull = potato == null;
            var isChefNull = chef == null;

            if (!isPotatoNull && !isChefNull)
            {
                var potatoIsPeeled = potato.HasBeenPeeled;
                var potatoIsRotten = potato.IsRotten;

                if (potatoIsPeeled && !potatoIsRotten)
                {
                    chef.Cook(potato);
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public void CheckIfCanVisitCell(int givenX, int givenY, bool shouldVisitCell)
        {
            var givenXIsBiggerOrEqualThanMinX = givenX >= MinX;
            var givenXIsSmallerOrEqualThanMaxX = givenX <= MaxX;

            var givenYIsBiggerOrEqualThanMinX = givenY >= MinY;
            var givenYIsSmallerOrEqualThanMaxX = givenY <= MaxY;

            var canVisitCell = givenXIsBiggerOrEqualThanMinX &&
                (givenXIsSmallerOrEqualThanMaxX &&
                ((givenYIsSmallerOrEqualThanMaxX && givenYIsBiggerOrEqualThanMinX) &&
                shouldVisitCell));

            if (canVisitCell)
            {
                this.VisitCell();
            }
        }

        private void VisitCell()
        {
            throw new System.NotImplementedException();
        }
    }
}