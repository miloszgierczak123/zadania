// See https://aka.ms/new-console-template for more information

string slowo = File.ReadAllText(@"D:\test_mil_gie.txt");
int count = 0;

foreach (char x in slowo)
{
    if (x == 'a')
    {
        count++;
    }
}

Console.WriteLine("Litera a występuje w pliku " + count + " razy.");

