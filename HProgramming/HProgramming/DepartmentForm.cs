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
    public partial class DepartmentForm : Form
    {

        
        public DepartmentForm()
        {
            InitializeComponent();
            departmentinfopanel.Hide();
            departslidepanel.Width = 586;

        }

        Departmentİnformation Department = new Departmentİnformation();//Create objet of Departmentinformation class



        private void departmentheadpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void departmentinfopanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void oncologydepbtn_Click(object sender, EventArgs e)
        {


            if (departslidepanel.Width == 487)//Controll the width of each panel or just resiz the panel if button was cliked
            {
                departslidepanel.Width = 586;
                departmentinfopanel.Visible = false;


            }
            else
            {
                departslidepanel.Width = 487;
                departmentinfopanel.Visible = true;
                try
                {
                    bool depinfo = Department.GetDepartmentinfo(1);//set the primary key like parameter to find our department info
                    if (depinfo == true)
                    {
                        depname.Text = Department.firstname;
                        roomnumber.Text = Department.roomnumber;
                        floornum.Text = Departmentİnformation.floonumber;
                        currentmachine.Text = Department.activemachine;
                        depaaddress.Text = Department.location;
                        doctornumlabel.Text = Department.numberofdoctor;
                        nursenum.Text = Department.numberofnurse;
                        patientnumlabel.Text = Department.numberofpatient;

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error Message");
                }

            }








        }

        private void departslidepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nuerologydepbtn_Click(object sender, EventArgs e)
        {

            if (departslidepanel.Width == 487)//just resiz the panel if button was cliked
            {
                departslidepanel.Width = 586;
                departmentinfopanel.Visible = false;


            }
            else
            {
                departslidepanel.Width = 487;
                departmentinfopanel.Visible = true;
                try
                {
                    bool depinfo = Department.GetDepartmentinfo(2);///set the primary key like parameter to find our department info
                    if (depinfo == true)
                    {
                        depname.Text = Department.firstname;
                        roomnumber.Text = Department.roomnumber;
                        floornum.Text = Departmentİnformation.floonumber;
                        currentmachine.Text = Department.activemachine;
                        depaaddress.Text = Department.location;
                        doctornumlabel.Text = Department.numberofdoctor;
                        nursenum.Text = Department.numberofnurse;
                        patientnumlabel.Text = Department.numberofpatient;

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error Message");
                }

            }
        }

        private void hematdepabtn_Click(object sender, EventArgs e)
        {
            if (departslidepanel.Width == 487)//just resiz the panel if button was cliked
            {
                departslidepanel.Width = 586;
                departmentinfopanel.Visible = false;


            }
            else
            {
                departslidepanel.Width = 487;
                departmentinfopanel.Visible = true;
                try
                {
                    bool depinfo = Department.GetDepartmentinfo(3);///set the primary key like parameter to find our department info
                    if (depinfo == true)
                    {
                        depname.Text = Department.firstname;
                        roomnumber.Text = Department.roomnumber;
                        floornum.Text = Departmentİnformation.floonumber;
                        currentmachine.Text = Department.activemachine;
                        depaaddress.Text = Department.location;
                        doctornumlabel.Text = Department.numberofdoctor;
                        nursenum.Text = Department.numberofnurse;
                        patientnumlabel.Text = Department.numberofpatient;

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error Message");
                }

            }
        }

        private void chirurgydeptbtn_Click(object sender, EventArgs e)
        {
            if (departslidepanel.Width == 487)//just resiz the panel if button was cliked
            {
                departslidepanel.Width = 586;
                departmentinfopanel.Visible = false;


            }
            else
            {
                departslidepanel.Width = 487;
                departmentinfopanel.Visible = true;
                try
                {
                    bool depinfo = Department.GetDepartmentinfo(4);//set the primary key like parameter to find our department info
                    if (depinfo == true)
                    {
                        depname.Text = Department.firstname;
                        roomnumber.Text = Department.roomnumber;
                        floornum.Text = Departmentİnformation.floonumber;
                        currentmachine.Text = Department.activemachine;
                        depaaddress.Text = Department.location;
                        doctornumlabel.Text = Department.numberofdoctor;
                        nursenum.Text = Department.numberofnurse;
                        patientnumlabel.Text = Department.numberofpatient;

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error Message");
                }
            }
        }

        private void toxicolgydepbtn_Click(object sender, EventArgs e)
        {
            if (departslidepanel.Width == 487)
            {
                departslidepanel.Width = 586;
                departmentinfopanel.Visible = false;


            }
            else
            {
                departslidepanel.Width = 487;
                departmentinfopanel.Visible = true;
                try
                {
                    bool depinfo = Department.GetDepartmentinfo(5);//set the primary key like parameter to find our department info
                    if (depinfo == true)
                    {
                        depname.Text = Department.firstname;
                        roomnumber.Text = Department.roomnumber;
                        floornum.Text = Departmentİnformation.floonumber;
                        currentmachine.Text = Department.activemachine;
                        depaaddress.Text = Department.location;
                        doctornumlabel.Text = Department.numberofdoctor;
                        nursenum.Text = Department.numberofnurse;
                        patientnumlabel.Text = Department.numberofpatient;

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error Message");
                }
            }
        }

        private void infectiondisdepabtn_Click(object sender, EventArgs e)
        {
            if (departslidepanel.Width == 487)
            {
                departslidepanel.Width = 586;
                departmentinfopanel.Visible = false;


            }
            else
            {
                departslidepanel.Width = 487;
                departmentinfopanel.Visible = true;
                try
                {
                    bool depinfo = Department.GetDepartmentinfo(6);//set the primary key like parameter to find our department info
                    if (depinfo == true)
                    {
                        depname.Text = Department.firstname;
                        roomnumber.Text = Department.roomnumber;
                        floornum.Text = Departmentİnformation.floonumber;
                        currentmachine.Text = Department.activemachine;
                        depaaddress.Text = Department.location;
                        doctornumlabel.Text = Department.numberofdoctor;
                        nursenum.Text = Department.numberofnurse;
                        patientnumlabel.Text = Department.numberofpatient;

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error Message");
                }
            }
        }
    }
}
