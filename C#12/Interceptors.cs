using System.Runtime.CompilerServices;

namespace CSharp12;

/// <summary>
/// C# 12: 인터셉터 (실험적 기능)
/// https://github.com/dotnet/csharplang/issues/7009
/// 
/// 특정 라인의 호출 메서드를 다른 메서드로 대체하는 기능입니다.
///
/// 일반적인 용도로는 사용하지 않으며 소스 생성기와 함께 사용했을 경우 유용합니다. 하지만 실험적 기능으로 이후 방식이 변경되거나 기능이 없어질 수 있습니다.
/// 
/// 정성태님의 아래 링크 글을 참고할 수 있습니다.
/// https://www.sysnet.pe.kr/2/0/13410
/// </summary>
internal static class Interceptors
{
    public static void TestCall()
    {
        CallOrignal();
    }

    private static void CallOrignal() => Console.WriteLine("오리지널!");

    static class My
    {
        // 소스 파일의 절대 경로를 filePath에 넣어줘야 함
        [InterceptsLocation("W:\\MyWorks\\CSharpExplore\\C#12\\Interceptors.cs", 20, 9)]
        public static void CallMy() => Console.WriteLine("수정됨!");
    }
}
