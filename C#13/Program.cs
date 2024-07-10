using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, C# 13 Explored!");




//var l = new Lock();
//var l = new object();
//var l = new UserLock();


//Print:
//Console.WriteLine("Start A");
//_ = Task.Run(() => SyncMethod("A"));
//Console.WriteLine("Start B");
//_ = Task.Run(() => SyncMethod("B"));


//Console.ReadLine();


//void SyncMethod(string workId)
//{
//    lock (l)
//    {
//        Thread.Sleep(1000);
//        Console.WriteLine($"{workId} Worked!");
//    }
//}


//public class UserLock
//{
//    public Scope EnterScope()
//    {
//        Console.WriteLine("!!");

//        return new Scope();
//    }

//    public ref struct Scope
//    {
//        public void Dispose()
//        {

//        }
//    }
//}


//char escape_char = '\e';

//Console.WriteLine(escape_char == (char)0x1b);
//Console.WriteLine(escape_char == '\e');
//Console.WriteLine(escape_char == '\U0000001b');
//Console.WriteLine(escape_char == '\x1b');

//Console.WriteLine("This is a regular text");
//Console.WriteLine("\e[1mThis is a bold text\e[0m");
//Console.WriteLine("\e[2mThis is a dimmed text\e[0m");
//Console.WriteLine("\e[3mThis is an italic text\e[0m");
//Console.WriteLine("\e[4mThis is an underlined text\e[0m");
//Console.WriteLine("\e[5mThis is a blinking text\e[0m");
//Console.WriteLine("\e[6mThis is a fast blinking text\e[0m");
//Console.WriteLine("\e[7mThis is an inverted text\e[0m");
//Console.WriteLine("\e[8mThis is a hidden text\e[0m");
//Console.WriteLine("\e[9mThis is a crossed-out text\e[0m");
//Console.WriteLine("\e[21mThis is a double-underlined text\e[0m");
//Console.WriteLine("\e[38;2;255;0;0mThis is a red text\e[0m");
//Console.WriteLine("\e[48;2;0;255;0mThis is a green background\e[0m");
//Console.WriteLine("\e[38;2;0;0;255;48;2;255;255;0mThis is a blue text with a yellow background\e[0m");


//Dictionary<string, object> vars = ["Test" : 5];
//var var = (List<int>))[];


PrintReadOnlySpanParams(1, 2, 3, 4, 5);
PrintListParams(1, 2, 3, 4, 5);
PrintEnumerableParams(1, 2, 3, 4, 5);


void PrintReadOnlySpanParams(params ReadOnlySpan<int> @params)
{
    foreach (var p in @params)
    {
        Console.WriteLine(p);
    }
}

void PrintListParams(params List<int> @params)
{
    foreach (var p in @params)
    {
        Console.WriteLine(p);
    }
}

void PrintEnumerableParams(params IEnumerable<int> @params)
{
    foreach (var p in @params)
    {
        Console.WriteLine(p);
    }
}