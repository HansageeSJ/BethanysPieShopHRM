namespace BethanysPieShopHRM.Accounting
{
    internal class Customer
    {
        // Create class level variables
        private string customerId;
        private string name;

        // Create properties to read or change data

        public string CustomerId
        {
            get { return customerId; }
            set { 
                customerId = value; 
                }
        }

        public string Name
        {
            get { return name; }
            set { 
                name = value; 
                }
        }
    }
}
