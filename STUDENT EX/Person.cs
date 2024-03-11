namespace STUDENT_EX
{
    internal class Person
    {
		protected String name;

		public String Name
		{
			get { return name; }
			set { name = value; }
		}

        protected String mlastname;

        public String MlastName
        {
            get { return mlastname; }
            set { mlastname = value; }
        }

        protected String lastname;

        public String LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        protected DateTime? birthday;

		public DateTime? Birthday
		{
			get { return birthday; }
			set { birthday = value; }
		}


        protected int Age;
		public int age
		{
			get 
            {
                int day;
                int month;
                int age;
                age = (DateTime.Now.Year - birthday.Value.Year);
                month = (DateTime.Now.Month - birthday.Value.Month);
                day = (DateTime.Now.Day - birthday.Value.Day);

                if (month >= 0)
                {
                    if (day < 0)
                    {
                        age--;
                    }
                }
                if (month < 0)
                {
                    age--;
                }
                return age; }
		}
        public Person()
        {
            name = String.Empty;
            lastname = String.Empty;
            mlastname = String.Empty;
            birthday = null;
        }
        public Person(String name,String lastname,String mlastname, DateTime? birthday)
        {
            this.name = name;
            this.lastname = lastname;
            this.mlastname = mlastname;
            this.birthday = birthday;
        }
        public override string ToString()
        {
            return " || Age: " + age;
        }


    }
}
