using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Timers;

namespace ExampleClasses.Models
{
    public class ExampleParameters
    {
        public string Operand1 { get; private set; }
        public string Operand2 { get; private set; }
        public char Operation { get; private set; }
        public ExampleParameters(int op1, int op2, char opr)
        {
            Operand1 = op1.ToString();
            Operand2 = op2.ToString();
            Operation = opr;
        }
    }
    /// <summary>
    /// Класс тренировки
    /// </summary>
    public class Training
    {
        public event EventHandler<DateTime> TrainingStarted;

        public event EventHandler<DateTime> TrainingEnded;

        public event EventHandler<ExampleParameters> TakeNextExample;

        public event EventHandler<int> Tick;

        public bool IsStarted { get; private set; } = false;
        private readonly int timeToExample = 10;
        private Queue<IExample> exampleSet;
        private List<IExample> processedExample = new List<IExample>();
        private IExample currentExample;
        private int remainingTime;
        Timer timer = new Timer(1000);
        

        /// <summary>
        /// Конструктор тренировки
        /// </summary>
        /// <param name="view">Представление</param>
        /// <param name="builder">Завод по производству примеров</param>
        /// <param name="timeToTest">Время на тест</param>
        /// <param name="timeToExample">Время на пример</param>
        public Training(ExampleSetBuilder builder, int timeToExample = 10)
        {
            this.timeToExample = timeToExample;
            exampleSet = builder.GetExampleSet();
        }

        //Закрываем стандартный конструктор
        protected Training() { }

        /// <summary>
        /// Запуск теста
        /// </summary>
        public void StartTraining()
        {
            //Если тест ещё не запущен, то запускаем. Иначе ничего не делаем
            if (!IsStarted)
            {
                IsStarted = true;
                currentExample = exampleSet.Dequeue();
                TrainingStarted?.Invoke(this, DateTime.Now);
                TakeNextExample?.Invoke(this, new ExampleParameters(currentExample.OperandOne, currentExample.OperandTwo, currentExample.Opr));
                timer.AutoReset = true;
                timer.Start();
                timer.Elapsed += Timer_Elapsed;
                remainingTime = timeToExample;
                Tick?.Invoke(this, timeToExample);
            }
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            remainingTime -= 1;
            Tick?.Invoke(this, remainingTime);
            if (remainingTime == 0)
            {
                TakeAnswer(0, true);
            }
        }

        /// <summary>
        /// Дать ответ
        /// </summary>
        /// <param name="answer">Ответ</param>
        public void TakeAnswer(int answer, bool onTimeEnded = false)
        {
            currentExample.UserAnswer = answer;
            // Устанавливам State:
            currentExample.SetState(answer == currentExample.UserAnswer ? ExampleState.RightAnswered : ExampleState.WrongAnswered);
            if (onTimeEnded) currentExample.SetState(ExampleState.NotAnswered);
            processedExample.Add(currentExample);

            if (exampleSet.Count > 0)
            {
                currentExample = exampleSet.Dequeue();
                TakeNextExample?.Invoke(this, new ExampleParameters(currentExample.OperandOne, currentExample.OperandTwo, currentExample.Opr));
                timer.Stop();
                Tick?.Invoke(this, timeToExample);
                remainingTime = timeToExample;
                timer.Start();
            }
            else
            {
                timer.Stop();
                IsStarted = false;
                TrainingEnded?.Invoke(this, DateTime.Now);
            }
        }
    }
}