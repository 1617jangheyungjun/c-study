namespace 반복문;
class Program
{
    static void Main(string[] args)
    {
        int playerExp = 10;
        //while 문
        while(playerExp > 0)
        {
            Console.WriteLine($"Player : {playerExp}");
            playerExp--;
        }
        for (int playerGold = 0; playerGold < 5; playerGold++)
        {
            Console.WriteLine($"playerGold : {playerGold}");
        }
    }
}
