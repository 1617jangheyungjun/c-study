using System;
using System.Collections.Generic;


namespace Hashtable;
class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> emp = new Dictionary<int, string>();
        emp.Add(1001,"철수");
        emp.Add(1002, "영희");
        emp.Add(1003, "길동");

        string name = emp[1002];
        Console.WriteLine(name);
    }
}
