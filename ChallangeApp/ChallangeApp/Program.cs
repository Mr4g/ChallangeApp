/* Przygotuj program, który policzy ile jakich cyfr 
wystepuje w podanej liczbie:

Przykład : 
Wynniki dla liczby 4566 
0 => 0 
1 => 0 
2 => 0
3 => 0
4 => 1
5 => 1
6 => 2 
7 => 0
8 => 0
9 => 0         */


// zdefiniowanie int 
int number = 1230456789;
// zamiana int na string z wykorzystaniem metody .ToString();
string numebrInString = number.ToString();
// wykonanie tablicy charów metodą .ToArray
char[] letters = numebrInString.ToArray();

var numer0 = 0;
var numer1 = 0;
var numer2 = 0;
var numer3 = 0; 
var numer4 = 0;
var numer5 = 0;
var numer6 = 0;
var numer7 = 0;
var numer8 = 0;
var numer9 = 0;


foreach (char letter in letters)

{


    if (letter == '0')
    {
        numer0++;
    }
    else if (letter == '1')
    {
        numer1++;
    }
    else if (letter == '2')
    {
        numer2++;
    }
    else if (letter == '3') 
    {
        numer3++;
    }
    else if (letter == '4')
    {
        numer4++;
    }
    else if (letter == '5')
    {
        numer5++;
    }
    else if (letter == '6')
    {
        numer6++;
    }
    else if (letter == '7')
    {
        numer7++;
    }
    else if (letter == '8')
    {
        numer8++;
    }
    else if (letter == '9')
    {
        numer9++;
    }

}

Console.WriteLine("0 => " + numer0);
Console.WriteLine("1 => " + numer1);
Console.WriteLine("2 => " + numer2);
Console.WriteLine("3 => " + numer3);
Console.WriteLine("4 => " + numer4);
Console.WriteLine("5 => " + numer5);
Console.WriteLine("6 => " + numer6);
Console.WriteLine("7 => " + numer7);
Console.WriteLine("8 => " + numer8);
Console.WriteLine("9 => " + numer9);
