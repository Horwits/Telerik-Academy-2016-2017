namespace Chef
{
    using System;
    using Contracts;

    public class Chef : IChef
    {
        public void Cook()
        {
            var potato = this.GetPotato();
            this.Peel(potato);
            this.Cut(potato);

            var carrot = this.GetCarrot();
            this.Peel(carrot);
            this.Cut(carrot);

            var bowl = this.GetBowl();

            bowl.Add(carrot);
            bowl.Add(potato);
        }

        public void Cook(IVegetable vegetable)
        {
            throw new NotImplementedException();
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private void Peel(IPeelable potato)
        {
            throw new NotImplementedException();
        }

        private void Cut(IVegetable vegetable)
        {
            throw new NotImplementedException();
        }
    }
}
