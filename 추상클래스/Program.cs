namespace 추상클래스;
class Program
{
    public abstract class abstractAnimal
    {
        public abstract void Sound();
    }
    public class Dog : abstractAnimal
    {
        public override void Sound()
        {
            Console.WriteLine("멍멍");
        }
    }
    public class Cat : abstractAnimal
    {
        public override void Sound()
        {
            Console.WriteLine("야옹야옹");
        }
    }
    static void Main(string[] args)
    {
        Dog puppy = new Dog();
        Cat happy_cat = new Cat();

        puppy.Sound();
        happy_cat.Sound();
    }
}
