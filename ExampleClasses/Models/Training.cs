using ExampleClasses.View;
using System;
using System.Collections.Generic;

namespace ExampleClasses.Models
{
    public class Training
    {
        public event EventHandler TrainingIsStarted;
        public event EventHandler TrainingIsEnded;
        public event EventHandler NextExample;
        private bool isStarted = false;
        private readonly int timeToExample = 10;
        private Queue<IExample> exampleSet;
        private List<IExample> processedExample = new List<IExample>();
        public IExample currentExample;

        /// <summary>
        /// Конструктор тренировки
        /// </summary>
        /// <param name="view">Представление</param>
        /// <param name="builder">Завод по производству примеров</param>
        /// <param name="timeToTest">Время на тест</param>
        /// <param name="timeToExample">Время на пример</param>
        public Training(ExampleSetBuilder builder, int timeToExample)
        {
            this.timeToExample = timeToExample;
            exampleSet = builder.GetExampleSet();
        }

        /// <summary>
        /// Запуск теста
        /// </summary>
        public void StartTesting()
        {
            if (!isStarted)
            {
                TrainingIsStarted?.Invoke(this, EventArgs.Empty);
                NextExample?.Invoke(this, EventArgs.Empty);
                isStarted = true;
                currentExample = exampleSet.Dequeue();
            }
        }

        /// <summary>
        /// Дать ответ
        /// </summary>
        /// <param name="answer"></param>
        public void TakeAnswer(int answer)
        {
            currentExample.UserAnswer = answer;
            // Устанавливам State:
            currentExample.SetState(answer == currentExample.UserAnswer ? ExampleState.RightAnswered : ExampleState.WrongAnswered);
           
            processedExample.Add(currentExample);

            if (exampleSet.Count > 0)
            {
                currentExample = exampleSet.Dequeue();
            }
            else
            {
                TrainingIsEnded?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}