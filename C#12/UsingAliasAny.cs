/// <summary>
/// C# 12: 모든 유형의 using 별칭
/// https://github.com/dotnet/csharplang/issues/4284
/// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-12.0/using-alias-types
/// 
/// using을 이용해 다양한 타입을 별칭을 지정할 수 있습니다.
/// 
/// 정성태님의 아래 링크 글을 참고할 수 있습니다.
/// https://www.sysnet.pe.kr/2/0/13341
/// </summary>

// global로 별칭을 사용할 수 있습니다.
global using IntList = System.Collections.Generic.List<int>;

namespace CSharp12;

using StringList = List<string>;
using IntList2 = IntList;
using Tuple = (int, int, int);
// 제네릭 별칭은 사용할 수 없습니다.
// using Tuple<T> = (T, T, T);

internal static class UsingAliasAny
{
    public static void Test()
    {
        var list1 = new StringList { "A", "B", "C" };
        StringList list2 = [ "A", "B", "C"];

        Tuple tuple = (1, 2, 3);
        
        var value = (1, 2, 3);
        Tuple tuple2 = value;
        Console.WriteLine(tuple.GetType().Name);
    }
}
