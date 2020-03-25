using System;
using Xunit;

namespace SortByGrade.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void QuickSortWorksWhenArrayIsSorted()
        {
            Student[] studentsToSort = {new Student("Ana", 10), new Student("George", 9.99), new Student("Adi", 9.90), new Student("Vasile", 9.59), };
            Student[] students = { new Student("Ana", 10), new Student("George", 9.99), new Student("Adi", 9.90), new Student("Vasile", 9.59), };
            Program.QuickSort(studentsToSort);
            Assert.Equal<Student>(studentsToSort, students);
        }

        [Fact]
        public void QuickSortWorksWithUnsortedArray()
        {
            Student[] studentsToSort = { new Student("Adi", 9.90), new Student("Vasile", 9.59), new Student("Ana", 10), new Student("George", 9.99) };
            Student[] students = { new Student("Ana", 10), new Student("George", 9.99), new Student("Adi", 9.90), new Student("Vasile", 9.59), };
            Program.QuickSort(studentsToSort);
            Assert.Equal<Student>(studentsToSort, students);
        }
    }
}
