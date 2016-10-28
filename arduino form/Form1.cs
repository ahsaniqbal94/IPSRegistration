using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net;
using System.IO;

namespace arduino_form
{
    public partial class Form1 : Form
    {
        string com = "";
        
        string comread="";
        public Form1()
        { 
            
            InitializeComponent();
            
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox5.Items.Add(s);
            }

            for (int i = 2010; i <= DateTime.Now.Year; i++)
            {
                string a = i.ToString();
                string b = (i + 1).ToString().Substring(2,2);
                byear.Items.Add(a+"-"+b);
            }

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string rfid = textBox1.Text.Trim();
                string acc_for = comboBox1.Text.Trim();
                string name = textBox2.Text.Trim();
                string active_acc = comboBox2.Text.Trim();
                string sex = comboBox3.Text.Trim();
                string vehicletype = comboBox4.Text.Trim();
                string vehicleno = textBox3.Text.Trim();
                string department = depart.Text.Trim();
                string enroll = enrollment.Text.Trim();
                string roll = textBox4.Text.Trim();
                string cnic = textBox5.Text.Trim();
                string batch = byear.Text.Trim();

                if(rfid==""||acc_for==""||name==""||active_acc==""||sex==""||vehicleno==""||vehicletype==""||department==""||enroll==""||roll==""||cnic==""||batch=="")
                { 
                    label6.Text="Fill all the fields";
                    return;
                }

                // Create a request using a URL that can receive a post. 
                WebRequest request = WebRequest.Create("http://localhost:8080/accountnoimage ");
                // Set the Method property of the request to POST.
                request.Method = "POST";
                // Create POST data and convert it to a byte array.
                string postData = "rfid=" + rfid + "&accountType=" + acc_for + "&studentName=" + name + "&studentId=" + enroll + "&department=" + department + "&activeAccount=" + active_acc + "&sex=" + sex + "&vehicleType=" + vehicletype + "&vehicleNumber=" + vehicleno + "&batch=" + batch + "&cnicNo=" + cnic + "&rollNumber=" + roll + "&file=1";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                // Set the ContentType property of the WebRequest.
                request.ContentType = "application/x-www-form-urlencoded";
                // Set the ContentLength property of the WebRequest.
                request.ContentLength = byteArray.Length;

                String username = "admin";
                String password = "admin";
                String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
                request.Headers.Add("Authorization", "Basic " + encoded);
                // Get the request stream.
                Stream dataStream = request.GetRequestStream();
                // Write the data to the request stream.
                dataStream.Write(byteArray, 0, byteArray.Length);
                // Close the Stream object.
                dataStream.Close();
                // Get the response.
                WebResponse response = request.GetResponse();
                dataStream = response.GetResponseStream();
                // Display the status.

                StreamReader sr = new StreamReader(dataStream);
                MessageBox.Show(sr.ReadToEnd());
                // Get the stream containing content returned by the server.
                dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                Console.WriteLine(responseFromServer);
                // Clean up the streams.
                reader.Close();
                dataStream.Close();
                response.Close();
                
            } 
            
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            
        }
        
        private void init(string a)
        {
           // comport = new SerialPort();
            try
            {
                serialPort1.BaudRate = 9600;
                serialPort1.PortName = a;
                serialPort1.Open();
            }
            catch(Exception e)
            { }
            
        }

        private void readbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!serialPort1.IsOpen)
            {
                com = comboBox5.Text;
                init(com);
            }
            //serialPort1.Close();
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string text = String.Format(rfid, acc_for, name, active_acc, sex, vtype, vno );
           
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            comread = serialPort1.ReadLine();
            serialPort1.Close();
            Textbox1SetText(comread);
        }

        delegate void Textbox1SetTextCallback(string text);

        private void Textbox1SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textBox1.InvokeRequired)
            {
                Textbox1SetTextCallback d = new Textbox1SetTextCallback(Textbox1SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBox1.Text = text;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         if(comboBox5.SelectedIndex>=0)
             if (!serialPort1.IsOpen)
             {
                 com = comboBox5.Text;
                 init(com);
             }
            textBox1.Text = comread;
            //serialPort1.Close();
        }

        private void byear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void batch_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }
        
        
    }
}
