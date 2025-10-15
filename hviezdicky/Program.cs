//string i = ("*");
//Console.WriteLine(i);
//while (i.Length < 5)
//{
//    i = (i + "*");
//    Console.WriteLine(i);
//}
//i = ("**");
//Console.WriteLine(i);
//while (i.Length < 5)
//{
//    i = (i + "*");
//    Console.WriteLine(i);
//}




string i = ("77");
Console.WriteLine(i);
while (int.Parse(i) < 88)
{ 
    i=(int.Parse(i) + 1).ToString();
    Console.WriteLine(i);
}
int[] numbers = new int[10] { 11, 50, 48, 49, 6, 5, 7, 1, 18, 11 };

int vysledok = 0;
for (int i = 0; i < numbers.Length; i++)
{
    vysledok += numbers[i];
}
Console.WriteLine(vysledok);




