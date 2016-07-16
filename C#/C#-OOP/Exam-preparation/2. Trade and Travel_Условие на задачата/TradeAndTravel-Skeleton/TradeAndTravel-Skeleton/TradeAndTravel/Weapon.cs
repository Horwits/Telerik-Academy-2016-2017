namespace TradeAndTravel
{
    internal class Weapon : Item
    {
        private Location itemLocation;
        private string itemNameString;

        public Weapon(string itemNameString, Location itemLocation)
        {
            this.itemNameString = itemNameString;
            this.itemLocation = itemLocation;
        }

        protected Weapon(string name, int itemValue, string type, Location location = null) : base(name, itemValue, type, location)
        {
        }
    }
}