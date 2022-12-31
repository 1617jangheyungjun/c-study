using System.Collections;
namespace 인덱서;
class SampleCollection
{
    private string[] arr = new string[100];

    public string this[int i]
    {
        get { return arr[i];}
        set {arr[i] = value;}
    }
}
class Program
{
    static void Main(string[] args)
    {
        SampleCollection stringCollection = new SampleCollection();
        stringCollection[0]= "안녕하세요!";
        stringCollection[1] = "반갑습니다!";
        stringCollection[50] = "프로그래밍 수업입니다";
        Console.WriteLine(stringCollection[0]);
        Console.WriteLine(stringCollection[1]);
        Console.WriteLine(stringCollection[30]);
        Console.WriteLine(stringCollection[50]);
    }
}
