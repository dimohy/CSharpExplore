namespace CSharp12;

/// <summary>
/// C# 12: 기본 생성자
/// https://github.com/dotnet/csharplang/issues/2691
/// 
/// 레코드 처럼 클래스도 유사하게 특정 필드(속성이 아닌)를 초기화 할 수 있습니다.
/// 
/// 정성태님의 아래 링크 글을 참고할 수 있습니다.
/// https://www.sysnet.pe.kr/2/0/13339
/// </summary>
internal static class PrimaryConstructors
{
    public static void Test1()
    {
        var student = new Student("아무개", "20231115", 0);
        Console.WriteLine(student.Summary);
    }

    /// <summary>
    /// 기본 생성자의 매개변수는 클래스의 필드로 캡쳐 됩니다.
    /// 캡쳐된 매개변수를 클래스에서 사용할 수 있습니다.
    /// 하지만 private 필드가 되므로 외부에서는 접근할 수 없습니다.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="sn"></param>
    /// <param name="sex"></param>
    class Student(string name, string sn, int sex)
    {
        // 캡쳐된 필드를 사용할 수 있습니다.
        public string Summary => $"{sn}: {name}, {(sex is 0 ? "남자" : "여자")}";

        // 캡쳐된 필드를 외부로 공개하려면 다음과 같이 합니다.
        public string Name => name;

        //public Student() // CS8862 오류: 기본 생성자 목록이 있을 경우 기본 생성자와 연결 되어야 합니다.
        //{
        //}

        public Student(string name, string sn) : this(name, sn, 0)
        {
        }
    }
}
