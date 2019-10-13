using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExampleClasses.Models;

namespace TesterWithUI
{
    public partial class frmMainForm : Form
    {
        static Training training;
        static ExampleSetBuilder builder;
        public frmMainForm()
        {
            InitializeComponent();
            butAnswer.Enabled = false;
            ExampleSetBuilder builder = new ExampleSetBuilder();
            builder.AddExampleToSet(2, ExampleSetBuilder.ExampleType.Random);
            training = new Training(builder, 2);
            butStart.Click += (sender, e) => training.StartTraining();
            training.Tick += Training_Tick;
            training.TakeNextExample += Training_TakeNextExample;
            training.TrainingStarted += (sender, date) => Invoke((Action)(() => SetButtonState()));
            training.TrainingEnded += (sender, date) => Invoke((Action)(() => SetButtonState()));
            

        }
        void SetButtonState()
        {
            butStart.Enabled = !training.IsStarted;
            butAnswer.Enabled = training.IsStarted;
        }
        private void Training_TakeNextExample(object sender, ExampleParameters e)
        {
            Invoke((Action)(() => {
                lblOperandOne.Text = e.Operand1;
                lblOperandtTwo.Text = e.Operand2;
                lblOpr.Text = e.Operation.ToString();
            }));
        }

        private void Training_Tick(object sender, int time)
        {
            Invoke((Action)(() => lblReamining.Text = time.ToString()));
        }
    }
}
