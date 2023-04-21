class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        string binaryNumber = Convert.ToString(decimalNumber, 2);

        Console.WriteLine("Binary representation: " + binaryNumber);
    }
}
