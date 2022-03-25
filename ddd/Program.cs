// See https://aka.ms/new-console-template for more information

// Super gierka pod tytułem - "Zgadnij wylosowaną cyfrę!"

Random r = new Random();
int cyfra = r.Next(1, 10); //zakres losowanych cyfer
int odpowiedz;
bool wygrana = true;

Console.WriteLine("Właśnie rozpocząłeś grę, której celem jest odgadnięcie wylosowanej cyfry!");
Console.WriteLine("Już zdążyłem za Ciebie wylosować cyfrę, a teraz musisz ją odgadnąć!");
Console.WriteLine("Wprowadź cyfrę w przedziale od 1 do 10");
Console.WriteLine("W przypadku gdy nie uda Ci się odgadnąć, dostaniesz małą podpowiedź...");

while (wygrana)
{
    string read = Console.ReadLine(); // Odpowiada za wprowadzanie cyfer, oraz ich odczyt w konsoli
    bool losowanie = int.TryParse(read, out odpowiedz);
    if (losowanie)
    {

        if (odpowiedz > cyfra) // Wprowadzona odpowiedz jest niższa niż wylosowana cyfra
            Console.WriteLine("Niestety, wylosowana cyfra jest niższa niż wprowadzona!");

        else if (odpowiedz < cyfra) // Wprowadzona odpowiedz jest wyższa niż wylosowana cyfra
            Console.WriteLine("Niestety, wylosowana cyfra jest wyższa niż wprowadzona!");
        else
        {
            Console.WriteLine("Udało Ci się odgadnąć cyfrę!");
            break;
        }

    }

}