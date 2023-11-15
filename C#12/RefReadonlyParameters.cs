namespace CSharp12;

/// <summary>
/// C# 12: ref readonly 메서드 파라미터
/// https://github.com/dotnet/csharplang/issues/6010
/// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-12.0/ref-readonly-parameters
/// 
/// 메서드 매개변수에 `ref readonly` 유형을 사용할 수 있습니다.
/// 읽기 전용의 ref 유형을 의미합니다.
/// 
/// 정성태님의 아래 링크 글을 참고할 수 있습니다.
/// https://www.sysnet.pe.kr/2/0/13428
/// </summary>
internal static class RefReadonlyParameters
{
    public static int MethodRefReadonly(ref readonly int value) => value + 1;
    // public static int Method1(in int value) => value + 1; // CS0663 오류: `in`과 `ref readonly`는 오버로드 되지 않음
    public static int MethodIn(in int value) => value + 1;

    public static void TestRefReadonly()
    {
        MethodRefReadonly(5); // CS9193 경고: `ref readonly`는 변수를 사용해야 함

        var x = 5;
        MethodRefReadonly(x); // CS9192 경고: `in` 또는 `ref` 키워트를 사용해야 함
        MethodRefReadonly(in x);
        MethodRefReadonly(ref x);
    }
    public static void TestIn()
    {
        MethodIn(5);

        var x = 5;
        MethodIn(x);
        MethodIn(in x);
        MethodIn(ref x); // CS9191 경고: C# 11에는 오류였으나 C# 12에는 경고로 완화됨
    }
}
