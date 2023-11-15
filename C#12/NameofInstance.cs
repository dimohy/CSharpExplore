namespace CSharp12;

/// <summary>
/// C# 12: 정적 문맥에서 인스턴스 맴버에 대한 nameof 접근
/// https://github.com/dotnet/csharplang/issues/4037
/// 
/// 정성태님의 아래 링크 글을 참고할 수 있습니다.
/// https://www.sysnet.pe.kr/2/0/13427
/// </summary>
internal class NameofInstance
{
    public string? P;
    public static string M1() => nameof(P);
    public static string M2() => nameof(P.Length); // C# 11에서 오류, C# 12에서 정상 컴파일
}
