using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetWebFormAPP.Models;

namespace DotNetWebFormAPP.Controllers
{
    public class DoctorController : Controller
    {
        //private string connectionstring = ConfigurationManager.ConnectionStrings["DbContext"].ConnectionString;

        string connectionstring = @"Server = DESKTOP-G004QAU; Database = clinicalmanagementsystem;
                Integrated Security = true; TrustServerCertificate=True";

        // GET: Doctor
        public ActionResult Add(Doctor doctor)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {

                SqlCommand cmd = new SqlCommand("sp_insert_doctor", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@d_name", SqlDbType.NVarChar, 50).Value = doctor.d_name;
                cmd.Parameters.Add("@d_contact", SqlDbType.NVarChar, 50).Value = doctor.d_contact;
                cmd.Parameters.Add("@d_email", SqlDbType.NVarChar, 50).Value = doctor.d_email;
                cmd.Parameters.Add("@d_dateofbirth", SqlDbType.DateTime).Value = doctor.d_dateofbirth;

                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                conn.Close();
            }


            return View("AddDoctor");
        }
    }
}