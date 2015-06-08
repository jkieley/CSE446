using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace WorkflowConsoleApplication1
{

    public sealed class GetSecretNumberServiceCall : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<int> lowerLimit { get; set; }
        public InArgument<int> upperLimit { get; set; }
        public OutArgument<int> secretNum { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            int lower = context.GetValue(this.lowerLimit);
            int upper = context.GetValue(this.upperLimit);
            WorkflowServiceClient client = new WorkflowServiceClient();
            int result = client.SecretNumber(lower,upper);
            secretNum.Set(context, result);
        }
    }
}
