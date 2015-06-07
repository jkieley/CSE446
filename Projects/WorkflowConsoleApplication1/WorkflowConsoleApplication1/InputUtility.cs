using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowConsoleApplication1
{
    class InputUtility
    {
        public static int takeNumberInput()
        {
            return takeNumberInput(null);
        }

        public static int takeNumberInput(String msg)
        {
            try
            {
                if (msg != null) {
                    Console.WriteLine(msg);
                }
                
                string userInput = Console.ReadLine();
                if (userInput.Equals(""))
                {
                    throw new System.FormatException();
                }
                else
                {
                    return int.Parse(userInput);
                }
            }
            catch (System.FormatException)
            {
                return takeNumberInput("Invalid Input, try again...");
            }
        }
    }
}
