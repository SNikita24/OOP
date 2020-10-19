
using System;
using System.Collections.Generic;

class Test
{
    static void Main()
    {
        bool a = false;
        Console.WriteLine(a);
        byte b = 2;
        Console.WriteLine(b);
        sbyte c = -2;
        Console.WriteLine(c);
        decimal e = 5468;
        Console.WriteLine(e);
        double f = 241.43;
        Console.WriteLine(f);
        float g = 23;
        Console.WriteLine(g);
        int i = 4274647;
        Console.WriteLine(i);
        uint o = 5326276;
        Console.WriteLine(o);
        long y = -347527794;
        Console.WriteLine(y);
        ulong t = 425687246882999299;
        Console.WriteLine(t);
        short j = -3;
        Console.WriteLine(j);
        ushort p = 38;
        Console.WriteLine(p);
        string n = "give me labe";
        Console.WriteLine(n);
    }

    static void Conversation()
    {
        int a = 8;
        float b = a;
        double c=4.1;
        float d= (float)c;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
    }
    static void Pack()
    {
        int a = 25; //boxing
        object obj = a;

        int b = (int)obj; //unboxing

        Console.WriteLine(a);
        Console.WriteLine(b);

    }
    static void @Var()
    {
        var a = 5;
        Console.WriteLine(a.GetType());
        var y = new { Name = "Virgil", Age = 28 };
        Console.WriteLine(y);
    }
    static void Nallable()
    {
        string str = null;
        object obj = null;
        int? a = null;
        DateTime? dateTime = null;
        Console.WriteLine(str);
        Console.WriteLine(obj);
        Console.WriteLine(a.HasValue);
        Console.WriteLine(a.Value);
        Console.WriteLine(dateTime);
    }
    static void Strings()
    {
        string a = "Nikita";
        string b = "Dima";
        Console.WriteLine(String.Compare(a, b)); //сравнение строк а=b(0), a>b(1),a<b(-1)

        string str1 = "koala eat";
        string str2 = "bear went";
        string str3 = "bee fly";
        string str4 = String.Concat(str1, str2); //объединение строк
        Console.WriteLine(str4);
        Console.WriteLine(str1.Contains("oal"));//Выделение подстроки
        Console.WriteLine(str3.Contains("oal"));
        Console.WriteLine(str3.Remove(5));//удаление подстроки
        string[] words = str2.Split(new char[] { ' ' });//расдел строки
        Console.WriteLine(str1.Insert(6, str2));//вставка

    }
    static void Arrays()
    {
        int[,] myArray = new int[,] {{ 2, 4 },{ 3, 5 },{ 4, 7 } };
        string[] myArray1 = new string[] { "I", "known", "two", "languages" };
        Console.WriteLine(myArray);
        int[][] nums = new int[3][];//
        nums[0] = new int[] { 1, 2 };          
        nums[1] = new int[] { 1, 2, 3, 7 };      
        nums[2] = new int[] { 3, 4, 5 };
    }
}