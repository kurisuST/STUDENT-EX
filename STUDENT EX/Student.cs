namespace STUDENT_EX
{
	internal class Student : PersonName
	{
        protected String id;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        private double grade;

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        private String career;

        public String Career
        {
            get { return career; }
            set { career = value; }
        }


        public Student()
        {
            id = String.Empty;
            grade = 0;
            career = String.Empty;
        }
        public Student(String id, String career, double grade)
        {
            this.id = id;
            this.grade = grade;
            this.career = career;
        }
        public override string ToString()
        {
            return base.ToString()+ " || Student ID: " + id.ToUpper() + " || Grade: " + grade + " || Career: " + career;
        }

    }
}
