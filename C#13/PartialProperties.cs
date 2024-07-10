
using System.ComponentModel;

namespace C13;

/// <summary>
/// C# 13: 부분 속성 (partial properties)
/// https://github.com/dotnet/csharplang/issues/6420
/// 
/// 속성을 `partial`을 통해 선언과 구현을 분리하도록 허용합니다.
/// 
/// 소스 생성기를 통해 속성을 자동 생성하고자 할 때 기존 방식인 필드를 장식하는 것에서 속성 자체를 장식하는 방식으로 변경할 수 있습니다.
/// </summary>
internal partial class PartialProperties
{
    public event PropertyChangedEventHandler PropertyChanged;

    [NotifyPropertyChanged]
    public partial string UserName { get; set; }

    // 기존 방식
    [NotifyPropertyChanged]
    private string _userName;
}


// Generated.cs
// 소스 생성기를 통해 `[NotifyPropertyChanged]` 특성을 통해 자동 생성되는 코드
internal partial class PartialProperties
{
    private string __generated_userName;

    public partial string UserName
    {
        get => __generated_userName;
        set
        {
            if (value != __generated_userName)
            {
                __generated_userName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UserName)));
            }
        }
    }
}

public class NotifyPropertyChangedAttribute : Attribute
{
}