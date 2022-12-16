
int one = 10;
int two = 10;
//if문
if(one == two)
{
    Console.WriteLine($"one({one})과 two({two})는 같습니다.");
    one += 1;
}

if(one == two)
{
    Console.WriteLine($"one({one})과 two({two})는 같습니다.");
    one += 1;
}

else if(one >= two)
{
    Console.WriteLine($"one({one})과 two({two})는 one이 더 큽니다.");
}

if(one == two)
{
    Console.WriteLine($"one({one})과 two({two})는 같습니다.");
    one += 1;
}

else if(one <= two)
{
    Console.WriteLine($"one({one})과 two({two})는 one이 더 작습니다.");
}

if(one == two)
{
    Console.WriteLine($"one({one})과 two({two})는 같습니다.");
    one += 1;
}

else if(one <= two)
{
    Console.WriteLine($"one({one})과 two({two})는 one이 더 큽니다.");
}

else
{
    Console.WriteLine($"one({one})과 two({two})는 one이 더 작습니다.");
}

//switch 문
string day = "수";
switch (day)
{
    case "일":
        Console.WriteLine("일요일");
        break;
    case "월":
        Console.WriteLine("월요일");
        break;
    case "화":
        Console.WriteLine("화요일");
        break;
    case "수":
        Console.WriteLine("수요일");
        break;
    default:
        Console.WriteLine("아무 요일에도 해당하지 않습니다.");
        break;
    
    
}

Console.WriteLine("월을 입력해 주세요.");
int inputMonth = int.Parse(Console.ReadLine());
 
switch (inputMonth)
{
    case 1:
    case 2:
    case 12:
        Console.WriteLine("겨울 입니다.");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("봄 입니다.");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("여릅 입니다.");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("가을 입니다.");
        break;
    default:
        Console.WriteLine("달은 1월부터 12월 까지 있습니다.");
        break;
}