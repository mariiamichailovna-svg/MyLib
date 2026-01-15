using MyLib;

Console.WriteLine("=== Demo MyLib ===");

Console.WriteLine($"Add(3,4) = {MathTools.Add(3, 4)}");
Console.WriteLine($"Sub(3,4) = {MathTools.Sub(3, 4)}");
Console.WriteLine($"Mul(3,4) = {MathTools.Mul(3, 4)}");

var text = "hello world";
Console.WriteLine($"Reverse(\"{text}\") = {StringTools.Reverse(text)}");
Console.WriteLine($"WordCount(\"one  two   three\") = {StringTools.WordCount("one  two   three")}");
