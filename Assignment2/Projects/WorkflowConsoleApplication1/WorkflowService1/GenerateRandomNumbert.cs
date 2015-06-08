using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace WorkflowService1
{

    public sealed class GenerateRandomNumbert : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<int> lowerLimit { get; set; }
        public InArgument<int> upperLimit { get; set; }
        public OutArgument<int> result { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument

            int lower = context.GetValue(this.lowerLimit);
            int upper = context.GetValue(this.upperLimit);

            DateTime currentDate = DateTime.Now;
            int seed = (int)currentDate.Ticks;
            Random random = new Random(seed);
            int sNumber = random.Next(lower, upper);

            result.Set(context, sNumber);
        }
    }
}
