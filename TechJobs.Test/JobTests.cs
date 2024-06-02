
using System.Reflection.Metadata.Ecma335;


namespace TechJobs.Tests
{
    [TestClass]
    public class JobTests
    {
        //Testing Objects
        //initalize your testing objects here
        //Testing objects
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        Job job5 = new Job("Product tester", new Employer(""), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));


        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreNotEqual(job1.Id, job2.Id, "ID values for two Job objects should not be the same.");
            // Testing incrementing amount
            Assert.AreEqual(job1.Id + 1, job2.Id, "ID values for subsequent Job objects should differ by 1.");
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name, "Name field is  set correctly.");
            Assert.AreEqual("ACME", job3.EmployerName.Value, "EmployerName field is set correctly.");
            Assert.AreEqual("Desert", job3.EmployerLocation.Value, "EmployerLocation field is  set correctly.");
            Assert.AreEqual("Quality control", job3.JobType.Value, "JobType field is set correctly.");
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.Value, "JobCoreCompetency field is  set correctly.");
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job1.Equals(job2), "Equals() method should return false for two Job objects with different IDs.");
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.IsTrue(job3.ToString().StartsWith("\n"), "ToString() does not start with a new line.");
            Assert.IsTrue(job3.ToString().EndsWith("\n"), "ToString() does not end with a new line.");
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            // Expected output format
            string expected = "\nID: " + job3.Id +
                              "\nName: Product tester" +
                              "\nEmployer: ACME" +
                              "\nLocation: Desert" +
                              "\nPosition Type: Quality control" +
                              "\nCore Competency: Persistence\n";

            Assert.AreEqual(expected, job3.ToString(), "ToString() does not contain correct labels and data.");
        }

        
        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {            
            // Expected output format with empty fields
            string expected = "\nID: " + job5.Id +
                              "\nName: Product tester" +
                              "\nEmployer: Data not available" +
                              "\nLocation: Desert" +
                              "\nPosition Type: Quality control" +
                              "\nCore Competency: Persistence\n";
            Assert.AreEqual(expected, job5.ToString(), "ToString() does not handle empty fields correctly.");
        }


    }


}

