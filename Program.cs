using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace learning
{
    delegate string Company(string Cname, string sample);
    public class Person {
       // string name;

        public Person (string name) {
            this.Name = name;
        }

        private string Name;

        public string FirstName {
             get{

                return Name.Split(new char[]{' '})[0];
             }
        }

        public string LastName {
             get{

                return Name.Split(new char[]{' '})[1];
             }
        }

        
        ~Person () => Console.WriteLine("finalize");
    }
    class Program
    {
        
        public static void Main(string[] args) {
            //Example online
            StringBuilder message  = new StringBuilder();

            var joe = new Person("Nancy Senelier");
            Console.WriteLine(joe.FirstName);
            Console.WriteLine(joe.LastName);

            //Tulpes example also can be done with parameters static (int row, int column)
            var bob = ("Nancy ", 27);
            Console.WriteLine(bob.Item1);
            Console.WriteLine(bob.Item2);

            var tuple = (Name: "Erick", Age: 23);
            Console.WriteLine(tuple.Name);
            Console.WriteLine(tuple.Age);

            /*Delegate example*/
            Company Toyota = EmployeeName;
            string FullName = Toyota("Hunt","Sam");
            Console.WriteLine(FullName);

            if(args.Length < 1) {

                message.Append("Welcome");  

            }
            else {

                foreach(string item in args){

                    message.Append(item); 

                }

            }

            Console.WriteLine(message);

            //Out variable
            TestMethod(out string tempText);

            //local Methods
            WriteCubes();

            //Collections
            IEnumerable<int> ienum = OddSequence(50, 110);
            Console.WriteLine("Retrieved enumerator...");

            foreach (var i in ienum){
                Console.Write($"{i} ");
            }     

            //Patterns
            string x = "Tray"; //need to specific type like number or string 

            #region Whileloop
            
            while(true){ 

                if(x == null){

                 x = Console.ReadLine();

                }            

                switch(x){ 

                    case string s:
                    Console.WriteLine(s.Length);
                    break;  //We can use the s variable


                    case null:
                    Console.WriteLine("Nothing");
                    break;

                    default: 
                     Console.WriteLine("Nothing!");
                    break;

                }

                

            }//continous loop
            #endregion
         }
         //Delegate example
        static string EmployeeName(string lastName, string firstName) => lastName + "," + firstName;

        static void TestMethod(out string strName) {
            strName = "Out variable";
            Console.WriteLine(strName);
        }/*The out variable example */

        static void WriteCubes() { 

            Console.WriteLine(Cube(3));
            Console.WriteLine(Cube(4));
            Console.WriteLine(Cube(5));
            int Cube (int value) => value * value * value;
        
        }
            public static IEnumerable<int> OddSequence(int start, int end)
            {
                if (start < 0 || start > 99)
                    throw new ArgumentOutOfRangeException("start must be between 0 and 99.");
                if (end > 100)
                    throw new ArgumentOutOfRangeException("end must be less than or equal to 100.");
                if (start >= end)
                    throw new ArgumentException("start must be less than end.");
                    
                return GetOddSequenceEnumerator();
                
                IEnumerable<int> GetOddSequenceEnumerator()
                {
                    for (int i = start; i <= end; i++)
                    {
                        if (i % 2 == 1)
                         yield return i;
                    }   
                }
            }

    }

    
}
