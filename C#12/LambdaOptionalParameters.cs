namespace CSharp12;

/// <summary>
/// C# 12: 람다 선택적 매개변수
/// https://github.com/dotnet/csharplang/issues/6051
/// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-12.0/lambda-method-group-defaults
/// 
/// 이전까지는 람다에서 선택적 매개변수를 사용할 수 없었습니다. C# 12부터는 람다에서 선택적 매개변수를 사용할 수 있습니다.
/// 
/// 정성태님의 아래 링크 글을 참고할 수 있습니다.
/// https://www.sysnet.pe.kr/2/0/13338
/// </summary>
internal static class LambdaOptionalParameters
{
    public static void Test1()
    {
        // incValue는 기본값 1을 가지므로 선택적으로 사용할 수 있음
        var incNum = (int value, int incValue = 1) => value + incValue;

        // 9와 기본값인 1을 더하므로 10이 반환됨
        Console.WriteLine(incNum(9));
        // 5와 2를 더하므로 7이 반환됨
        Console.WriteLine(incNum(5, 2));
    }
}
