using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathAttack
{
    public partial class Form1 : Form
    {
        Question currentQuestion = null;
        string qTxt = "";
        string qGrp = "";
        string relativePath = "";
        string logFile = "History.log";
        System.Timers.Timer timer = new System.Timers.Timer();
        int timerInterval = 1000;
        int nQuestions = 0;
        int cQuestions = 0;
        int cStreak = 0;
        float elapsedTime = 0.0f;
        bool timerOn = false;
        public Form1()
        {
            InitializeComponent();
            if (!File.Exists(relativePath + logFile))
            {
                var tmp = File.Create(relativePath + logFile);
                tmp.Close();
            }
            UpdateQuestion();
        }

        private void Response_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
            {
                SubmitResponse();
                e.Handled = true;
            }
        }

        private void SubmitResponse()
        {
            string responseText = Response.Text;
            float response = 0.0f;
            bool submissionOk = false;
            try
            {
                response = float.Parse(responseText);
                submissionOk = true;
            }
            catch
            {
                submissionOk = false;
            }
            if ((currentQuestion != null) && submissionOk)
            {
                this.nQuestions++;
                float solution = currentQuestion.getSolution();
                float delta = 0.01f;
                if (Math.Abs(response - solution) < delta)
                {
                    this.cStreak++;
                    CorrectAnswer();
                    SaveSubmission(responseText, true);
                    UpdateQuestion();
                }
                else
                {
                    this.cStreak = 0;
                    WrongAnswer();
                    SaveSubmission(responseText, false);
                    Response.Text = "";
                }
            }
        }

        private void SaveSubmission(string solution, bool correct)
        {
            string cTxt;
            
            if (correct)
            {
                cTxt = "Correct";
            } else
            {
                cTxt = "Incorrect";
            }
            using (StreamWriter sw = File.AppendText(relativePath + logFile))
            {
                sw.WriteLine(DateTime.Today.ToString() + "," +
                             qGrp + "," +
                             qTxt + "," +         
                             currentQuestion.getQuestion() + "," +
                             currentQuestion.getSolution().ToString() + "," +
                             solution + "," + cTxt);
            }
        }
        private void CorrectAnswer()
        {
            this.cQuestions++;
            RewardText.Text = "Right! Good job.";
            Reward.Image = Image.FromFile(relativePath + "Yes.jpg");
            Reward.Visible = true;
            Reward.Refresh();
            RewardText.Refresh();
            System.Threading.Thread.Sleep(2000);
            RewardText.Text = "";
            Reward.Visible = false;
            Reward.Refresh();
            RewardText.Refresh();
            UpdateStreak();
        }
        private void WrongAnswer()
        {
            RewardText.Text = "Wrong! Try again.";
            Reward.Image = Image.FromFile(relativePath + "No.jpg");
            Reward.Visible = true;
            Reward.Refresh();
            RewardText.Refresh();
            System.Threading.Thread.Sleep(2000);
            RewardText.Text = "";
            Reward.Visible = false;
            Reward.Refresh();
            RewardText.Refresh();
            UpdateStreak();
        }
        private void UpdateStreak()
        {
            QAttempt.Text = this.nQuestions.ToString();
            QCorrect.Text = this.cQuestions.ToString();
            QStreak.Text = this.cStreak.ToString();
            QPercent.Text = Math.Round(100.0f * (float)this.cQuestions / (float)this.nQuestions).ToString() + "%";
        }

        private void QuestionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection questionType = QuestionList.SelectedItems;
            if (questionType.Count > 0)
            {
                qTxt = questionType[0].Text;
                qGrp = questionType[0].Group.Header;
                UpdateQuestion();
            }
        }
        private void UpdateQuestion()
        {
            int n1 = 0;
            int n2 = 0;
            string op = "+";
            QuestionType qType = QuestionType.Add2Numbers;
            Random rng = new Random();

            Response.Text = "";
            RewardText.Text = "";

            if (qTxt.Equals("") || qGrp.Equals(""))
            {
                Question.Text = "";
            }
            else
            {
                switch (qTxt)
                {
                    case "Add Two Numbers":
                        qType = QuestionType.Add2Numbers;
                        op = "+";
                        break;
                    case "Subtract Two Numbers":
                        qType = QuestionType.Subtract2Numbers;
                        op = "-";
                        break;
                    case "Multiply Two Numbers":
                        qType = QuestionType.Multiply2Numbers;
                        op = "*";
                        break;
                    case "Divide Two Numbers":
                        qType = QuestionType.Divide2Numbers;
                        op = "/";
                        break;
                }
                switch (qGrp)
                {
                    case "Easy":
                        if (qType.Equals(QuestionType.Add2Numbers) ||
                            qType.Equals(QuestionType.Subtract2Numbers) ||
                            qType.Equals(QuestionType.Multiply2Numbers))
                        {
                            n1 = rng.Next(0, 11);
                            n2 = rng.Next(0, 11);
                        }
                        if (qType.Equals(QuestionType.Divide2Numbers))
                        {
                            n1 = rng.Next(0, 6);
                            n2 = rng.Next(1, 6);
                            n1 = n1 * n2;
                        }
                        break;
                    case "Medium":
                        if (qType.Equals(QuestionType.Add2Numbers) ||
                            qType.Equals(QuestionType.Subtract2Numbers))
                        {
                            n1 = rng.Next(11, 51);
                            n2 = rng.Next(5, 11);
                        }
                        if (qType.Equals(QuestionType.Multiply2Numbers))
                        {
                            n1 = rng.Next(5, 13);
                            n2 = rng.Next(5, 13);
                        }
                        if (qType.Equals(QuestionType.Divide2Numbers))
                        {
                            n1 = rng.Next(5, 13);
                            n2 = rng.Next(1, 6);
                            n1 = n1 * n2;
                        }
                        break;
                    case "Hard":
                        if (qType.Equals(QuestionType.Add2Numbers) ||
                            qType.Equals(QuestionType.Subtract2Numbers))
                        {
                            n1 = rng.Next(11, 51);
                            n2 = rng.Next(11, 51);
                        }
                        if (qType.Equals(QuestionType.Multiply2Numbers))
                        {
                            n1 = rng.Next(11, 51);
                            n2 = rng.Next(3, 10);
                        }
                        if (qType.Equals(QuestionType.Divide2Numbers))
                        {
                            n1 = rng.Next(5, 13);
                            n2 = rng.Next(5, 13);
                            n1 = n1 * n2;
                        }
                        break;
                }
                currentQuestion = new Question(n1, n2, op);
                Question.Text = currentQuestion.getQuestion();
            }
        }
        private void Skip_Click(object sender, EventArgs e)
        {
            UpdateQuestion();
        }

        private void ResetTimer_Click(object sender, EventArgs e)
        {
            this.timer.Close();
            this.timer.Dispose();
            QAttempt.Text = "0";
            QCorrect.Text = "0";
            QStreak.Text = "0";
            QPercent.Text = "0%";
            this.elapsedTime = 0.0f;
            this.timerOn = true;
            this.nQuestions = 0;
            this.cQuestions = 0;
            this.cStreak = 0;
            this.timer = new System.Timers.Timer(this.timerInterval);
            this.timer.Elapsed += ClockTick;
            this.timer.Start();
            this.QPercent.Text = "0%";
            this.QPerMinute.Text = "0";
        }

        private void ClockTick(object sender, EventArgs e)
        {
            this.elapsedTime += (float) this.timerInterval/1000.0f/60.0f;
            if (this.TimerText.InvokeRequired)
            {
                this.TimerText.Invoke(new MethodInvoker(delegate { 
                    this.TimerText.Text = this.elapsedTime.ToString("0.0"); 
                }));
            }
            if (this.QPerMinute.InvokeRequired)
            {
                this.QPerMinute.Invoke(new MethodInvoker(delegate
                {
                    if (this.elapsedTime - 0.0f < 0.0001)
                    {
                        this.QPerMinute.Text = "0";
                    }
                    else
                    {
                        this.QPerMinute.Text = ((float)this.cQuestions / this.elapsedTime).ToString("0.00");
                    }
                }));
            }
        }
    }

    public enum QuestionType
    { 
        Add2Numbers,
        Subtract2Numbers,
        Multiply2Numbers,
        Divide2Numbers
    }

    public class Question
    {
        int n1 = 0;
        int n2 = 0;
        string op = "+";

        public Question(int n1, int n2, string op)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.op = op;
        }

        public string getQuestion()
        {
            string qTxt = n1.ToString() + " " + op + " " + n2.ToString() + " = ???";
            return qTxt;
        }

        public float getSolution()
        {
            float solution = 0.0f;
            switch(op)
            {
                case "+":
                    solution = n1 + n2;
                    break;
                case "-":
                    solution = n1 - n2;
                    break;
                case "*":
                    solution = n1 * n2;
                    break;
                case "/":
                    solution = n1 / n2;
                    break;
            }
            return solution;
        }
    }
}
