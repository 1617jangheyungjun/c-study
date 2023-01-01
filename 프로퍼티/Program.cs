namespace 프로퍼티;
class People
{
    public string name;
    public int age;


    public string GetName()
    {
        if(name == null)
        {
            return "Error";
        }
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public int GetAge()
    {
        return age;
    }
    public void SetAge(int age)
    {
        this.age = age;
    }
}
class Peogram
{
    static void Main(string[] args)
    {
        People Kim = new People();
        Kim.name = "Kim";
        Kim.age = 10;

        Console.WriteLine($"{Kim.name}, {Kim.age}.");

        People jang = new People();
        jang.SetName("jun");
        jang.SetAge(17);
        Console.WriteLine(jang.GetName() + " " + jang.GetAge());
    }
}
