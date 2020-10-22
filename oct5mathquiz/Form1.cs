using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oct5mathquiz
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        //for the addition problem.
        int addend1, addend2;
        int timeLeft;
        //for the subtraction problem.
        int subend1, subend2;
        int prodend1, prodend2;
        int divend1, divend2;
        private Color timeLabelColor;

        public Form1()
        {
            InitializeComponent();
            timeLabelColor = timeLabel.BackColor;
        }
        //this method gets called when user clicks on the "start the quiz " button
        public void StartTheQuiz()
        {
            timeLabel.BackColor = timeLabelColor;
            //addition question
            addend1 = randomizer.Next(50);
            addend2 = randomizer.Next(50);
            //assigning the randomly generated nos to the label's text property
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            sum.Value = 0;

            //subtraction question
            subend1 = randomizer.Next(51,100);
            subend2 = randomizer.Next(50);
            //assigning the randomly generated nos to the label's text property
            minusLeftLabel.Text = subend1.ToString();
            minusRightLabel.Text = subend2.ToString();
            difference.Value = 0;


            //Multiplication question
            prodend1 = randomizer.Next(10);
            prodend2 = randomizer.Next(10);
            //assigning the randomly generated nos to the label's text property
            mulLeftLabel.Text = prodend1.ToString();
            mulRightLabel.Text = prodend2.ToString();
            product.Value = 0;



            //Division question
            divend1 = randomizer.Next(51,100);
            divend2 = randomizer.Next(50);
            //assigning the randomly generated nos to the label's text property
            divLeftLabel.Text = divend1.ToString();
            divRightLabel.Text = divend2.ToString();
            quotient.Value = 0;



            // set the timing limit for the quiz and start the timer
            timeLeft = 30;
            timeLabel.Text = timeLeft.ToString() + "Seconds";
            timer1.Start();

        }


        private bool CheckTheAnswer()
        {
            if (addend1 + addend2 == sum.Value)
            {
                if (subend1 - subend2 == difference.Value)
                {
                    if (prodend1 * prodend2 == product.Value)
                    {
                        if (divend1 / divend2 == quotient.Value)
                            return true;
                        else return false;
                    }
                    else return false;
                }
                else return false;

            }
            else return false;




         
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void plusLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void plusRightLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(CheckTheAnswer())
            {
                //if the answers are correct
                timer1.Stop();
                MessageBox.Show("You have answered right.. ");
                startButton.Enabled = true;
                timeLabel.BackColor = timeLabelColor;
            }

           else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft.ToString();
                if (timeLeft <= 8)
                {
                    //timeLabelColor = timeLabel.BackColor;
                    timeLabel.BackColor = Color.Red; 
                
                }
            }

            else
            {
                //stopping the timer
                timer1.Stop();
                timeLabel.Text = "Time's up";
                MessageBox.Show("Quiz time is finished");
                //reveal the correct answer
                sum.Value = addend1 + addend2;
                difference.Value = subend1 - subend2;
                product.Value = prodend1 * prodend2;
                quotient.Value = divend1 / divend2;

                //enable the start button
                startButton.Enabled = true;

            }

        }

        private void sum_Enter(object sender, EventArgs e)
        {
            NumericUpDown answer = sender as NumericUpDown;

            if (answer != null)
            {
                answer.Select(0, answer.Value.ToString().Length);
            }

        }

        private void sum_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
