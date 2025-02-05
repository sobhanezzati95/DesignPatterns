namespace Design_Patterns.Structural_Patterns.Facade
{
    // Subsystem: Inventory
    public class Inventory
    {
        public bool CheckInventory(string productId, int quantity)
        {
            // Simulate inventory check
            Console.WriteLine($"Checking inventory for product {productId}, quantity {quantity}");
            return true; // Assume inventory is available
        }
    }

    // Subsystem: Payment
    public class Payment
    {
        public bool ProcessPayment(double amount)
        {
            // Simulate payment processing
            Console.WriteLine($"Processing payment of {amount}");
            return true; // Assume payment is successful
        }
    }

    // Subsystem: Shipping
    public class Shipping
    {
        public void ShipOrder(string productId, string address)
        {
            // Simulate shipping
            Console.WriteLine($"Shipping product {productId} to {address}");
        }
    }

    public class OrderFacade
    {
        private Inventory _inventory;
        private Payment _payment;
        private Shipping _shipping;

        public OrderFacade()
        {
            _inventory = new Inventory();
            _payment = new Payment();
            _shipping = new Shipping();
        }

        public void PlaceOrder(string productId, int quantity, double amount, string address)
        {
            // Step 1: Check inventory
            if (_inventory.CheckInventory(productId, quantity))
            {
                // Step 2: Process payment
                if (_payment.ProcessPayment(amount))
                {
                    // Step 3: Ship the order
                    _shipping.ShipOrder(productId, address);
                    Console.WriteLine("Order placed successfully!");
                }
                else
                {
                    Console.WriteLine("Payment failed. Order not placed.");
                }
            }
            else
            {
                Console.WriteLine("Insufficient inventory. Order not placed.");
            }
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Create the facade
    //        OrderFacade orderFacade = new OrderFacade();
    //
    //        // Place an order using the facade
    //        orderFacade.PlaceOrder(productId: "12345",
    //                               quantity: 2,
    //                               amount: 100.00,
    //                               address: "123 Main St, City, Country");
    //    }
    //}
}
