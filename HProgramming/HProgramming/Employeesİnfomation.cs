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
    class Employeesİnfomation:Baseclass //İheritance
    {
        private string _civilstatus { get; set; }
        private string _position { get; set; }
  
        private string _paymethode { get; set; }
        
        private string _department { get; set; }
        private string _workstatus { get; set; }
        private DateTime _datehired { get; set; }
        private string _dailyrate { get; set; }

        public string civilstatus
        {
            get { return _civilstatus; }
            set { _civilstatus = value; }
        }
        public string position
        {
            get { return _position; }
            set { _position = value; }
        }
        public string paymethode
        {
            get { return _paymethode; }
            set { _paymethode = value; }
        }
        public string department
        {
            get { return _department; }
            set { _department = value; }
        }
        public string workstatus
        {
            get { return _workstatus; }
            set { _workstatus = value; }
        }
        public DateTime datehired
        {
            get { return _datehired; }
            set { _datehired = value; }
        }
        public string dailyrate
        {
            get { return _dailyrate; }
            set { _dailyrate = value; }
        }

        public bool DateController(DateTime dateTime)
        {
            if (dateTime.Day > DateTime.Now.Day)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

}
