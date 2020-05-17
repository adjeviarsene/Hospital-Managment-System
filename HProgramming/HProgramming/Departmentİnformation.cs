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
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HProgramming
{
     class Departmentİnformation:Baseclass//inheritance
    {
       private static string _floonumber { get; set; }
       private  string  _roomnumber { get; set; }
       private string _location { get; set; }
       private string _bednumber { get; set; }
       private string _activemachine { get; set; }
       private string _numberofdoctor { get; set; }
       private string _numberofnurse { get; set; }
       private string _numberofpatient { get; set; }
       
        public static string floonumber
        {
            get { return _floonumber; }
            set { _floonumber = value; }
        }
        public string roomnumber
        {
            get { return _roomnumber; }
            set { _roomnumber = value; }

        }
        public string numberofdoctor
        {
            get { return _numberofdoctor; }
            set { _numberofdoctor = value; }
        }
        
        public string location
        {
            get { return _location; }
            set { _location = value; }
        }  
        public string bednumber
        {
            get { return _bednumber; }
            set { _bednumber = value; }
        }
        public string activemachine
        {
            get { return _activemachine; }
            set { _activemachine = value; }
        }
        public string numberofnurse
        {
            get { return _numberofnurse; }
            set { _numberofnurse = value; }
        }
        public string numberofpatient
        {
            get { return _numberofpatient; }
            set { _numberofpatient = value; }
        }

        SqlConnection sqlconnect;
        SqlCommand command;
        public Departmentİnformation()//Property to link our sql server
        {
            sqlconnect = new SqlConnection();
            sqlconnect.ConnectionString = @"Data Source=DESKTOP-FLN043B\CYBDRY;Initial Catalog=HospitalManagmentSyst;Integrated Security=True";
            
        }
        public bool GetDepartmentinfo( int number)//now let writte the code to select each row to our Department_table
        {
            bool returnvalue = false;
            try
            {
                if (sqlconnect.State == ConnectionState.Closed)//Check the connection
                {
                    
                    command=new SqlCommand("SELECT * FROM Department_table WHERE Num=@Num  ",sqlconnect);//we will find each row by primary key
                    command.Parameters.Add("@Num", SqlDbType.Int);
                    command.Parameters["@Num"].Value = number;
                    sqlconnect.Open();

                    using (SqlDataReader reader = command.ExecuteReader())//now execute the reader and find each colums itemvalue
                    {
                        while (reader.Read())
                        {
                            firstname = (reader["Name"].ToString());
                            roomnumber = (reader["Room_number"].ToString());
                            floonumber = (reader["Floor_number"].ToString());
                            location = (reader["Address"].ToString());
                            numberofdoctor = (reader["Number_of_doctor"].ToString());
                            activemachine = (reader["Current_Machine"].ToString());
                            numberofnurse = (reader["Number_of_nurse"].ToString());
                            numberofpatient = (reader["Number_of_patients"].ToString());

                        }
                    }
                     returnvalue= true;
                    


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                
            }
            finally
            {
                sqlconnect.Close();//Close our server
            }
            return returnvalue;
        }


    }
   
}
