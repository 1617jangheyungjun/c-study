namespace 배열;
class Program
{
    static void Main(string[] args)
    {
        int[] scores = new int[5];

        scores[0] = 80;
        scores[1] = 20;
        scores[2] = 30;
        scores[3] = 92;
        scores[4] = 23;
        for(int a = 0; a < scores.Length; a++)
        {
            Console.WriteLine(scores[a]);
        }
    }
}
