using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rock_Paper_Scissors
{
    public abstract class Pick
    {
        public int value;
        public string name;
        public int score;



        // public int value;

        //public int getVal()
        //{
        //    return this.value;
        //}
        public void win(string name, int score)
        {
            
            Console.WriteLine("{0} Wins!", this.name);
            string[] lines = { "{0} {1}", name, score };

            // Set a variable to the My Documents path.
            string mydocpath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\score.txt"))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(mydocpath + @"\score.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        public void loss()
        {

        }
    }   
}
