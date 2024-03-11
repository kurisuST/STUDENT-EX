using System.Globalization;

namespace STUDENT_EX
{
    internal class PersonName:Person
    {
		protected String fullName;

		public String FullName
		{
			get 
			{ 
				fullName = name + " " + lastname + " " + mlastname;
				return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(fullName); 
			}
		}
        public override string ToString()
        {
            return " Student Name: " + FullName + base.ToString() + " ";
        }

    }
}
