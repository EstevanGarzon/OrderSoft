using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderSoftV0.Models;

namespace OrderSoftV0.Controllers
{
    public class HomeController : Controller
    {
        SqlConnection connection = new SqlConnection("server=LAPTOP-5PQE6DUI\\SQLEXPRESS; database=OrderSoft; user=LAPTOP-5PQE6DUI\\estev; password=; integrated security = true");

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Index i)
        {
            string psw = "";
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select psw from dbo.view_usuarios where cedula="+i.user+";", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        psw = reader.GetString(0);
                        ViewBag.nombre = reader.GetString(0);
                    }
                }
                else
                {
                    ViewBag.Message = "No trae información";
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                ViewBag.Message = "Problemas de conexión - "+ex.Message;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            if (ModelState.IsValid )
            {
                if (psw.Equals(i.password))
                {
                    return Redirect("~/Content/Menu");
                }
                else
                {
                    ViewBag.Message = "Creenciales incorrectas.";
                    return View();
                }
            }
            else
            {
                ViewBag.Message = "Los campos está mal.";
                return View();
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return Redirect("~/Content/Menu");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}