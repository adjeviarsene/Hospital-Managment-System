using System;
using System.Windows.Forms;


namespace HProgramming
{
    class Appointmentİnformation : Employeesİnfomation { 
        private DateTime _appointmentdate { get; set; }
        private string _doctorname { get; set; }
        private string _appoitmenttime { get; set; }

        public DateTime appointmentdate
        {
            get { return _appointmentdate; }
            set { _appointmentdate = value; }
        }
        public string doctorname
        {
            get { return _doctorname; }
            set
            {
                if (string.IsNullOrEmpty(_doctorname))
                {
                    MessageBox.Show("Null");


                }
                else
                {
                    _doctorname = _doctorname.Substring(0, 20);
                }
                _doctorname = value;
            }
        }
        public string appoitmenttime
        {
            get { return _appoitmenttime; }
            set { _appoitmenttime = value; }
        }
    }
}
