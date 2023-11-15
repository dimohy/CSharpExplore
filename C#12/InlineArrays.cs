using System.Runtime.CompilerServices;

namespace CSharp12;

/// <summary>
/// C# 12: 인라인 배열
/// https://github.com/dotnet/csharplang/blob/main/proposals/csharp-12.0/inline-arrays.md
/// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-12.0/inline-arrays
/// 
/// InlineArray 특성을 이용해 인라인 배열을 생성할 수 있습니다.
/// 
/// 정성태님의 아래 링크 글을 참고할 수 있습니다.
/// https://www.sysnet.pe.kr/2/0/13412
/// </summary>
internal static class InlineArrays
{
    /// <summary>
    /// 인라인 배열의 할당 및 사용
    /// </summary>
    public static void Test1()
    {
        var block = new Block();
        Console.WriteLine(block[0]);
        Console.WriteLine(block[1]);
        Console.WriteLine(block[2]);
        Console.WriteLine(block[3]);
        Console.WriteLine(block[4]);
        // Console.WriteLine(block[5]); // CS9166 오류: 컴파일 시점에서 인라인 배열 경계를 확인하여 오류를 발생합니다.
    }

    /// <summary>
    /// 인라인 배열 길이 구하기
    /// </summary>
    public static void Test2()
    {
        // Unsafe.SizeOf()를 이용해 할당 크기를 구할 수 있음
        var bytes = Unsafe.SizeOf<Block>();
        Console.WriteLine(bytes);
        // 이것으로 길이를 계산할 수 있음
        var length = bytes / Unsafe.SizeOf<int>();
        Console.WriteLine(length);

        // Span으로 변환한 후 Length를 사용할수도 있음
        var block = new Block();
        Span<int> span = block;
        Console.WriteLine(span.Length);
    }

    /// <summary>
    /// 제네릭으로 인라인 배열을 사용할 수도 있음
    /// </summary>
    public static void Test3()
    {
        var intBlock = new Block<int>();
        Console.WriteLine(intBlock[3]);
        var decimalBlock = new Block<decimal>();
        Console.WriteLine(decimalBlock[2]);
    }

    [System.Runtime.CompilerServices.InlineArray(5)]
    struct Block
    {
        private int _element0;
    }

    [System.Runtime.CompilerServices.InlineArray(5)]
    struct Block<T>
    {
        private T _element0;
    }
}
