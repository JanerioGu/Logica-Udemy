List<String> list = new List<string>();

List<String> List2 = new List<string> {"Maria", "joao", "José" };


List2.Add("Joãoo");
List2.Add("Ana");
List2.Add("erica");
List2.Add("Janerio");
List2.Add("matheus");

List2.Insert(2, "JOSÉEEE");


foreach (string a in List2)
{
    Console.WriteLine($"{a}");
}

Console.WriteLine($"Tamanho lista é { List2.Count}");

string s1 = List2.Find(x => x[0] == 'A');
Console.WriteLine($"{s1}");

string s2 = List2.FindLast(X => X[0] == 'A');
Console.WriteLine($"{s2}");

Console.WriteLine("-------------------------------------------");

List<String> listParaComparar = List2.FindAll(x => x.Length == 5);
foreach (string a in listParaComparar)
{
    Console.WriteLine($"{a}");
}