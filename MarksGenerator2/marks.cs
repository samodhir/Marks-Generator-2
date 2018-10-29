using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksGenerator2
{
    class marks
    {
        static void Main()
        {
            //subject array
            string[] subject = new string[4];
            //mark array
            int[] mark = new int[4];
            //user inputs for subject and marks
            Console.Write("Subject Name \n");
            subject[0] = Console.ReadLine();
            Console.Write("marks\n");
            mark[0] = int.Parse(Console.ReadLine());
            Console.Write("Subject Name \n");
            subject[1] = Console.ReadLine();
            Console.Write("marks\n");
            mark[1] = int.Parse(Console.ReadLine());
            Console.Write("Subject Name \n");
            subject[2] = Console.ReadLine();
            Console.Write("marks\n");
            mark[2] = int.Parse(Console.ReadLine());
            Console.Write("Subject Name \n");
            subject[3] = Console.ReadLine();
            Console.Write("marks\n");
            mark[3] = int.Parse(Console.ReadLine());
           
            //print subject with 
            Console.Write("\n {0}",subject[0]);
            Console.Write(": {0}",mark[0]);

            Console.Write("\n {0}", subject[1]);
            Console.Write(": {0}", mark[1]);

            Console.Write("\n {0}", subject[2]);
            Console.Write(": {0}", mark[2]);

            Console.Write("\n {0}", subject[3]);
            Console.Write(": {0}", mark[3]);

            

            Console.ReadKey();
            
        }
    }
}
