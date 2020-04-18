using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        
        public RankedGradeBook(string name, bool isWeighted) : base(name,isWeighted)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count >= 5)
            {
                switch (averageGrade)
                {
                    case var g when g >= 80:
                        return 'A';
                    case var g when g >= 60:
                        return 'B';
                    case var g when g >= 40:
                        return 'C';
                    case var g when g >= 20:
                        return 'D';
                    default:
                        return 'F';
                }
            }
            else
            {
                throw new InvalidOperationException();
            }

        }

        public override void CalculateStatistics()
        {
            if (Students.Count >=5)
	            {
                base.CalculateStatistics();
	            }
            else
	            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
	            }
        }
        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count >= 5)
            {
                base.CalculateStudentStatistics(name);
            }
            else
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
            }
        }
    }
}
