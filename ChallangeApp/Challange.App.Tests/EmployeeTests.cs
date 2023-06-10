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
            Assert.AreEqual(Math.Round(5.25, 2), Math.Round(statistisc.Average, 2));


        }

        [Test]
        public void WhenEmployeeGetGradesShouldReturnCorrectMaxValue()
        {
            // arrange - musz¹ byæ przygotowane dane do testu
            var employee = new Employee("£ukasz", "Sambor");
            employee.AddGrade("c");
            employee.AddGrade('b');
            employee.AddGrade(2f);
            employee.AddGrade(111);

            // act - wykonanie operacji
            var statistisc = employee.GetStatistics();


            // assert - sprawdzamy czy warunek zosta³ spe³niony 
            Assert.AreEqual(80, statistisc.Max);


        }

        public void WhenEmployeeGetGradesShouldReturnCorretResultInLatter()
        {
            // arrange - musz¹ byæ przygotowane dane do testu
            var employee = new Employee("£ukasz", "Sambor");
            employee.AddGrade(100);
            employee.AddGrade(90);
            employee.AddGrade('b');

            // act - wykonanie operacji
            var statistisc = employee.GetStatistics();


            // assert - sprawdzamy czy warunek zosta³ spe³niony 
            Assert.AreEqual('A', statistisc.AverageLetter);

        }
    }
}