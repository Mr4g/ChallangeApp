using System.Reflection.Metadata;
using ChallangeApp;



namespace Challange.App.Tests
{
    public class Tests
    {


        [Test]   // metoda publiczna która jest testem (to oznacza ta etykieta)
        public void WhenUserCollectTwoScores_ShouldCorrectResult()     // OR WhenTwoNumberAreAdded_ShouldReturnSum()
        {
            // arrange - musz¹ byæ przygotowane dane do testu
            var employee = new Employee("£ukasz", "Sambor",  19);
            employee.AddScore(5);
            employee.AddScore(6);

            // act - wykonanie operacji
            var result = employee.Result;


            // assert - sprawdzamy czy warunek zosta³ spe³niony 
            Assert.AreEqual(11, result);

      

        }

        [Test]
        
        public void WhenUserCollectTScoreNegativeSign()
        {
            //arrange 
            var employee = new Employee("Zbigniew", "Nowak", 19);
            employee.AddScore(-5);
            employee.AddScore(-6);
            //act 
            var result=employee.Result;
            //assert 
            Assert.AreEqual(-11, result);   
        }

        [Test]

        public void WhenUserCollectTScoreDifferentSign()
        {
            //arrange 
            var employee = new Employee("Zbigniew", "Nowak", 19);
            employee.AddScore(5);
            employee.AddScore(-6);
            employee.AddScore(-6);
            employee.AddScore(10);
            //act 
            var result = employee.Result;
            //assert 
            Assert.AreEqual(3, result);
        }
    }
}