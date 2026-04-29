using System;

namespace StudentRegistryApp
{
    public class Student
    {
        private static int _globalIdGenerator = 0;
        public int RegistrationNumber { get; private set; }
        public string FullName { get; set; }
        public string Department { get; set; }
        private double _score;

        public double AcademicPerformance
        {
            get { return _score; }
            set
            {
                if (value >= 0.0 && value <= 4.0) _score = value;
                else throw new Exception("GPA must be between 0.0 and 4.0");
            }
        }

        public Student(string studentName, double averageGrade, string facultyName)
        {
            this.RegistrationNumber = ++_globalIdGenerator;
            this.FullName = studentName;
            this.AcademicPerformance = averageGrade;
            this.Department = facultyName;
        }

        public string DisplayDetails()
        {
            return "ID: " + RegistrationNumber + " | Name: " + FullName + " | GPA: " + _score.ToString("0.00") + " | Faculty: " + Department;
        }
    }

    public class UniversityRegistry
    {
        private Student[] _storage = new Student[100];
        private int _totalStudents = 0;

        public void RegisterStudent(Student person)
        {
            if (_totalStudents < 100) _storage[_totalStudents++] = person;
            else Console.WriteLine("Registry is full");
        }

        public Student SearchById(int targetId)
        {
            for (int i = 0; i < _totalStudents; i++)
                if (_storage[i].RegistrationNumber == targetId) return _storage[i];
            return null;
        }

        public Student[] SearchByName(string targetName)
        {
            int matchesFound = 0;
            string searchKey = targetName.ToLower();

            for (int i = 0; i < _totalStudents; i++)
                if (_storage[i].FullName.ToLower() == searchKey) matchesFound++;

            Student[] resultSet = new Student[matchesFound];
            int currentPos = 0;
            for (int i = 0; i < _totalStudents; i++)
                if (_storage[i].FullName.ToLower() == searchKey) resultSet[currentPos++] = _storage[i];

            return resultSet;
        }

        public Student[] GetBestPerformers(int limit)
        {
            int quantity = (limit > _totalStudents) ? _totalStudents : limit;
            if (quantity <= 0) return new Student[0];

            Student[] temporaryList = new Student[_totalStudents];
            for (int i = 0; i < _totalStudents; i++) temporaryList[i] = _storage[i];

            // Сортировка пузырьком
            for (int i = 0; i < _totalStudents - 1; i++)
            {
                for (int j = 0; j < _totalStudents - i - 1; j++)
                {
                    if (temporaryList[j].AcademicPerformance < temporaryList[j + 1].AcademicPerformance)
                    {
                        Student swapVar = temporaryList[j];
                        temporaryList[j] = temporaryList[j + 1];
                        temporaryList[j + 1] = swapVar;
                    }
                }
            }

            Student[] finalTop = new Student[quantity];
            for (int k = 0; k < quantity; k++) finalTop[k] = temporaryList[k];
            return finalTop;
        }

        public void ShowDatabase()
        {
            for (int i = 0; i < _totalStudents; i++) Console.WriteLine(_storage[i].DisplayDetails());
        }
    }

    class Program
    {
        static void Main()
        {
            UniversityRegistry manager = new UniversityRegistry();
            while (true)
            {
                Console.Write("1.Add Student | 2.Find by ID | 3.Find by Name | 4.Top Students | 5.Show All | 6.Exit | Choose action: ");
                string choice = Console.ReadLine();
                if (choice == "6") break;

                try
                {
                    if (choice == "1")
                    {
                        Console.Write("Enter Name: "); string inputName = Console.ReadLine();
                        Console.Write("Enter GPA: "); double inputGpa = double.Parse(Console.ReadLine());
                        Console.Write("Enter Faculty: "); string inputFaculty = Console.ReadLine();
                        manager.RegisterStudent(new Student(inputName, inputGpa, inputFaculty));
                    }
                    else if (choice == "2")
                    {
                        Console.Write("Enter Student ID: ");
                        Student found = manager.SearchById(int.Parse(Console.ReadLine()));
                        Console.WriteLine(found != null ? found.DisplayDetails() : "Student not found");
                    }
                    else if (choice == "3")
                    {
                        Console.Write("Enter Name to search: ");
                        Student[] matches = manager.SearchByName(Console.ReadLine());
                        foreach (var item in matches) Console.WriteLine(item.DisplayDetails());
                    }
                    else if (choice == "4")
                    {
                        Console.Write("How many top students? ");
                        Student[] leaders = manager.GetBestPerformers(int.Parse(Console.ReadLine()));
                        foreach (var leader in leaders) Console.WriteLine(leader.DisplayDetails());
                    }
                    else if (choice == "5")
                    {
                        manager.ShowDatabase();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("System Error: " + ex.Message);
                }
            }
        }
    }
}
