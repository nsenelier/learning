using System;
using System.Text;

namespace learning
{
    class Program
    {
         public static void Main(string[] args) {
            ///Example online
            StringBuilder message  = new StringBuilder();

            if(args.Length < 1) {
                message.Append("Welcome to .Net Core!");
            }
            else {
                foreach(string item in args ){
                    message.Append(item); //TODO replace with String builder
                }
            }

            Console.WriteLine(message);

        }
        
    }
}
