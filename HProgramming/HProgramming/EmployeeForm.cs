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
    //this code is simallar of patient form code .to see comment go to patients form to see
    public partial class EmployeeForm : Form
    {
        Employeesİnfomation employees = new Employeesİnfomation();
        int numberİd = 0; 
        public EmployeeForm()
        {
            InitializeComponent();
            centralcotrolledpanel.Visible = false;
            sendtodatabasebtn.Enabled = true;
            updatebtn.Enabled = false;
            Dalete.Enabled = false;
            DataFiller();
            birthdatepicker.Value = DateTime.Now;
            hirededatepicker.Value = DateTime.Now;
        }
        SqlConnection SqlConnect = new SqlConnection(@"Data Source=DESKTOP-FLN043B\CYBDRY;Initial Catalog=HospitalManagmentSyst;Integrated Security=True");
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            

        }
        //initialize textbox dropbox begin zone
        private void idempltextbox_OnValueChanged(object sender, EventArgs e)
        {
            Employeesİnfomation.personid = idempltextbox.Text.Trim();
        }

        private void firstnameempltextbox_OnValueChanged(object sender, EventArgs e)
        {
            employees.firstname = firstnameempltextbox.Text.Trim();
        }

        private void lsatnameempltextbox_OnValueChanged(object sender, EventArgs e)
        {
            employees.lastname = lastnameempltextbox.Text.Trim();
        }

        private void emailempltextbox_OnValueChanged(object sender, EventArgs e)
        {
            employees.email = emailempltextbox.Text.Trim();
        }

        private bool DateComtroller(DateTime date)
        {
            if (date > DateTime.Now)
            {
                return false;
            }
            else
                return true;
        }


        private bool BoxController()//empity textbox detctor function
        {
            if (string.IsNullOrEmpty(employees.firstname) || string.IsNullOrEmpty(employees.lastname) || string.IsNullOrEmpty(employees.phoneNumber) ||
                string.IsNullOrEmpty(employees.email)  || string.IsNullOrEmpty(Employeesİnfomation.address) ||
                string.IsNullOrEmpty(Employeesİnfomation.personid) || string.IsNullOrEmpty(employees.dailyrate) 
                )
            {
                return false;
            }
            else
                return true;
        }

        private void birthdatepicker_onValueChanged(object sender, EventArgs e)
        {
            if (employees.DateController(birthdatepicker.Value) == true)
            {
                employees.dateofBirth = birthdatepicker.Value;
            }
            else
            {
                MessageBox.Show("Check Valid Date Please");
            }


        }

        private void ssexempldropbox_onItemSelected(object sender, EventArgs e)
        {
            employees.sex = sexempldropbox.selectedValue.Trim();
        }

        private void phonenumbertextbox_OnValueChanged(object sender, EventArgs e)
        {
            employees.phoneNumber = phonenumbertextbox.Text.Trim();
        }

        private void civilstatusdropbox_onItemSelected(object sender, EventArgs e)
        {
            employees.civilstatus = civilstatusdropbox.selectedValue.Trim();
        }

        private void addresstextbox_TextChanged(object sender, EventArgs e)
        {
            Employeesİnfomation.address = addresstextbox.Text.Trim();
        }

        private void dailyratetextbox_OnValueChanged(object sender, EventArgs e)
        {
            employees.dailyrate = dailyratetextbox.Text.Trim();
        }

        private void paymethodetextbox_onItemSelected(object sender, EventArgs e)
        {
            employees.paymethode = paymethodetextbox.selectedValue.Trim();
        }

        private void positionbtext_onItemSelected(object sender, EventArgs e)
        {
            employees.position = positionbtext.selectedValue.Trim();
        }

        private void departmentdropbox_onItemSelected(object sender, EventArgs e)
        {
            employees.department = departmentdropbox.selectedValue.Trim();
        }

        private void hirededatepicker_onValueChanged(object sender, EventArgs e)
        {
            employees.datehired = hirededatepicker.Value;
        }

        private void workstatusdropbox_onItemSelected(object sender, EventArgs e)
        {
            employees.workstatus = workstatusdropbox.selectedValue.Trim();
        }

        private void sendtodatabasebtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (SqlConnect.State == ConnectionState.Closed)
                {
                    SqlConnect.Open();
                    SqlCommand sqlCom = new SqlCommand("AddOrUpdateEmployee", SqlConnect);
                    sqlCom.CommandType = CommandType.StoredProcedure;
                    sqlCom.Parameters.AddWithValue("@mode", "Send");
                    sqlCom.Parameters.AddWithValue("@Number", 0);
                    sqlCom.Parameters.AddWithValue("@EmployeeİD", Employeesİnfomation.personid);
                    sqlCom.Parameters.AddWithValue("@Firstname ", employees.firstname);
                    sqlCom.Parameters.AddWithValue("@Lastname", employees.lastname);
                    sqlCom.Parameters.AddWithValue("@Date_Of_Birth", employees.dateofBirth);
                    sqlCom.Parameters.AddWithValue("@Telephone_Number", employees.phoneNumber);
                    sqlCom.Parameters.AddWithValue("@Email ", employees.email);
                    sqlCom.Parameters.AddWithValue("@Sex", employees.sex);
                    sqlCom.Parameters.AddWithValue("@Civil_Status", employees.civilstatus);
                    sqlCom.Parameters.AddWithValue("@Position", employees.position);
                    sqlCom.Parameters.AddWithValue("@Department", employees.department);
                    sqlCom.Parameters.AddWithValue("@Work_Status", employees.workstatus);
                    sqlCom.Parameters.AddWithValue("@Date_Hired", employees.datehired);
                    sqlCom.Parameters.AddWithValue("@Pay_Methode", employees.paymethode);
                    sqlCom.Parameters.AddWithValue("@Daily_Rate", employees.dailyrate);
                    sqlCom.Parameters.AddWithValue("@_Address", Employeesİnfomation.address);


                    if (BoxController() == true)
                    {
                        sqlCom.ExecuteNonQuery();
                        MessageBox.Show("Employee Was Saved succesfully", "Success Message");
                        centralcotrolledpanel.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Fields required");
                        centralcotrolledpanel.Visible = false;
                    }


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
                centralcotrolledpanel.Visible = false;
            }

            finally
            {
                SqlConnect.Close();
            }
            DataFiller();
            
            

            //sendtodata
        }


        private void DataFiller()
        {
            try
            {



                if (SqlConnect.State == ConnectionState.Closed)
                {
                    SqlConnect.Open();

                    Employeesİnfomation.personid = searchtextbox.Text.Trim();

                    SqlDataAdapter sqlDataAdapt = new SqlDataAdapter("EmployeeSearch", SqlConnect);
                    sqlDataAdapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDataAdapt.SelectCommand.Parameters.AddWithValue("@EmployeeİD", Employeesİnfomation.personid);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapt.Fill(dataTable);
                    bunifuCustomDataGrid1.DataSource = dataTable;
                    bunifuCustomDataGrid1.Columns[0].Visible = false;


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                SqlConnect.Close();
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SqlConnect.State == ConnectionState.Closed)
                {
                    SqlConnect.Open();
                    SqlCommand sqlCom = new SqlCommand("AddOrUpdateEmployee", SqlConnect);
                    sqlCom.CommandType = CommandType.StoredProcedure;
                    sqlCom.Parameters.AddWithValue("@mode", "Update");
                    sqlCom.Parameters.AddWithValue("@Number", numberİd);
                    sqlCom.Parameters.AddWithValue("@EmployeeİD", Employeesİnfomation.personid);
                    sqlCom.Parameters.AddWithValue("@Firstname ", employees.firstname);
                    sqlCom.Parameters.AddWithValue("@Lastname", employees.lastname);
                    sqlCom.Parameters.AddWithValue("@Date_Of_Birth", employees.dateofBirth);
                    sqlCom.Parameters.AddWithValue("@Telephone_Number", employees.phoneNumber);
                    sqlCom.Parameters.AddWithValue("@Email ", employees.email);
                    sqlCom.Parameters.AddWithValue("@Sex", employees.sex);
                    sqlCom.Parameters.AddWithValue("@Civil_Status", employees.civilstatus);
                    sqlCom.Parameters.AddWithValue("@Position", employees.position);
                    sqlCom.Parameters.AddWithValue("@Department", employees.department);
                    sqlCom.Parameters.AddWithValue("@Work_Status", employees.workstatus);
                    sqlCom.Parameters.AddWithValue("@Date_Hired", employees.datehired);
                    sqlCom.Parameters.AddWithValue("@Pay_Methode", employees.paymethode);
                    sqlCom.Parameters.AddWithValue("@Daily_Rate", employees.dailyrate);
                    sqlCom.Parameters.AddWithValue("@_Address",Employeesİnfomation.address);
                    sqlCom.ExecuteNonQuery();
                    MessageBox.Show("Employee information Was Updated succesfully", "Sucess Message");
                    centralcotrolledpanel.Visible = true;
                    


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
                centralcotrolledpanel.Visible = false;
            }

            finally
            {
                SqlConnect.Close();
            }
            DataFiller();
            

        }

        private void Dalete_Click(object sender, EventArgs e)
        {
            try
            {
                if (SqlConnect.State == ConnectionState.Closed)
                {
                    SqlConnect.Open();
                    SqlCommand sqlcmd = new SqlCommand("EmployeeDelete", SqlConnect);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    sqlcmd.Parameters.AddWithValue("@Number", numberİd);

                    if (Dalete.Enabled ==true)
                    {
                        if (MessageBox.Show("Do you really want to delete this employee's information?", "Confirmation Messsage", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            sqlcmd.ExecuteNonQuery();
                            MessageBox.Show("Deleted sucessfully");
                            centralcotrolledpanel.Visible = true;
                        }
                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");

            }
            finally
            {
                SqlConnect.Close();
            }

            DataFiller();
            

            //delete operation
        }

        private void viewempllistbtn_Click(object sender, EventArgs e)
        {
            centralcotrolledpanel.Visible = true;
            DataFiller();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

            try
            {
                DataFiller();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
            //search bton
        }

        private void searchtextbox_OnValueChanged(object sender, EventArgs e)
        {
            //searchtext
        }

        private void addnewemplbtn_Click(object sender, EventArgs e)
        {
            centralcotrolledpanel.Visible = false;
            

            sendtodatabasebtn.Enabled = true;
            updatebtn.Enabled = false;
            Dalete.Enabled = false;
        }

        private void bunifuCustomDataGrid1_DoubleClick(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.CurrentRow.Index != -1)
            {
                numberİd = Convert.ToInt32(bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString());
                idempltextbox.Text= bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
                firstnameempltextbox.Text = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
                lastnameempltextbox.Text = bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString();
                birthdatepicker.Value= Convert.ToDateTime( bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString());
                phonenumbertextbox.Text = bunifuCustomDataGrid1.CurrentRow.Cells[5].Value.ToString();
                emailempltextbox.Text = bunifuCustomDataGrid1.CurrentRow.Cells[6].Value.ToString();
                hirededatepicker.Value = Convert.ToDateTime(bunifuCustomDataGrid1.CurrentRow.Cells[12].Value.ToString());
                dailyratetextbox.Text = bunifuCustomDataGrid1.CurrentRow.Cells[14].Value.ToString();
                addresstextbox.Text = bunifuCustomDataGrid1.CurrentRow.Cells[15].Value.ToString();


            }
            centralcotrolledpanel.Visible = false;
            sendtodatabasebtn.Enabled = false;
            updatebtn.Enabled = true;
            Dalete.Enabled = true;

        }

        private void idempltextbox_Enter(object sender, EventArgs e)
        {
            if(idempltextbox.Text== "Enter_Valid_İD")
            {
                idempltextbox.Text = "";
            }
        }

        private void idempltextbox_Leave(object sender, EventArgs e)
        {
            if (idempltextbox.Text == "")
            {
                idempltextbox.Text ="Enter_Valid_İD";
            }
        }

        private void emailempltextbox_Enter(object sender, EventArgs e)
        {
            if(emailempltextbox.Text== "Valid Email")
            {
                emailempltextbox.Text = "";
            }
        }

        private void emailempltextbox_Leave(object sender, EventArgs e)
        {
            if (emailempltextbox.Text == "")
            {
                emailempltextbox.Text = "Valid Email";
            }
        }

        private void firstnameempltextbox_Enter(object sender, EventArgs e)
        {
            if(firstnameempltextbox.Text== "firstname")
            {
               firstnameempltextbox.Text = "";
            }

        }

        private void firstnameempltextbox_Leave(object sender, EventArgs e)
        {
            if (firstnameempltextbox.Text == "")
            {
                firstnameempltextbox.Text = "firstname";
            }

        }

        private void lastnameempltextbox_Enter(object sender, EventArgs e)
        {
            if(lastnameempltextbox.Text== "lastname")
            {
                lastnameempltextbox.Text = "";
            }
        }

        private void lastnameempltextbox_Leave(object sender, EventArgs e)
        {
            if (lastnameempltextbox.Text == "")
            {
                lastnameempltextbox.Text = "lastname";
            }
        }

        private void dailyratetextbox_Enter(object sender, EventArgs e)
        {
            if(dailyratetextbox.Text== "Rate")
            {
                dailyratetextbox.Text = "";
            }
        }

        private void dailyratetextbox_Leave(object sender, EventArgs e)
        {
            if (dailyratetextbox.Text == "")
            {
                dailyratetextbox.Text = "Rate";
            }
        }

        private void addresstextbox_Enter(object sender, EventArgs e)
        {
            if(addresstextbox.Text== "Current Address")
            {
                addresstextbox.Text = "";
            }
        }

        private void addresstextbox_Leave(object sender, EventArgs e)
        {
            if (addresstextbox.Text == "")
            {
                addresstextbox.Text = "Current Address";
            }
        }

        private void phonenumbertextbox_Leave(object sender, EventArgs e)
        {
            if (phonenumbertextbox.Text == "")
            {
                phonenumbertextbox.Text = "Phone number";
            }
        }

        private void phonenumbertextbox_Enter(object sender, EventArgs e)
        {
            if(phonenumbertextbox.Text== "Phone number")
            {
                phonenumbertextbox.Text= "";
            }
        }
    }
}
