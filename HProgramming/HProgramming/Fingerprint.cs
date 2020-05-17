/****************************************************************************
**                      SAKARYA ÜNİVERSİTESİ
**                BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**                    NESNEYE DAYALI PROGRAMLAMA DERSİ
**                         2019-2020 BAHAR DÖNEMİ
**
**                       PROJE NUMARASI.........: 01
**                       ÖĞRENCİ ADI............:ARSENE ADJEVİ
**                       ÖĞRENCİ NUMARASI.......:B181200559
**                       DERSİN ALINDIĞI GRUP...: A
****************************************************************************/

/*This part of my projet brings together the Software and the Hardware

I used Arduino  Uno(ATEL MEGA 328P) to scan the finger. The result of this scanning will be sent  in the Adafruit template.
If the fingerprint corresponds to a fingerprint that is already in the template, the response "Found ID" will 
be sent through the open connected serial port  and once our code written in C # will read this response the system will open.
*/

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing;

namespace HProgramming
{
    public partial class Fingerprint : Form
    {
        string[] ports;
        SerialPort port;
        List<int> baud = new List<int>();
        public Fingerprint()
        {
            InitializeComponent();
            getAvailableComPorts();
            Addİtem();
            AssociatePort();
        }

        private void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();//Get open port name,note that the COM3 and COM4 don't work for some arduino

        }
        private void Addİtem()//This is the speed of communication through the serial port.Warning: Choose the same baud as that of Arduino code.
        {
            baud.Add(300);
            baud.Add(1200);
            baud.Add(2400);
            baud.Add(4800);
            baud.Add(9600);
            baud.Add(19200);
            baud.Add(38400);
            baud.Add(57600);
            baud.Add(74880);
            baud.Add(115200);
            foreach (var a in baud)
            {
                baudratedrop.Items.Add(a);

            }
        }

        private void AssociatePort()//show the available port in our combox
        {
            foreach (string port in ports)
            {

                portcomdrop.Items.Add(port);
                if (ports[0] != null)
                {
                    portcomdrop.SelectedItem = ports[0];
                }
            }
        }


        private bool connectToArduino()//
        {
            bool isconnected = false;
            try
            {
                string selectedPort = portcomdrop.GetItemText(portcomdrop.SelectedItem);
                port = new SerialPort(selectedPort,Convert.ToInt32(baudratedrop.SelectedItem.ToString()), Parity.None, 8, StopBits.One);
                port.Open();
                port.ReadLine();

                if (port.ReadLine().Substring(0, 8) == "Found ID")//check if the information comes from serial port is "FOUND
                                                                  //we have use the Substring(0,8)  because the ID of each template is no same.
                                                                  //We just verify if the person is authorized to connect or not
                {
                    isconnected = true;


                }
                else
                {
                    isconnected = false;
                }


            }

            catch (TimeoutException ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                port.Close();
            }
            return isconnected;
        }

        private void startscanbtn_Click(object sender, EventArgs e)
        {
            fingerscanpict.BackColor = Color.Teal;//
            try
            {
                if (connectToArduino() == true)//İf the information is "Found ID" the sistem will be open
                {

                    Form1 form = new Form1();
                    LoginForm loginForm = new LoginForm();
                    this.Hide();
                    loginForm.Hide();
                    form.Show();


                }
                else
                {
                    MessageBox.Show(" No information");//If the fingerprint does not match you will not see any 
                                                       //information because  the GetImageDez() function in Adafruit code was declared "volatil int".
                                                       //bu note that the  system will not be open
                }
            }
            catch (TimeoutException)
            {

                throw;
            }
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}
    

