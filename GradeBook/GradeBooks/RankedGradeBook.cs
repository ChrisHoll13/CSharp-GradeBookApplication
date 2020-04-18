﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
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
    }
}
