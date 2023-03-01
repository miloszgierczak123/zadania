string[] imiona = { "Ania", "Kasia", "Basia", "Zosia"};
string[] nazwiska = { "Kowalska", "Nowak" };
string[] lata = { "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000" };
Random random = new Random();
Console.WriteLine("LP   Imię   Nazwisko   Rok urodzenia");
string[] dane = new string[101];
DateTime dzisiaj = DateTime.Now;
string data = dzisiaj.ToString("yyyy_MM_dd_HH_mm");
StreamWriter sw = new StreamWriter("D:\\users-" + data + ".txt");
sw.WriteLine("LP   Imię   Nazwisko   Rok urodzenia");
for (int LP = 0; LP < dane.Length; LP++)
{
    sw.Write(LP + ", ");
    sw.Write(imiona[random.Next(imiona.Length)] + ", ");
    sw.Write(nazwiska[random.Next(nazwiska.Length)] + ", ");
    sw.WriteLine(lata[random.Next(lata.Length)]);

string imie = imiona[random.Next(imiona.Length)];
    string nazwisko = nazwiska[random.Next(nazwiska.Length)];
    dane[LP] = $"{imie},{nazwisko}";
    Console.WriteLine(LP+ " " + imie + " " + nazwisko);
}
sw.Close();