namespace 열거형식;
class Program
{
    enum Days
    {
        Mon,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat,
        Sun
    }
    static void Main(string[] args)
    {
        Days day = Days.Sun;
        switch (day)
        {
            case Days.Mon:
            case Days.Tue:
            case Days.Wed:
            case Days.Thu:
            case Days.Fri:
                Console.WriteLine("평일입니다.");
                break;
            case Days.Sat:
            case Days.Sun:
                Console.WriteLine("주말입니다.");
                break;
            default:
                Console.WriteLine("올바른 값을 입력하세요");
                break;
        }
    }
}
