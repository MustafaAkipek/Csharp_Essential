namespace ConsoleApp {

    class Program {
        static void Main(string[] args) {

            var std1 = new Student("1111", "Mustafa AKipek", "6/A");
            var std2 = new Student("2222", "Kadir Akipek", "7/A");
            var std3 = new Student("3333", "Muhammed Akipek", "8/A");

            Student[] students = new Student[3] {std1, std2, std3};

            foreach(var std in students) {
                Console.WriteLine(std.PrintStudentInfo());
            }
        }
    }

    class Student {

        public Student(string studentNo, string studentfullName, string studentClass)
        {
            this.StudentNo = studentNo;
            this.FullName =  studentfullName;
            this.StudentClass = studentClass;
            this.StdId = (new Random()).Next(1111,9999);
        }

        private int StdId { get; set; }
        private string StudentNo { get; set; }

        private string FullName { get; set; }
        private string StudentClass { get; set; }

        public string PrintStudentInfo()
        {
            return $"{this.StudentNo} numbers the student's name is {this.FullName} and the class is {this.StudentClass} and the id is {this.StdId}";
        }
    }
}