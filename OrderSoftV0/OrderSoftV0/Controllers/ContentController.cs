using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderSoftV0.Models;

namespace OrderSoftV0.Controllers
{
    public class ContentController : Controller
    {
        SqlConnection connection = new SqlConnection("server=LAPTOP-5PQE6DUI\\SQLEXPRESS; database=OrderSoft; user=LAPTOP-5PQE6DUI\\estev; password=; integrated security = true");
        public ActionResult Menu()
        {
            string result = "";
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select top 1 nombre from dbo.plato;", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        result = reader.GetString(i);
                        i++;
                    }
                    ViewBag.Message = result + "-";
                }
                else
                {
                    ViewBag.Message = "No trae información";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Problemas de conexión - " + ex.Message;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return View();
        }

        [HttpGet]
        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registro(Registro r)
        {
            return View();
        }
    }

}