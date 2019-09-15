using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleProject
{/// <summary>
/// Class for works with files
/// </summary>
   public static class fileservice
    {/// <summary>
    /// write list of users to xml file
    /// </summary>
    /// <param name="users">list of users</param>
        public static void exportxml(this List<user> users)
        {
            string output = "D:\\output.xml";



            XmlSerializer serialiser = new XmlSerializer(typeof(List<user>));
            TextWriter FileStream = new StreamWriter(output);
            serialiser.Serialize(FileStream, users);
            FileStream.Close();


        }
        /// <summary>
        ///  read list from xml file
        /// </summary>
        /// <param name="users">list of users</param>
        public static void importxml(ref   List<user> users)
        {
            string output = "D:\\output.xml";
            if (File.Exists(output))
            {
                XmlSerializer serialiser = new XmlSerializer(typeof(List<user>));

                StreamReader FileStream = new StreamReader(output);


                users = (List<user>)serialiser.Deserialize(FileStream);
                FileStream.Close();
            }
        }
        /// <summary>
        ///  write list of users to csv file
        /// </summary>
        /// <param name="users">list of users</param>
        public static void exportcsv(this List<user> users)
        {
            string output = "D:\\output.csv";
            var writer = new StreamWriter(output);



            foreach (var items in users)
            {


                writer.WriteLine(items.FirstName + "," + items.LastName + "," + items.Dateofbirth);

            }
            writer.Close();
        }
        /// <summary>
        /// read list from csv file
        /// </summary>
        /// <param name="users">list of users</param>
        public static void importcsv(ref List<user> users)
        {
            string output = "D:\\output.csv";
            if (File.Exists(output)) { 
                var reader = new StreamReader(output);
                while (!reader.EndOfStream)
                {
                    string buf = reader.ReadLine();
                    string[] bufarr = buf.Split(',');
                    user user = new user();
                    user.FirstName = bufarr[0];
                    user.LastName = bufarr[1];
                    user.Dateofbirth = bufarr[2];
                    users.Add(user);
                }
            }

        }
    }
}
