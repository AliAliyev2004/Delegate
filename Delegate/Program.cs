using System;

public delegate void Func(string str);

public class MyClass
{
    private string _str;

    public MyClass(string str)
    {
        _str = str;
    }

    public void Space(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            Console.Write(str[i]);
            if (i < str.Length - 1)
            {
                Console.Write("_");
            }
        }
        Console.WriteLine();
    }

    public void Reverse(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine(new string(charArray));
    }
}

public class Run
{
    public void runFunc(Func funcDell, string str)
    {
        funcDell.Invoke(str);
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter string:");
        var str = Console.ReadLine();
        
        MyClass cls = new MyClass(str);
        Func funcDell = new Func(cls.Space);
        funcDell += cls.Reverse;
        
        Run run = new Run();
        run.runFunc(funcDell, str);
    }
}
