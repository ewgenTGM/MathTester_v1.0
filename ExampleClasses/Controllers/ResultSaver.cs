using ExampleClasses.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExampleClasses.Controllers
{
    public static class ResultSaver
    {
        public static void SaveResultToFile(string path, List<IExample> exampleList)
        {
            var rightAnswerList = exampleList.Where(n => n.State == ExampleState.RightAnswered).ToList();
            var wrongAnswerList = exampleList.Where(n => n.State == ExampleState.WrongAnswered).ToList();
            var notAnswerList = exampleList.Where(n => n.State == ExampleState.NotAnswered).ToList();
            var rightAnswerCount = rightAnswerList.Count;
            var wrongAnswerCount = wrongAnswerList.Count;
            var notAnswerCount = notAnswerList.Count;

            using (var writer = new StreamWriter(path, true, Encoding.UTF8))
            {
                void WriteLineToFile(int lineCount = 1)
                {
                    for (int i = 0; i < lineCount; i++)
                    {
                        writer.WriteLine(new string('-', 60));
                    }
                }

                void WriteToFile(IExample example)
                {
                    string str = example.ToString();
                    switch (example.State)
                    {
                        case ExampleState.WrongAnswered:
                            str += " Ответил: " + example.UserAnswer.ToString();
                            break;

                        case ExampleState.NotAnswered:
                            str += " Нет ответа";
                            break;
                    }
                    writer.WriteLine(str);
                }
                double rightCountPercent = Math.Round(rightAnswerCount / (double)exampleList.Count * 100, 2);
                double wrongCountPercent = Math.Round(wrongAnswerCount / (double)exampleList.Count * 100, 2);
                double notAnswerCountPercent = Math.Round(notAnswerCount / (double)exampleList.Count * 100, 2);
                WriteLineToFile(2);
                writer.WriteLine(
                    $"Тестирование окончено: {DateTime.Today.ToShortDateString()} {DateTime.Now.ToShortTimeString()}");
                writer.WriteLine($"Всего примеров: {exampleList.Count}");
                writer.WriteLine($"Верных ответов: {rightAnswerCount} ({rightCountPercent} %)");
                writer.WriteLine($"Ошибок: {wrongAnswerCount} ({wrongCountPercent} %)");
                writer.WriteLine($"Не отвечено: {notAnswerCount} ({notAnswerCountPercent} %)");
                WriteLineToFile();

                if (wrongAnswerCount > 0)
                {
                    writer.WriteLine();
                    writer.WriteLine("Неверные ответы:");
                    wrongAnswerList.ForEach(WriteToFile);
                }

                if (notAnswerCount > 0)
                {
                    writer.WriteLine();
                    writer.WriteLine("Нет ответа:");
                    notAnswerList.ForEach(WriteToFile);
                }

                WriteLineToFile(2);
                writer.WriteLine();
            }
        }
    }
}