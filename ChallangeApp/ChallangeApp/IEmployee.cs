




// Interfejs w C# służy do definiowania zbioru metod, które klasa musi zaimplementować.
// Interfejs nie zawiera implementacji, a jedynie deklaracje metod. DEFINICJE TEGO CO MA SIĘ ZNALEŹĆ W KLASIE KTÓRA IMPLEMENTUJE TEN INTERFEJS !
// Klasa natomiast zawiera implementacje metod oraz pola i może dziedziczyć po innych klasach.
// JEST TO WZÓR dla klasy który trzeba przestrzegać !! 
// Interfejs CO???   -- nie zawiera żadnej logiki
// Clasa JAK ?? 


namespace ChallangeApp
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        void AddGrade(float grade);

        void AddGrade(int grade);

        void AddGrade(double grade);

        void AddGrade(long grade);

        void AddGrade(string grade);

        void AddGrade(char grade);

        Statistics GetStatistics();

    }
}
