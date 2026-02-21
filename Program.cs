class Program
{
    static void Main()
    {
        Console.WriteLine("Choose system:");
        Console.WriteLine("1 – Online Store Order");
        Console.WriteLine("2 – Cinema Ticket");
        Console.WriteLine("3 – Gym Membership");

        Console.Write("Enter option: ");
        int option = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("\nONLINE STORE ORDER\n");

        Console.Write("Product Name: ");
        string? productName = Console.ReadLine();

        Console.Write("Quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Price per Item: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Discount Percentage: ");
        double discount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Delivery Distance (km): ");
        double distance = Convert.ToDouble(Console.ReadLine());

        Console.Write("First Letter of Payment Method: ");
        char paymentLetter = Convert.ToChar(Console.ReadLine());

        Console.Write("Is Express Delivery (true/false): ");
        bool express = Convert.ToBoolean(Console.ReadLine());


        double totalPrice = quantity * price;
        double discountAmount = totalPrice * discount / 100;
        double finalPrice = totalPrice - discountAmount;


        Console.WriteLine("\n ORDER DATA ");

        Console.WriteLine($"Product Name: {productName}");
        Console.WriteLine($"Quantity: {quantity}");
        Console.WriteLine($"Price: {price}");
        Console.WriteLine($"Discount: {discount}%");
        Console.WriteLine($"Distance: {distance} km");
        Console.WriteLine($"Payment Letter: {paymentLetter}");
        Console.WriteLine($"Express Delivery: {express}");


        Console.WriteLine("\n CALCULATIONS ");

        Console.WriteLine($"Total Price: {totalPrice}");
        Console.WriteLine($"Discount Amount: {discountAmount}");
        Console.WriteLine($"Final Price: {finalPrice}");


        Console.WriteLine("\n DATA TYPES ");

        Console.WriteLine(quantity.GetType());
        Console.WriteLine(price.GetType());
        Console.WriteLine(express.GetType());

    }
}