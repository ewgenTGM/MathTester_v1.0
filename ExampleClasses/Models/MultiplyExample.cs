namespace ExampleClasses.Models
{
    internal class MultiplyExample : ExampleBase
    {
        public MultiplyExample()
        {
            OperandOne = r.Next(2, 10);
            OperandTwo = r.Next(3, 10);
            Result = OperandOne * OperandTwo;
            Opr = 'x';
        }
    }
}