namespace Carpet_Cleaning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Islam's Carpet Cleaning Service");
            Console.WriteLine("Charges:");
            Console.WriteLine("$25 per small");
            Console.WriteLine("$35 per large");
            Console.WriteLine("Sales tax rate is 6%");
            Console.WriteLine("Estimates are valid for 30 days");
            Console.WriteLine("<---Estimate price of Carpet Cleaning--->");
            Console.Write("Number of small carpets: ");
        int noOfsmallCarpets = Convert.ToInt32(Console.ReadLine());
                               Console.Write("Number of large carpets: ");
            int noOflargeCarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" Price for total small carpets : {noOfsmallCarpets * 25}");
            Console.WriteLine($"Price for total large carpets : {noOflargeCarpets * 35}");
            Console.WriteLine($"Price for total of carpets :  {(noOflargeCarpets * 35) + (noOfsmallCarpets * 25)} ");
            int cost = (noOflargeCarpets * 35 + noOfsmallCarpets * 25);
            Console.WriteLine($"Taxes : {(int)(cost * 0.06)}");
            Console.WriteLine($"The total cost including tax is : {((noOflargeCarpets * 35 + noOfsmallCarpets * 25) + (cost * 0.06))}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
