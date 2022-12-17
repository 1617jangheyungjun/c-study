namespace 메서드;
class Program
{
    static void ShowHello()
    {
        Console.WriteLine("Hello World");
    }
    static int add(int a, int b)
    {
        return a + b;
    }
    static void Main(string[] args)
    {
        ShowHello();
        Console.WriteLine(add(12, 23));
    }
}
