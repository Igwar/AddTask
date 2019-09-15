using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class user
    {
        private string firstName;
        public string FirstName
        {
            get
            {

                return firstName;
            }
            set
            {
                while (value.Any(char.IsDigit)||value[0].ToString()!=value[0].ToString().ToUpper())
                {
                    Console.WriteLine("incorrect name");
                    value = Console.ReadLine();

                }
                firstName = value;
            }
        }
        private string lasttName;
        public string LastName
          {
            get
            {

                return lasttName;
            }
    set
            {
                while (value.Any(char.IsDigit)||value[0].ToString()!=value[0].ToString().ToUpper())
                {
                    Console.WriteLine("incorrect name");
                    value = Console.ReadLine();

                }
                lasttName = value;
            }
        }
        private string dateofbirth;
        public string Dateofbirth
        {
            get
            {
                
                return dateofbirth;
            }
            set
            {
                DateTime date;
                while (!DateTime.TryParse(value, out date))
                {
                    Console.WriteLine("incorrect date");
                    value = Console.ReadLine();

                }
                dateofbirth = value;
            }
        }

    }
}
