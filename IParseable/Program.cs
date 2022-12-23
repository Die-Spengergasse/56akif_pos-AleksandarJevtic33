using IParseable;

int i = int.Parse("1234");
Console.WriteLine(i);
int j = 0;
if (int.TryParse("1234", out j))
{
    Console.Error.WriteLine("geht nich");
}

Person p = "Martin,Schrutek,13.05.1977".Parse<Person>();

int words = "Hello World! Lorem ipsum wahatever.".CountWords();

Console.WriteLine(p);