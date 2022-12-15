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