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
using System.Runtime.InteropServices;

namespace HProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]//this is our drag event funtion .We can only use bunifudragcontrol 
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void closebtn_Click(object sender, EventArgs e)//Logaout confirmation
        {
            try
            {
                if (MessageBox.Show("Do you Want to Log Out?" ,"Log Out Confirmation",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void minimazormximazbtn_Click(object sender, EventArgs e)//minimiz or maximaz our windows form
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState =FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                
            }
        }

        private void hiddenbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void headpanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);//We call our dragcontrol function to drag our windown form by the headerpanel
        }
        private void AddFormInPanel(Form formx)//Display Other added form inside the principal form
        {
            formx.TopLevel = false;
            formx.FormBorderStyle = FormBorderStyle.None;
            formx.Dock = DockStyle.Fill;
            centralpanal.Controls.Add(formx);
            centralpanal.Size = formx.Size;
            
            centralpanal.Tag = formx;
            formx.BringToFront();
            formx.Show();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Dashboardform());//if this button is clicked Dashboard form will be open
            titlepanel.Visible = false;
            
        }

        private void patientsbtn_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new PatientsForm());//open patients form
            titlepanel.Visible = false;
        }

        private void appointmentbtn_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Appointmentform());//open Appointment form
            titlepanel.Visible = false;
        }

        private void departmentbtn_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new DepartmentForm());//open Department form
            titlepanel.Visible = false;
        }

        private void emploiyeesbtn_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new EmployeeForm());//Open Employeees form
            titlepanel.Visible = false;
        }
       

        
    }
}
