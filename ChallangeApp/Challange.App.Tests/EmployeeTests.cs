using System.Reflection.Metadata;
using ChallangeApp;



namespace Challange.App.Tests
{
    public class Tests
    {


        [Test]
        public void MaxValueMethodGetStatistic()
        {
            // arrange - musz¹ byæ przygotowane dane do testu
            var employee = new Employee("£ukasz", "Sambor");
            employee.AddGrade(5);
            employee.AddGrade(2);
            employee.AddGrade(4);
            employee.AddGrade(10);

            // act - wykonanie operacji
            var statistisc = employee.GetStatistics();


            // assert - sprawdzamy czy warunek zosta³ spe³niony 
            Assert.AreEqual(10, statistisc.Max);


        }


        [Test]
        public void MinValueMethodGetStatistic()
        {
            // arrange - musz¹ byæ przygotowane dane do testu
            var employee = new Employee("£ukasz", "Sambor");
            employee.AddGrade(5);
            employee.AddGrade(2);
            employee.AddGrade(4);
            employee.AddGrade(10);

            // act - wykonanie operacji
            var statistisc = employee.GetStatistics();


            // assert - sprawdzamy czy warunek zosta³ spe³niony 
            Assert.AreEqual(2, statistisc.Min);


        }

        [Test]
        public void AverageValueMethodGetStatistic()
        {
            // arrange - musz¹ byæ przygotowane dane do testu
            var employee = new Employee("£ukasz", "Sambor");
            employee.AddGrade(5);
            employee.AddGrade(2);
            employee.AddGrade(4);
            employee.AddGrade(10);

            // act - wykonanie operacji
            var statistisc = employee.GetStatistics();


            // assert - sprawdzamy czy warunek zosta³ spe³niony 
            Assert.AreEqual(5.25, statistisc.Average);


        }

    }
}