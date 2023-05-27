// napisz Program.cs kod, w którym 
/// - zdeklarujesz zmienną z imieniem 
/// - zdeklarujesz zmienną z płcią (dobierz odpowiednią zmienną)
/// - zdklaruje zmienną z wiekiem 
/// - zweryfikujesz dane i wyświetlisz 
/// jeden komunikat : 
/// (1): "Kobieta poniżej 30 lat"
/// (2): "Ewa, lat 33"
/// (3): "Niepełnoletni mężczyzna" 
/// --------------------------
/// (możesz dodać swoje)


string name = "Ewa";
bool isWoman = true;
int age = 33;

if (isWoman == true && age < 30)
{   
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33 && isWoman == true)
{
    Console.WriteLine("Ewa lat 33");
}
else if (isWoman == false && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Brak konta w bazie z takimi danymi");
}