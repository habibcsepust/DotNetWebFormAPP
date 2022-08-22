using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DotNetWebFormAPP.Models;
using DotNetWebFormAPP.Controllers;
using System.Globalization;

namespace DotNetWebFormAPP.Views
{
    public partial class AddDoctor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveDoctor(object sender, EventArgs e)
        {

            string strDateTime = Request.Form["dob"];


            DoctorController doctorController = new DoctorController();
            Doctor doctor = new Doctor();
            doctor.d_name = textName.Text;
            doctor.d_contact = textContact.Text;
            doctor.d_email = textEmail.Text;
            
            //doctor.dob = Convert.ToDateTime(strDateTime.ToString());
            doctor.d_dateofbirth = DateTime.ParseExact(strDateTime, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //doctor.dob = Convert.ToDateTime(Dobirth.SelectedDate.ToShortDateString());


            doctorController.Add(doctor);
        }
    }
}