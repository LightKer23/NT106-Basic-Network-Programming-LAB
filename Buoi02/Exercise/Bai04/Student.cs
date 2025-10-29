using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Bai04
{
    public class Student
    {
        public string FullName { get; set; }
        public int ID { get; set; }
        public string Phone { get; set; }
        public float Score1 { get; set; }
        public float Score2 { get; set; }
        public float Score3 { get; set; }
        public float Average { get; set; }

        public Student() 
        {
            FullName = string.Empty;
            ID = 0;
            Phone = string.Empty;
            Score1 = 0;
            Score2 = 0;
            Score3 = 0;
            Average = 0;
        }

        public Student(string fullName, int id, string phone, float score1, float score2, float score3)
        {
            FullName = fullName;
            ID = id;
            Phone = phone;
            Score1 = score1;
            Score2 = score2;
            Score3 = score3;
            Average = 0;
        }

        public void CalculateAverage()
        {
            Average = (Score1 + Score2 + Score3) / 3;
        }

        public override string ToString()
        {
            return $"{FullName},{ID},{Phone},{Score1},{Score2},{Score3},{Average:F2}";
        }

        public static Student? FromString(string line)
        {
            var parts = line.Split(',');
            if (parts.Length >= 6)
            {
                var student = new Student
                {
                    FullName = parts[0].Trim(),
                    ID = int.Parse(parts[1].Trim()),
                    Phone = parts[2].Trim(),
                    Score1 = float.Parse(parts[3].Trim()),
                    Score2 = float.Parse(parts[4].Trim()),
                    Score3 = float.Parse(parts[5].Trim())
                };

                if (parts.Length >= 7)
                {
                    student.Average = float.Parse(parts[6].Trim());
                }

                return student;
            }
            return null;
        }
    }
}
