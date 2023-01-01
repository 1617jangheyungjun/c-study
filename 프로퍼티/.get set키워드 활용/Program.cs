namespace _get_set키워드_활용;
class People
{
    private string name;
    private int age;
    public string Name
    {
        get 
        {
            if(name == null)
            {
                return "Error";
            }
            return name;
        }
        set
        {
            name = value;
        }
    }
    
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            age = value;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        People Kim = new People();
        Kim.Name = "song";
        Kim.Age = 17;
        Console.WriteLine(Kim.Name + " " + Kim.Age);
    }
}
