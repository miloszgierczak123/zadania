// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;

Console.WriteLine("Podaj ścieżkę pliku tekstowego: ");
string sciezka = Console.ReadLine();
string tekst = File.ReadAllText(@sciezka);
string zmienionyTekst = tekst.Replace("praca", "job");
Console.WriteLine(zmienionyTekst);
DateTime dzisiaj = DateTime.Now;
string data = dzisiaj.ToString("yyyyMMdd");
File.WriteAllTextAsync(sciezka + "_changed" + data + ".txt", zmienionyTekst);
