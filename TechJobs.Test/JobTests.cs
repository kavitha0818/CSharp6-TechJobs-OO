
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
            Job job1 = new Job();
            Job job2 = new Job();

            Assert.IsFalse(job1.Equals(job2), "Equals() method should return false for two Job objects with different IDs.");
        }

    }


}

