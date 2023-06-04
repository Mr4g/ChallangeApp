

using ChallangeApp;

namespace Challange.App.Tests
{
    public class TypeTests
    {
        [Test]

        public void ComparisonOfObjects()
        {
            //arrange 
            var employee1 = GetEmployee("Łukasz");
            var employee2 = GetEmployee("Łukasz");

            //act 
           
            //assert 
            Assert.AreNotEqual(employee1, employee2);  
            
        }


        // prywatna metoda w klasie do tworzenia pracowników
        private Employee GetEmployee(string name)   // korzystając z parametru (string name) 
        {                                           // możemy nadawać różne imiona dla naszego pracownika
            return new Employee(name);              // jeśli nie użylibyśmy parametru metoda cały czas 
                                                    // tworzyła by pracownika o tym samym imieniu
        }

        [Test]

        public void WhenVariablesStringAreEqual()
        {
            //arrange 
            string string1 = "Łukasz";
            string string2 = "Łukasz";

            //act 

            //assert 
            Assert.AreEqual(string1, string2);
        }

        [Test]

        public void WhenVariablesIntAreEqual()
        {
            //arrange 
            int number1 = 2;
            int number2 = 2;

            //act 

            //assert 
            Assert.AreEqual(number1, number2);
        }

        [Test]

        public void WhenVariablesFloatAreNotEqual()
        {
            //arrange 
            float float1 = 2.2f;
            float float2 = 2.1f;

            //act 

            //assert 
            Assert.AreNotEqual(float1, float2);
        }








    }
}
