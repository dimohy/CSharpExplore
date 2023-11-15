using System.Collections;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;

namespace CSharp12;

/// <summary>
/// C# 12: 컬렉션 식
/// https://github.com/dotnet/csharplang/issues/5354
/// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-12.0/collection-expressions
/// 
/// 대괄호로 컬렉션을 표현할 수 있습니다.
/// 
/// 정성태님의 아래 링크 글을 참고할 수 있습니다.
/// https://www.sysnet.pe.kr/2/0/13415
/// </summary>
internal static class CollectionExpressions
{
    public static void Method1(List<int> list)
    {
    }

    public static void Method2(int[] list)
    {
    }

    public static void Method3(Span<int> list)
    {
    }

    /// <summary>
    /// 다양한 유형으로 목록 생성
    /// </summary>
    public static void Test1()
    {
        int[] list1 = [1, 2, 3, 4, 5];
        List<int> list2 = [1, 2, 3, 4, 5];
        Span<int> list3 = [1, 2, 3, 4, 5];
        int[][] list4 = [[1, 2], [3], [4, 5]];
    }

    /// <summary>
    /// 다양한 유형으로 메서드 매개변수로 직접 전달
    /// </summary>
    public static void Test2()
    {
        Method1([1, 2, 3]);
        Method2([1, 2, 3]);
        Method3([1, 2, 3]);
    }

    /// <summary>
    /// 사용자 유형도 사용 가능
    /// </summary>
    public static void Test3()
    {
        MyType list = [1, 2, 3, 4, 5];
    }

    /// <summary>
    /// Span 유형일 경우 스택에 할당됨 (목록 크기에 따라 컴파일 시 힙에 할당하는 코드로 번역될 수 있음)
    ///
    /// Benchmark 프로젝트 참고
    /// </summary>
    public static void Test4()
    {
        Span<int> list1 = [1, 2, 3, 4, 5];
        list1[0] = 1;
    }

    class MyType : IEnumerable
    {
        private List<int> list = new();

        public IEnumerator GetEnumerator() => list.GetEnumerator();

        public void Add(int value)
        {
            list.Add(value);
        }
    }
}
