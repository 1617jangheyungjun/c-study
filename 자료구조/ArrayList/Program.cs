using System;
using System.Collections;
namespace ProjectArrayList
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList list = new ArrayList();
            for(int i = 0; i < 5; i++)
            {
                list.Add(i); // Add는 list 값을 넣어줄 수 있습니다.
            }
            Console.WriteLine("추가");
            foreach(object obj in list)
                Console.WriteLine($"{obj}"); //list를 foreach문을 통해 출력
            
            list.RemoveAt(2);//2번째 배열의 값을 2로 RemoveAt을 통해 삭제
            Console.WriteLine("삭제");
            foreach(object obj in list)
                Console.WriteLine($"{obj}");
            Console.WriteLine();
            Console.WriteLine("변경");
            list.Insert(2,5);//2번째 배열의 값을 5로 변경
            foreach(object obj in list)
                Console.WriteLine($"{obj}");
            Console.WriteLine();

            for(int i = 0; i < list.Count; i ++)
                Console.WriteLine($"{list[i]}");
            Console.WriteLine();

            Console.WriteLine("__________________");
            ArrayList monsterNumber = new ArrayList();

            monsterNumber.Insert(0, 100);
            monsterNumber.Insert(1,200);
            monsterNumber.Insert(2,300);
            monsterNumber.Insert(3,400);
            monsterNumber.Insert(4,500);

            for(int i=0; i < monsterNumber.Count; i++)
            {
                Console.WriteLine(monsterNumber[i]);
            }
            
        }
    }

}