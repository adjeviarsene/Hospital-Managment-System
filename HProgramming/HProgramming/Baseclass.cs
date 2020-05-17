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
namespace HProgramming
{
      abstract class Baseclass
     {
        private static string _id { get; set; }
        private string _firstname { get; set; }
        private string _lastname { get; set; }
        private DateTime _dateofbirth{ get; set; }
        private  string _phonenumber { get; set; }
        private static string _globaladdress { get; set; }
        private string _email { get; set; }

        private  string _sex { get; set; }


        public static string personid
        {
            get { return _id; }

            set { _id = value; }
        }
        public string firstname
        {
            get { return _firstname; }

            set {

               
                _firstname = value;
                
            
            }
        }
        public string lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        public DateTime dateofBirth
        {
            get { return _dateofbirth; }
            set { _dateofbirth = value; }
        }
        public   string phoneNumber
        {
            get { return _phonenumber; }
            set { _phonenumber = value; }
        }
        public static string address
        {
            get { return _globaladdress; }
            set { _globaladdress = value; }
        }
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
    }
}
