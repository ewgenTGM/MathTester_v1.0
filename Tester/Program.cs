using ExampleClasses.Controllers;
using ExampleClasses.Models;
using ExampleClasses.View;
using System;
using System.Collections.Generic;

namespace Tester
{
    class Viewer : IView
    {
        public event EventHandler TakeAnswer;
        public event EventHandler StartTesting;
        
        public void SetExample(int arg1, int arg2, char operation)
        {
            Console.WriteLine($"{arg1} {operation} {arg2} = ?");
        }

        public void StopTesting(string reason)
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static Viewer viewer = new Viewer();
        static ExampleSetBuilder exSet = new ExampleSetBuilder();
        private static void Main(string[] args)
        {
            
            
            exSet.AddExampleToSet(10, ExampleSetBuilder.ExampleType.Random);
            Training training = new Training(viewer, exSet, 600, 10);
            viewer.StartTesting += Viewer_StartTesting;
            Console.ReadLine();
        }

        private static void Viewer_StartTesting(object sender, EventArgs e)
        {
            ;
        }
    }
}