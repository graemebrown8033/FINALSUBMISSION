using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace speechRec
{
    public partial class Form1 : Form
    {
        #region ----- FIELDS -----

        private string LocationID;
        private int count = 4;

        #endregion

        #region ----- OBJECTS -----

        Class1 info = new Class1();
        SpeechSynthesizer reader = new SpeechSynthesizer();

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region ----- DATABASE -----

        // This method opens the connection to the database, takes the Location ID and passes it to the building method.
        // It then populates the information text box with the corresponding data.

        public void buildInfo(int num)
        {
            info.Connect("127.0.0.1");
            info.printBuilding2(num);
            info.LoadData();
            InformationBox.Text += info.myArr[4];

        }


        #endregion

        #region ----- SERIAL PORT -----

        // This method is the interrupt for the serial port connection.
        // Upon receiving new data, it calls the clear methods for the location and information boxes and repopulates them.
        // It then calls clear buffer.
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SpeakAsync("New information available. Please press get information to continue.");
            this.Invoke(new EventHandler(ClearLocation));
            this.Invoke(new EventHandler(ClearInfo));
            LocationID = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(DisplayLocation));
            this.Invoke(new EventHandler(ClearBuffer));

        }

        #endregion

        # region ----- BUTTONS -----

        // Button to open the port 
        private void btnStart_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM3";
            serialPort1.BaudRate = 9600;
            serialPort1.Open();

            if (serialPort1.IsOpen)
            {
                btnStart.Enabled = false;
                btnDeactivate.Enabled = true;
                LocationBox.Enabled = true;
                InformationBox.Enabled = true;
                btnPlay.Enabled = true;
                btnRepeat.Enabled = true;
                btnNext.Enabled = true;
            }
        }

        // Button to close the port, clear any remaining information and disable boxes.
        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnDeactivate.Enabled = false;
            serialPort1.Close();
            this.Invoke(new EventHandler(ClearInfo));
            this.Invoke(new EventHandler(ClearLocation));
            LocationBox.Enabled = false;
            InformationBox.Enabled = false;
            btnPlay.Enabled = false;
            btnRepeat.Enabled = false;
            btnNext.Enabled = false;
        }

        // Button to play the contents of the text box using Text To Speech
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (InformationBox.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(InformationBox.Text);
            }
        }

        // Button to repeat the current contents of the text box
        private void btnRepeat_Click(object sender, EventArgs e)
        {
            if (InformationBox.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(InformationBox.Text);
            }
        }

        // Button to move to next location detail.
        private void btnNext_Click(object sender, EventArgs e)
        {
            count++;

            if (count < 8)
            {
                this.Invoke(new EventHandler(ClearInfo));
                InformationBox.Text += info.myArr[count];
            }
            else if (count == 8)
            {
                count = 3;
                this.Invoke(new EventHandler(ClearInfo));
                InformationBox.Text += ("There is no more information available for this location. Please press Next to start from the beginning.");
            }
            this.Invoke(new EventHandler(btnPlay_Click));
        }

        // Button to open the website administration.
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Invoke(new EventHandler(btnDeactivate_Click));
            System.Diagnostics.Process.Start("http://localhost:62655/App/Default.aspx");
        }

        #endregion

        # region ----- DISPLAYS -----

        // This method will take the location ID from the serial and convert it to an integer.
        // It will then display this ID and pass it to the method that calls the corresponding data from the database.
        private void DisplayLocation(object sender, EventArgs e)
        {
            String num = LocationID;
            int num1 = Convert.ToInt32(LocationID);
            LocationBox.AppendText(LocationID);
            buildInfo(num1);
        }

        // This method will start the loop of information for the current location.
        // It starts from position 4 in the array and displays the next element with each button click. 
        private void DisplayInfo()
        {
            if (count < 8)
            {
                this.Invoke(new EventHandler(ClearInfo));
                count++;
                InformationBox.Text += count;
            }
            else
            {
                count = 4;
            }
        }

        #endregion

        # region ---- RESET METHODS ----

        // This method clears any remaining bytes in the buffer.
        private void ClearBuffer(object sender, EventArgs e)
        {
            serialPort1.DiscardInBuffer();
            LocationID = serialPort1.ReadExisting();
        }

        // This method clears the location text box.
        private void ClearLocation(object sender, EventArgs e)
        {
            LocationBox.Text = string.Empty;
        }

        // This method clears the information rich text box.
        private void ClearInfo(object sender, EventArgs e)
        {
            InformationBox.Text = string.Empty;
        }

        #endregion

       

       


    }
}
