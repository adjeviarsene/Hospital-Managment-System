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

using System;
using System.Windows.Forms;

namespace HProgramming
{
    public partial class Dashboardform : Form
    {
        public Dashboardform()
        {
            InitializeComponent();
        }

        Timer timer = new Timer();
        

        void CurrentTime(object sender, EventArgs e)//This function will dipaly the currrent time
        {
            int hours = DateTime.Now.Hour;
            int minutes = DateTime.Now.Minute;
            int second = DateTime.Now.Second;
            
            

            string time1 = "";
            string time2 = "";

            if (hours < 10)
            {
                time1 += "0" + hours;
            }
            else {
                time1 += hours;
            }
            time1 += ":";
            if (minutes < 10)
            {
                time1 += "0" + minutes;
            }
            else
            {
                time1 += minutes;
            }
            

            if (second < 10)
            {
                time2 += "0" + second;
            }
            else
            {
                time2 += second;
            }
            timelabeltxt.Text = time1;
            labelsecond.Text = time2;

            labelday.Text = DateTime.Now.ToString("dddd");
            labellongdate.Text = DateTime.Now.ToString("MM dd yyyy");
                
        }

        private void Dashboardform_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;//1000 milisecond =1 second
            timer.Tick += new EventHandler(this.CurrentTime);
            timer.Start();

        }
    }
}
