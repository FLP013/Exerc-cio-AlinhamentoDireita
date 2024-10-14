string Palavra1, Palavra2, Palavra3;

Console.Clear();

Console.WriteLine("--- ALINHAMENTA À DIREITA ---");

Console.Write("Digite a primeira palavra: ");
Palavra1 = Console.ReadLine()!;

Console.Write("Digite a segunda palavra: ");
Palavra2 = Console.ReadLine()!;

Console.Write("Digite a terceira palavra: ");
Palavra3 = Console.ReadLine()!;
Console.WriteLine();

Console.WriteLine($"{Palavra1.PadLeft(15)}\n{Palavra2.PadLeft(15)}\n {Palavra3.PadLeft(15)}");