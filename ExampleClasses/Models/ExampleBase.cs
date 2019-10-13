using System;

namespace ExampleClasses.Models
{
    public enum ExampleState
    {
        RightAnswered = 1, // отвечено правильно
        WrongAnswered = 2, // отвечено неправильно
        NotAnswered = 3,   // не отвечено (время вышло)
        Undefined = 4        // не определено (ещё не задействован)
    }

    public abstract class ExampleBase : IExample
    {
        public int OperandOne { get; set; }
        public int OperandTwo { get; set; }
        public int Result { get; set; }
        public char Opr { get; set; }
        public ExampleState State { get; private set; } = ExampleState.Undefined;
        public int UserAnswer { get ; set ; }

        public static Random r = new Random();

        public override string ToString()
        {
            return string.Format($"{OperandOne} {Opr} {OperandTwo} = {Result}");
        }

        public bool CheckUserAnswer(int answer)
        {
            return answer == Result;
        }

        public void SetState(ExampleState state)
        {
            State = state;
        }
    }
}