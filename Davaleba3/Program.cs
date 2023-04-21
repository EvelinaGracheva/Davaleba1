class Program
{
    static void Main(string[] args)
    {
        int length = GetInput("length");
        int width = GetInput("width");
        int height = GetInput("height");

        int area = CalculateArea(length, width);
        Console.WriteLine($"Area: {area}");

        int volume = CalculateVolume(length, width, height);
        Console.WriteLine($"Volume: {volume}");
    }

    static int GetInput(string dimension)
    {
        Console.Write($"Enter {dimension}: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static int CalculateArea(int length, int width)
    {
        return length * width;
    }

    static int CalculateVolume(int length, int width, int height)
    {
        return length * width * height;
    }
}
