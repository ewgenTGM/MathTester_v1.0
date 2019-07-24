using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleClasses.View
{
    public interface IView
    {
        event EventHandler TakeAnswer;
        event EventHandler StartTesting;
        void SetExample(int arg1, int arg2, char operation);
        void StopTesting(string reason);
    }
}
