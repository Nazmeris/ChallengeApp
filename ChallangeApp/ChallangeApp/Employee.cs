﻿namespace ChallangeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        
        public void AddGrade(float grade) 
        { 
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Avarge = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Sum = 0;

            foreach(var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Avarge += grade;
                statistics.Sum += grade;
            }

            statistics.Avarge /= this.grades.Count;


            return statistics;
        }
    }
}