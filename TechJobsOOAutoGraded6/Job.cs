using System;
namespace TechJobsOOAutoGraded6
{
    public class Job
    {


        public int Id { get; set; }
        private static int nextId = 1;
        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Task 3: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }
      //constructor methods- create and initialize objects of a class
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Task 3: Generate Equals() and GetHashCode() methods.


        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.
        //Assigns Data not available- Assigns value to string
        public override string ToString()
        {
            string idString = Id.ToString();
            string nameString = (Name == null || Name == "") ? "Data not available" : Name;
            string employerString = (EmployerName.Value == null || EmployerName.Value == "") ? "Data not available" : EmployerName.Value;
            string locationString = (EmployerLocation.Value == null || EmployerLocation.Value == "") ? "Data not available" : EmployerLocation.Value;
            string jobTypeString = (JobType.Value == null || JobType.Value == "") ? "Data not available" : JobType.Value;
            string coreCompetencyString = (JobCoreCompetency.Value == null || JobCoreCompetency.Value == "") ? "Data not available" : JobCoreCompetency.Value;

            string result = "\nID: " + idString + "\n";
            result += "Name: " + nameString + "\n";
            result += "Employer: " + employerString + "\n";
            result += "Location: " + locationString + "\n";
            result += "Position Type: " + jobTypeString + "\n";
            result += "Core Competency: " + coreCompetencyString + "\n";
            return result;
        }
        public override bool Equals(object? obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}







