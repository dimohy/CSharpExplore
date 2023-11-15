using System.Diagnostics.CodeAnalysis;

namespace CSharp12;

/// <summary>
/// C# 12: 실험적 특성
/// https://github.com/dotnet/csharplang/blob/main/proposals/csharp-12.0/experimental-attribute.md
/// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-12.0/experimental-attribute
/// 
/// 제공하는 기능(어셈블리, 모듈, 클래스, 구조체, 열거형, 생성자, 메소드, 속성, 필드, 이벤트, 인터페이스, 딜리게이트)이 실험적임을 사용자가 인식할 수 있도록 합니다.
/// 사용하려고 할 때 Experimental에 지정된 ID로 에러가 발생하며 이를 무시하려면 소스코드 또는 프로젝트 설정에서 비활성화 한 후 사용할 수 있습니다.
/// 
/// </summary>
internal class ExperimentalAttributeTest
{
    public void Test1()
    {
        // EA001 오류: Experimental 특성에 명명된 `diagnosticId`로 오류가 발생하며 사용자에게 실험적 기능임을 알게 함
        // 프로젝트 설정 또는 코드에서 오류를 무시하도록 한 후 사용할 수 있음
#pragma warning disable EA001 // 형식은 평가 목적으로 제공되며, 이후 업데이트에서 변경되거나 제거될 수 있습니다. 계속하려면 이 진단을 표시하지 않습니다.
        Method1();
    }

    [Experimental("EA001")]
    public void Method1()
    {
        Console.WriteLine("Works!");
    }
}
