namespace _001_Practice
{
    public class Item
    {
        public string name;
        public string description;
        public int quantity;
        public double price;

        //method
        public double GetTotalPrice()
        {
            return quantity * price;
        }

        public void SetPrice(double amount)
        {
            this.price = amount;
        }

        public void AddQuantity(int amount)
        {
            this.quantity += amount;
        }
    }

}
