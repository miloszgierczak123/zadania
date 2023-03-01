// See https://aka.ms/new-console-template for more information

Console.Write("Podaj kwotę w złotówkach: ");
double kwota = Convert.ToDouble(Console.ReadLine());
double kurs = 4.41;
double wynik = kurs * kwota;
Console.WriteLine("Oto kwota przekonwertowana na dolary: " + wynik);
