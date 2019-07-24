namespace ExampleClasses.Models
{
    public interface IExample
    {
        string ToString();

        bool CheckUserAnswer(int answer);

        int UserAnswer { get; set; }

        void SetState(ExampleState state);

        ExampleState State { get; }
        int OperandOne { get; }
        int OperandTwo { get; }
        int Result { get; }
        char Opr { get; }
    }
}