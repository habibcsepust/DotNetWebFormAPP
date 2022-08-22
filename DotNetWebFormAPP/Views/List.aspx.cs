using DotNetWebFormAPP.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetWebFormAPP.Views
{
    public partial class List : System.Web.UI.Page
    {
        public DataTable arrNames = new DataTable();
        public string strName = "Sudipto Sarker";
        protected void Page_Load(object sender, EventArgs e)
        {
            //DoctorController doctorController = new DoctorController();
            //doctorController.DisplayAll();

            string connectionstring = @"Server = DESKTOP-G004QAU; Database = clinicalmanagementsystem;
                Integrated Security = true; TrustServerCertificate=True";

            SqlConnection conn = new SqlConnection(connectionstring);
            strName = "Azhar";
            try
            {

                using (var cmd = new SqlCommand("SP_Pull_Data", conn))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.Fill(arrNames);
                }

                //foreach (DataRow row in arrNames.Rows)
                //{
                //    Response.Write("<br>Name is: " + row["d_name"].ToString());
                //}


                //cmd.CommandType = CommandType.StoredProcedure;


                //conn.Open();
                //SqlDataReader dr = cmd.ExecuteReader();


                ////dr.Read();

                //DataTable dt = new DataTable();
                //dt.Columns.AddRange(new DataColumn[5]{ 
                //    new DataColumn("Id", typeof(int)),
                //    new DataColumn("Name", typeof(string)),
                //    new DataColumn("Contact",typeof(string)),
                //    new DataColumn("Email",typeof(string)),
                //    new DataColumn("Birthday",typeof(string))
                //});

                //int x = 0;
                //while (dr.Read()) {
                //    x = x + 1;
                //    dt.Rows.Add(x, dr["d_name"], dr["d_contact"], dr["d_email"], dr["d_dateofbirth"]);
                //    //Response.Write("Name: " + dr["d_name"] + "<br>Email: " + dr["d_email"]);
                //}

                //StringBuilder sb = new StringBuilder();

                //sb.Append("<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:Arial'>");

                //sb.Append("<tr>");
                //foreach (DataColumn column in dt.Columns)
                //{
                //    sb.Append("<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + column.ColumnName + "</th>");
                //}
                //sb.Append("</tr>");


                //foreach (DataRow row in dt.Rows)
                //{
                //    sb.Append("<tr>");
                //    foreach (DataColumn column in dt.Columns)
                //    {
                //        sb.Append("<td style='width:100px;border: 1px solid #ccc'>" + row[column.ColumnName].ToString() + "</td>");
                //    }
                //    sb.Append("</tr>");
                //}

                //Table end.
                //sb.Append("</table>");
                //Literal1.Text = sb.ToString();
                //Response.Write(sb.ToString());
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                conn.Close();
            }
        }
    }
}