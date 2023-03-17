//postac ogolna rownania kwadratowego: ax^2 + bx +c
//delta (wzor) b^2 - 4 * a * c
//pierwiastki x0 = -b / 2a, x1 = (-b - sqrt(delta)) / (2 * a), x2 = (-b + sqrt(delta)) / (2* a)

//ewentualnie duble
float a, b, c, delta, pierwDelta, x0, x1, x2;
//bufor dla konsoli
string buffer;

Console.WriteLine("Podaj parametry równania kwadratowego w postaci ax^2 + bx + c:");
Console.WriteLine("Podaj a:");
buffer = Console.ReadLine() ?? "0";
a = float.Parse(buffer);


Console.WriteLine("Podaj b:");
buffer = Console.ReadLine() ?? "0";
b= float.Parse(buffer);


Console.WriteLine("Podaj c:");
buffer = Console.ReadLine() ?? "0";
c = float.Parse(buffer);

//liczymy delte
//MathF dlatego ze Math zwraca duble a nie float
delta = MathF.Pow(b, 2) - 4 * a * c;

//trzy mozliwe przypadki
//jezeli zdanie logiczne w nawiasie jest prawdziwe to wykonaj blok kodu
if(delta >0)
{
    //liczymy pierwiastek z delty
    //sqrt  - square root - pierwiastek kwadratowy
    pierwDelta = MathF.Sqrt(delta);
    //delta wieksza od zera - dwa miejsca zerowe
    x1 = (-b - pierwDelta) / (2 * a);
    x2 = (-b + pierwDelta) / (2 * a);
    //wypisujemy wynik - zastosuj funkcje ToString() aby zamienic liczbe na tekst
    Console.WriteLine("Miejsca zerowe tego równania wynoszą x1: " + x1.ToString() + " x2: " + x2.ToString());
}
else if(delta == 0)
{
    //delta rowna zero
    x0 = -b / (2 * a); 
    Console.WriteLine("Miejsce zerowe wynosi 0: ")
}
else
{
    //delta mniejsza od zera
    Console.WriteLine("Brak rozwiązania");
}
