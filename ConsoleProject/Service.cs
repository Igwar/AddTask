using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    
    public static class Service
    {
        /// <summary>
        /// Show all users in standart format
        /// </summary>
        /// <param name="users">list of users</param>
        public static void Show(this List<user> users)
        {
            int i = 1;
            foreach (var a in users)
            {
                Console.WriteLine("#" + i + " " + a.FirstName + " " + a.LastName);
                i++;
            }
        }
        /// <summary>
        /// Show all users in different formats
        /// </summary>
        /// <param name="users">list of users</param>
        /// <param name="format">format of output</param>
        public static void Show(this List<user> users, string format)
        {
            string result = "";
            int i = 1;
            foreach (var a in users)
            {
                foreach (var b in format)
                {

                    if (b == 'F')
                        result += a.FirstName + " ";
                    if (b == 'L')
                        result += a.LastName + " ";
                    if (b == 'D')
                        result += a.Dateofbirth + " ";
                    if (b == 'I')
                        result += "#" + i + " ";

                }
                Console.WriteLine(result);
                result = "";
                i++;
            }
        }
        /// <summary>
        /// create new user and add it to list
        /// </summary>
        /// <param name="users">list of users</param>
        public static void Create(this List<user> users)
        {
            user user = new user();
            Console.WriteLine("Enter First Name :");
            user.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name :");
            user.LastName = Console.ReadLine();
            Console.WriteLine("Date of birth :");
            user.Dateofbirth = Console.ReadLine();
            users.Add(user);
            users.exportxml();
        }
        /// <summary>
        /// find user from list by 1 params
        /// </summary>
        /// <param name="users">list of users</param>
        /// <param name="format">show type of param1</param>
        /// <param name="param1">key word for search</param>
        public static void Find(this List<user> users,string format, string param1)
        {
            int i = 1;
            switch (format)
            {

                case "F":

                    foreach (var a in users)
                    {
                        if (a.FirstName == param1)
                        {
                            Console.WriteLine("#" + i + " " + a.FirstName + " " + a.LastName);
                            i++;
                        }
                    }
                    break;
                case "L":

                    foreach (var a in users)
                    {
                        if (a.LastName == param1)
                        {
                            Console.WriteLine("#" + i + " " + a.FirstName + " " + a.LastName);
                            i++;
                        }
                    }
                    break;
                case "D":

                    foreach (var a in users)
                    {
                        if (a.Dateofbirth == param1)
                        {
                            Console.WriteLine("#" + i + " " + a.FirstName + " " + a.LastName);
                            i++;
                        }
                    }
                    break;
            }
        }
        /// <summary>
        /// find user from list by 2 params
        /// </summary>
        /// <param name="users">list of users</param>
        /// <param name="format">show type of param1 and param2</param>
        /// <param name="param1">first key word for search</param>
        /// <param name="param2">second key word for search</param>
        public static void Find(this List<user> users,string format, string param1, string param2)
        {
            int i = 1;
            switch (format)
            {

                case "FL":

                    foreach (var a in users)
                    {
                        if ((a.FirstName == param1) && (a.LastName == param2))
                        {
                            Console.WriteLine("#" + i + " " + a.FirstName + " " + a.LastName);
                            i++;
                        }
                    }
                    break;
                case "LF":

                    foreach (var a in users)
                    {
                        if ((a.FirstName == param1) && (a.LastName == param2))
                        {
                            Console.WriteLine("#" + i + " " + a.FirstName + " " + a.LastName);
                            i++;
                        }
                    }
                    break;
                case "FD":

                    foreach (var a in users)
                    {
                        if ((a.FirstName == param1) && (a.Dateofbirth == param2))
                        {
                            Console.WriteLine("#" + i + " " + a.FirstName + " " + a.LastName);
                            i++;
                        }
                    }
                    break;
                case "DF":

                    foreach (var a in users)
                    {
                        if ((a.FirstName == param1) && (a.Dateofbirth == param2))
                        {
                            Console.WriteLine("#" + i + " " + a.FirstName + " " + a.LastName);
                            i++;
                        }
                    }
                    break;
                case "LD":

                    foreach (var a in users)
                    {
                        if ((a.LastName == param1) && (a.Dateofbirth == param2))
                        {
                            Console.WriteLine("#" + i + " " + a.FirstName + " " + a.LastName);
                            i++;
                        }
                    }
                    break;
                case "DL":

                    foreach (var a in users)
                    {
                        if ((a.LastName == param1) && (a.Dateofbirth == param2))
                        {
                            Console.WriteLine("#" + i + " " + a.FirstName + " " + a.LastName);
                            i++;
                        }
                    }
                    break;
            }
        }
        /// <summary>
        /// ind user from list by 3 params
        /// </summary>
        /// <param name="users">list of users</param>
        /// <param name="param1">first key word for search</param>
        /// <param name="param2">second key word for search</param>
        /// <param name="param3">third key word for search</param>
        /// <param name="format">show type of param2,param2 and param3</param>
        public static void Find(this List<user> users,string param1, string param2, string param3, string format = "")
        {
            int i = 1;




            foreach (var a in users)
            {
                if ((a.FirstName == param1) && (a.LastName == param2) && (a.Dateofbirth == param3))
                {
                    Console.WriteLine("#" + i + " " + a.FirstName + " " + a.LastName);
                    i++;
                }
            }

        }
        /// <summary>
        /// edit user from list 
        /// </summary>
        /// <param name="users">list of users</param>
        /// <param name="num">id of user in list</param>
        public static void edit(this List<user> users,int num)
        {
            if (num - 1 > users.Count)
            {
                return;
            }
            if (num < 1)
            {
                return;
            }
            Console.WriteLine("Enter First Name :");
            users[num - 1].FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name :");
            users[num - 1].LastName = Console.ReadLine();
            Console.WriteLine("Date of birth :");
            users[num - 1].Dateofbirth = Console.ReadLine();

            users.exportxml();

        }
        /// <summary>
        /// show amounts of users in list
        /// </summary>
        /// <param name="users">list of users</param>
        public static void Stat(this List<user> users)
        {
            Console.WriteLine(users.Count + " " + "records");
        }
        /// <summary>
        /// delete user from list
        /// </summary>
        /// <param name="users">list of users</param>
        /// <param name="num">id of user in list</param>
        public static void remove(this List<user> users,int num)
        {
            if (num > users.Count)
            {
                return;
            }
            if (num < 1)
            {
                return;
            }
            users.Remove(users[num - 1]);
            users.exportxml();
        }
        /// <summary>
        /// clean list of users
        /// </summary>
        /// <param name="users"></param>
        public static void purge(this List<user> users)
        {
            users.Clear();
        }
    }
}
