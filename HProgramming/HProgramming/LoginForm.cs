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
using System.Data;
using System.Data.SqlClient;

namespace HProgramming
{
   
    public partial class LoginForm : Form
    {
        SqlConnection SqlConnect = new SqlConnection(@"Data Source=DESKTOP-FLN043B\CYBDRY;Initial Catalog=HospitalManagmentSyst;Integrated Security=True");//sqlconncetioncetion string and sqlconnection object
       
        public LoginForm()
        {
            InitializeComponent();
            panelload.Visible = false;
            circleprogress.Value = 0;
            circleprogressloading.MaxValue = 100;
            
        }
        

        private bool ProgressCircle()//we use this function for animate the ProgressCircle  once the button login is clicked.For this we can use also timer function
        {

            for(int i = 0; i <= 100; i++)
            {
                circleprogress.Value = i;
                System.Threading.Thread.Sleep(100);
                circleprogress.Update();
            }

            if (circleprogress.Value == 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void gradientpanellog_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
           panelload.Visible = true;
            
            
            try
            {
                if (SqlConnect.State == ConnectionState.Closed)
                {
                    SqlConnect.Open();
                    string myquery = "SELECT * FROM Login_table WHERE Username='" + usernametextbox.Text.Trim() + "'AND Password='" + passwordtextbox.Text.Trim()+"'";//I personally do not like this technique because a lot of  concatenation is equal to higth  sql injection vulnerability.
                    /*Datatable name is Login_table
                     * 
                       It is only to show that this technique also exists.
                     */
                    SqlDataAdapter sqlDataAdapt = new SqlDataAdapter(myquery, SqlConnect);
                    DataTable dataTab = new DataTable();
                    sqlDataAdapt.Fill(dataTab);


                    if (ProgressCircle() == true)
                    {
                        
                        if (dataTab.Rows.Count == 1)// if the information corresponds to a row in our data table
                        {

                            Form1 form1 = new Form1();
                            this.Hide();
                            form1.Show();

                            
                        }
                        else
                        {
                            MessageBox.Show("Your Username or Your password is wrong  ");
                        }
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error message");
            }
            finally
            {
                SqlConnect.Close();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)//Exit button clik event
        {
            if(MessageBox.Show("Do you Want to Exit?","Cancel Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }
        #region Enter end leave event begin zone
        private void usernametextbox_Enter(object sender, EventArgs e)
        {
            if(usernametextbox.Text== "Username")
            {
                usernametextbox.Text = "";
            }
        }

        private void usernametextbox_Leave(object sender, EventArgs e)
        {
            if (usernametextbox.Text == "")
            {
                usernametextbox.Text = "Username";
            }
        }

        private void passwordtextbox_Enter(object sender, EventArgs e)
        {
            if(passwordtextbox.Text== "Password")
            {
                passwordtextbox.Text = "";
            }
        }

        private void passwordtextbox_Leave(object sender, EventArgs e)
        {
            if (passwordtextbox.Text == "")
            {
                passwordtextbox.Text = "Password";
            }
        }
        #endregion enter and leave end zone
        #region information
        private void loginbyfingerprint_Click(object sender, EventArgs e)
        {
            Fingerprint fingerprin = new Fingerprint();
            fingerprin.Show();
        }
        #endregion end information
    }
}
