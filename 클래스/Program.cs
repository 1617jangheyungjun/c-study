namespace 클래스;
class Program
{
    static void Main(string[] args)
    {
        Dog puppy;
        Dog dog;
        puppy = new Dog();
        puppy.Bark();
        dog = new Dog();
        dog.Waite();
    }
}
class Dog
{
    public void Bark()
    {
        Console.WriteLine("월월");
    }
    public void Waite()
    {
        Console.WriteLine("으르르");
    }
}