namespace ExampleClasses.Models
{
    internal class SummExample : ExampleBase
    {
        public SummExample()
        {
            switch (r.Next(0, 2) == 0 ? 0 : 1)
            {
                case 0:
                    OperandOne = r.Next(15, 86);
                    OperandTwo = r.Next(15, 101 - OperandOne);
                    Result = OperandOne + OperandTwo;
                    Opr = '+';
                    break;

                case 1:
                    OperandOne = r.Next(20, 101);
                    OperandTwo = r.Next(15, OperandOne);
                    Result = OperandOne - OperandTwo;
                    Opr = '-';
                    break;
            }
        }
    }
}