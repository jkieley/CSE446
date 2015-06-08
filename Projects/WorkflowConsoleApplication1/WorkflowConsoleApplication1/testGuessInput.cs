using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace WorkflowConsoleApplication1
{

    public sealed class TestGuessInput : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<int> secretNumberInput { get; set; }
        public InArgument<int> attemptCountInput { get; set; }
        
        public OutArgument<int> attemptCountOutput { get; set; }
        public OutArgument<bool> contOutput { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            int secretNum = context.GetValue(this.secretNumberInput);
            int attemptCount = context.GetValue(this.attemptCountInput);

            AsuServiceClient client = new AsuServiceClient();

            int attemptPlusOne = ++attemptCount;

            int guess = InputUtility.takeNumberInput("What number would you like to guess?");
            string output = client.checkNumber(guess, secretNum);
            bool cont = !output.ToLower().Contains("correct");

            contOutput.Set(context, cont);
            attemptCountOutput.Set(context, attemptPlusOne);
            InputUtility.buildAttemptOutput(output, attemptPlusOne, cont);
        }
    }
}
