using System;

namespace TechJobsOOAutoGraded6
{
    // Define the abstract JobField class
    public abstract class JobField
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get;set; }

        // Common constructor
        public JobField(string value)
        {
            Id = nextId;
            nextId++;
            Value = value;
        }

        // Override Equals and GetHashCode methods
        public override bool Equals(object obj)
        {
            return obj is JobField field &&
                   Id == field.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // Override ToString method
        public override string ToString()
        {
            return Value;
        }
    }
}