using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace WorkflowConsoleApplication1
{

    public sealed class SetUpperLimit : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<int> Text { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            int userInput = context.GetValue(this.Text);
            Console.WriteLine("This was your input: " + userInput.ToString());
            Console.ReadLine();

            //Console.WriteLine(context.);
        }
    }
}
