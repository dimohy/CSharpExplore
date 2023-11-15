// See https://aka.ms/new-console-template for more information
using CSharp12;

Console.WriteLine("Hello, C# 12 Explored!");


// 인터셉터 확인
Interceptors.TestCall(); // "오리지널"이 출력되어야 하지만 인터셉터로 인해 "수정됨!"이 출력됨

// UsingAlias.Test();

LambdaOptionalParameters.Test1();