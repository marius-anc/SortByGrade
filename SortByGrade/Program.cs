using System;

namespace SortByGrade
{
    public struct Student
    {
        public string Name;
        public double Grade;

        public Student(string name, double grade)
        {
            this.Name = name;
            this.Grade = grade;
        }
    }

    public class Program
    {
        public static void QuickSort(Student[] students)
        {
            if (students == null)
            {
                throw new ArgumentNullException(nameof(students));
            }

            QuickSortAlg(students, 0, students.Length - 1);
        }

        static void Main()
        {
            Student[] students = ReadStudents();
            QuickSort(students);
            Print(students);
            Console.Read();
        }

        private static void QuickSortAlg(Student[] students, int low, int high)
            {
            if (low >= high)
            {
                return;
            }

            int partitioner = Partioner(students, low, high);
            QuickSortAlg(students, low, partitioner - 1);
            QuickSortAlg(students, partitioner + 1, high);
        }

        private static int Partioner(Student[] students, int low, int high)
        {
            Student pivot = students[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (students[j].Grade > pivot.Grade)
                {
                    i++;
                    Swap(ref students[i], ref students[j]);
                }
            }

            Swap(ref students[i + 1], ref students[high]);
            return i + 1;
        }

        private static void Swap(ref Student student1, ref Student student2)
        {
            Student temp = student1;
            student1 = student2;
            student2 = temp;
        }

        static void Print(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(string.Format("{0}: {1:F2}", students[i].Name, students[i].Grade));
            }
        }

        static Student[] ReadStudents()
        {
            int studentsNumber = Convert.ToInt32(Console.ReadLine());
            Student[] result = new Student[studentsNumber];

            for (int i = 0; i < studentsNumber; i++)
            {
                string[] studentData = Console.ReadLine().Split(':');
                result[i] = new Student(studentData[0], Convert.ToDouble(studentData[1]));
            }

            return result;
        }
    }
}
