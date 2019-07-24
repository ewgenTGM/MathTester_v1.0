
namespace ExampleClasses.Models
{
    internal class DivideExample : ExampleBase
    {
        public DivideExample()
        {
            OperandOne = r.Next(2, 10);
            OperandTwo = r.Next(3, 10);
            Result = OperandOne * OperandTwo;
            var temp = OperandOne;
            OperandOne = Result;
            Result = temp;
            Opr = ':';
        }
    }
}