namespace 인터페이스;
interface IAnimal
{
    void Eat();
}
class Person : IAnimal
{
    public void Eat()
    {
        Console.WriteLine("밥을 먹을 수 있습니다.");
    }
}
class Lion : IAnimal
{
    public void Eat()
    {
        Console.WriteLine("고기를 먹습니다");
    }
}
class Camel
{
    public void Eat()
    {
        Console.WriteLine("풀을 먹습니다.");
    }
}
class Program
{
    static void Main(String[] args)
    {
        Person myPerson = new Person();
        Lion myLion = new Lion();
        Camel  myCamel = new Camel();
        myPerson.Eat();
        myLion.Eat();
        myCamel.Eat();
    }
}
