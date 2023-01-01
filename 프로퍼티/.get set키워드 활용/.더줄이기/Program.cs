namespace _더줄이기;
class Knight
{
    public int Hp
    {
        get; set;
    }

    public int Mp
    {
        get; set;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Knight ClonKnight= new Knight();
        ClonKnight.Hp = 100;
        ClonKnight.Mp = 1200;
        int myHp = ClonKnight.Hp;
        int myMp = ClonKnight.Mp;
        Console.WriteLine($"myHP : {myHp} myMP : {myMp}");
    }
}
