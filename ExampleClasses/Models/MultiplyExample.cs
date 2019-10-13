namespace ExampleClasses.Models
{
    internal sealed class MultiplyExample : ExampleBase
    {
        public MultiplyExample()
        {
            OperandOne = r.Next(2, 8);
            OperandTwo = r.Next(3, 10);
            Result = OperandOne * OperandTwo;
            Opr = 'x';
        }
    }
}