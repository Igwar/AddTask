using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleProject
{
   public class Program
    {
       /// <summary>
       /// list of users
       /// </summary>
        public static List<user> users = new List<user>();
        static void Main(string[] args)
        {
          fileservice.importxml(ref users);
            string userInput = "";
            do
            {
                userInput = DisplayMenu();
            } while (userInput != "exit");
        }
        /// <summary>
        /// show menu options and execute choosen one
        /// </summary>
        /// <returns></returns>
        static public string DisplayMenu()
        {
            Console.WriteLine("File cabinet");
            Console.WriteLine();
            Console.WriteLine("create");
            Console.WriteLine("list");
            Console.WriteLine("stat");
            Console.WriteLine("find");
            Console.WriteLine("edit");
            Console.WriteLine("remove");
            Console.WriteLine("purge");
            Console.WriteLine("export xml");
            Console.WriteLine("export csv");
            Console.WriteLine("import xml");
            Console.WriteLine("import csv");
            Console.WriteLine("exit");
            var result = Console.ReadLine();
            string[] splitedresult= result.Split(' ');
            switch (splitedresult[0]) {
                case "create":
                   users.Create();
                    break;
                case "purge":
                    users.purge();
                    break;
                case "remove":
                    int a = 0;
                    if (!int.TryParse(splitedresult[1], out a))
                    {
                        break;
                    }
                    users.remove(Convert.ToInt32(splitedresult[1]));
                    break;
                case "edit":
                    
                    if (!int.TryParse(splitedresult[1], out a))
                    {
                        break;
                    }
                    users.edit(Convert.ToInt32(splitedresult[1]));
                    break;
                case "list":
                    string formatforshow = "";
                    if (splitedresult.Count() > 1)
                    {
                        for (int i = 0; i < splitedresult.Count(); i++)
                        {
                            if (splitedresult[i] == "firstname")
                            {
                                
                                formatforshow += "F";
                            }
                            if (splitedresult[i] == "lastname")
                            {
                                
                                formatforshow += "L";
                            }
                            if (splitedresult[i] == "dateofbirth")
                            {
                                
                                formatforshow += "D";
                            }
                            if (splitedresult[i] == "id")
                            {

                                formatforshow += "I";
                            }
                        }
                        users.Show(formatforshow);
                    }
                    else
                        users.Show();
                   
                    break;
                case "stat":
                    users.Stat();
                    break;
                case "export":
                    if (splitedresult[1] == "xml")
                        users.exportxml();
                    if (splitedresult[1] == "csv")
                        users.exportcsv();
                        break;
                case "import":
                    if (splitedresult[1] == "xml")
                        fileservice.importxml(ref users);
                    if (splitedresult[1] == "csv")
                        fileservice.importcsv(ref users);
                    break;
#region
                case "find":
                    string param1 = "";
                    string format = "";

                    if (splitedresult.Count() == 3)
                    {
                        
                        for (int i = 0; i < 3; i++)
                        {
                            if (splitedresult[i] == "firstname")
                            {
                                param1 = splitedresult[i + 1];
                                 format = "F";
                            }
                            if (splitedresult[i] == "lastname")
                            {
                                param1 = splitedresult[i + 1];
                                 format = "L";
                            }
                            if (splitedresult[i] == "dateofbirth")
                            {
                                param1 = splitedresult[i + 1];
                                format = "D";
                            }
                        }
                        users.Find(format, param1);

                    }
                    if (splitedresult.Count() == 5)
                    {
                        string firstname = "";
                        string lastname = "";
                        string dateofbirth = "";
                        
                        for (int i = 0; i < 5; i++)
                        {
                            if (splitedresult[i] == "firstname")
                            {
                                firstname = splitedresult[i + 1];
                                format = format+ "F";
                            }
                            if (splitedresult[i] == "lastname")
                            {
                                lastname = splitedresult[i + 1];
                                format =format+ "L";
                            }
                            if (splitedresult[i] == "dateofbirth")
                            {
                                dateofbirth = splitedresult[i + 1];
                                format = format+ "D";
                            }
                        }
                        if (firstname == "")
                        {
                           users.Find(format, lastname,dateofbirth);
                        }
                        if (lastname == "")
                        {
                            users.Find(format, firstname, dateofbirth);
                        }
                        if (dateofbirth == "")
                        {
                            users.Find(format, firstname,lastname);
                        }

                    }
                    if (splitedresult.Count() == 7)
                    {
                        string firstname = "";
                        string lastname = "";
                        string dateofbirth = "";
                       
                        for (int i = 0; i < 7; i++)
                        {
                            if (splitedresult[i] == "firstname")
                            {
                                firstname = splitedresult[i + 1];
                                format = format + "F";
                            }
                            if (splitedresult[i] == "lastname")
                            {
                                lastname = splitedresult[i + 1];
                                format = format + "L";
                            }
                            if (splitedresult[i] == "dateofbirth")
                            {
                                dateofbirth = splitedresult[i + 1];
                                format = format + "D";
                            }
                        }
                        users.Find(firstname, lastname, dateofbirth,format);

                    }


                    break;
#endregion
            }
            return result;
        }


    }
}
