using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG252_Project_Joshua_Simanga_Mieke
{
    class FileHandler
    {
        string fileName = @"LoginCredentials.txt";

        public void Write( string username, string password)
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine($"{username}|{password}");
                sw.Close();
                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream(fileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine($"{username}|{password}");
                sw.Close();
                fs.Close();
            }

        }
        // same here can you add the the sudent class where ever theirs Syntax error
        public List<StudentCredentials> ReadCredentials()
        {
            List<StudentCredentials> readList = new List<StudentCredentials>();
            using (StreamReader sr=new StreamReader(fileName))
            {
                string holder;
                while ((holder=sr.ReadLine())!=null)
                {
                    string[] splitHolder = holder.Split('|');
                    StudentCredentials sc = new StudentCredentials(splitHolder[0], splitHolder[1]);
                    readList.Add(sc);
                }
            }
            return readList;
        }
    }
}
