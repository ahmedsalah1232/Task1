namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int small_carpet_price,large_carpet_price;
            Console.WriteLine("Islam carpet cleaning service");
            Console.WriteLine("Charges:");
            Console.WriteLine("        $25 per small");
            Console.WriteLine("        $35 per large");
            Console.WriteLine("Sales Tax rate is 6%");
            Console.WriteLine("Estimates are valid for 30 days");
            Console.WriteLine("Estimates for carpet cleaning service");
            Console.Write("Number of small carpets:");
            small_carpet_price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of large carpets:");
            large_carpet_price = Convert.ToInt32(Console.ReadLine());
            int cost = small_carpet_price * 25 + large_carpet_price * 35;
            float tax =  (float)(cost*6)/100;
            float total=cost+tax;
            Console.WriteLine("Price per small carpet : $25");
            Console.WriteLine("Price per large carpet : $35");
            Console.WriteLine($"Cost : ${cost}");
            Console.WriteLine($"Tax : ${tax}");
            Console.WriteLine("===================================");
            Console.WriteLine($"Total estimate : ${total}");
            Console.WriteLine("This estimate is valid for 30 days");



        }
    }
}
