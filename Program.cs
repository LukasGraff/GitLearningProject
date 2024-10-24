Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Hello, World!");
Console.WriteLine("I live in Sweden");
Console.WriteLine("I like pandas");

string text = System.IO.File.ReadAllText("Panda-info.txt");
System.Console.WriteLine($"Here in info from the file 👉 {text}");
