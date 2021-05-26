using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ScaleAndRefl
{
    public partial class Form1 : Form
    {

        // declarations

        private String UnprocessedInput;
        private String reflectionInput;
        private String scaleInputX;
        private String scaleInputY;
        private String axisInput;

        private int inputSize;
        private int[,] processedInput;
        private int[,] output;
        private int scaleMetricX;
        private int scaleMetricY;


        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProceedButton_Click(object sender, EventArgs e)
        {
            SplitData();

            //checking if the user didn't choose any radio button
            if(ScaleButton.Checked== false && ReflectButton.Checked == false)
            {
                //opening error message
                errorMsg newWindow = new errorMsg();
                newWindow.ShowDialog();
            }

            //checking if the user wants to scale points
            if (ScaleButton.Checked == true)
            {
                //parsing scaling input to integers
                scaleMetricX = int.Parse(ScaleXTextBox.Text);
                scaleMetricY = int.Parse(ScaleYTextBox.Text);

                //passing the points to be scaled
                Scale(processedInput, scaleMetricX, scaleMetricY);
            }

            //checking if the user wants to reflect points
            if (ReflectButton.Checked == true)
            {
                //storing user input
                axisInput = ReflectTextBox.Text;

                //check for incorrect input
                if(axisInput != "x" && axisInput != "y" && axisInput != "xy")
                {
                    //showing error message
                    errorMsg newWindow = new errorMsg();
                    newWindow.ShowDialog();
                }

                //passing the points to be reflected and the desired axis
                reflect(processedInput, axisInput);

            }

            //passing the points to be drawn by drawPoints
            drawPoints(processedInput, output);
        }



        private void SplitData()
        {
            UnprocessedInput = InputTextBox.Text;
            inputSize = 0;

            //calculate the number of point entered by the user
            foreach (char c in UnprocessedInput)
            {
                if (c == '(')
                    inputSize++;
            }

            //allocating space for the processedInput array
            processedInput = new int[inputSize, inputSize];

            //index for indexing processedInput array
            int index = 0;

            //loop through the unprocessedInput string
            for (int i = 0; i < UnprocessedInput.Length; i++)
            {

                String x ="";
                String y ="";
                while (UnprocessedInput[i] != '(')
                {
                    i++;
                }
                if (UnprocessedInput[i] == '(')
                {
                    i++;
                    while (UnprocessedInput[i] != ',')
                    {
                        x = x + UnprocessedInput[i];

                        i += 1;

                    }
                    if (UnprocessedInput[i] == ',')
                    {
                        i++;
                        while (UnprocessedInput[i] != ')')
                        {
                            y += UnprocessedInput[i];
                            i += 1;
                        }

                    }
                    
                }

                //storing the cooardinates of the vertices in the processedInput
                processedInput[index, 0] = int.Parse(x);
                processedInput[index, 1] = int.Parse(y);

                index++;
            }
        }


        //function scales the points to the required scale
        private void Scale(int [,] data, int metricX, int metricY)
        {

            output = new int[inputSize, inputSize];
            int x, y;
            for(int i=0; i < inputSize; i++)
            {
                output[i, 0] = data[i, 0] * metricX;
                output[i, 1] = data[i, 1] * metricY;
            }
        }


        //function reflects along the axis required
        private void reflect(int [,] data, String axis)
        {
            output = new int[inputSize, inputSize];

            if (axis=="x")
            {
                for(int i=0; i < inputSize; i++)
                {
                    //making the y axis negative
                    output[i, 1] = data[i, 1] * -1;
                }
            }

            if (axis == "y")
            {
                for (int i = 0; i < inputSize; i++)
                {
                    //making the x axis negative
                    output[i, 0] = data[i, 0] * -1;
                }
            }

            if (axis == "xy")
            {
                for (int i = 0; i < inputSize; i++)
                {
                    //making both the x and y axis negative
                    output[i, 0] = data[i, 0] * -1;
                    output[i, 1] = data[i, 1] * -1;
                }
            }
        }


        private void drawPoints(int [,] oldPoint, int[,] newPoint)
        {

            //calculating the midpoint coardinates of the panel to use it as an origin point
            int windowMidX = panel1.Width / 2; //x axis
            int windowMidY = panel1.Height / 2;//y axis

            //blue are the input         
               var points1 = Brushes.Blue;           
            //green are the output
               var points2 = Brushes.Green;
            
            var blot = panel1.CreateGraphics();

            for(int i = 0; i < inputSize; i++)
            {

                /*oldPoint[i, 0] = oldPoint[i, 0] + windowMidX;
                oldPoint[i, 1] = oldPoint[i, 1] + windowMidY;

                newPoint[i, 0] = newPoint[i, 0] + windowMidX;
                newPoint[i, 1] = newPoint[i, 1] + windowMidY;*/

                blot.FillRectangle(points1, oldPoint[i, 0], oldPoint[i, 1], 5, 5);
                blot.FillRectangle(points2, newPoint[i, 0], newPoint[i, 1], 5, 5);
            }

        }
        private void ScaleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ScaleButton_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReflectButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
