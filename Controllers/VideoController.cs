using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data;
using System.Data.SqlClient;

using MVCPlantilla41.Utilerias;



namespace MvcPlantilla.Controllers
{
    public class VideoController : Controller
    {
        //
   //Get:/video/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Vervideo()
        {
            //consultar la info en la bd
            ViewData["video"] = BaseHelper.ejecutarConsulta(
                  "Select * from video",
                  CommandType.Text);

            return View();
        }
    [HttpPost]
        public ActionResult AgregarVideo()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideos", idVideos));
            parametros.Add(new SqlParameter("@Titulo", Titulo));
            parametros.Add(new SqlParameter("@NumReproducciones", NumReproducciones));
            parametros.Add(new SqlParameter("@Url", Url));
            BaseHelper.ejecutarSentencia("INSERT INTO Video " + "VALUES(@idVideos, @Titulo,@NumReproducciones, @Url)"
            , CommandType.Text, parametros);
            

            return View("Mensaje");
        }

    public ActionResult EliminarVideo()
    {
        List<SqlParameter> parametros = new List<SqlParameter>();
        parametros.Add(new SqlParameter("@idVideos", idVideos));
        BaseHelper.ejecutarSentencia("Delete From Video where idVideos=@idVideos", CommandType.Text, parametros);
      

        return View();
    }

    public ActionResult ActualizarVideo()
    {
        List<SqlParameter> parametros = new List<SqlParameter>();
        parametros.Add(new SqlParameter("@idVideos", idVideos));
        parametros.Add(new SqlParameter("@Titulo", Titulo));
        parametros.Add(new SqlParameter("@NumReproducciones", NumReproducciones));
        parametros.Add(new SqlParameter("@Url", Url));
        BaseHelper.ejecutarSentencia("Update  Video" + "set(@idVideos, @Titulo,@NumReproducciones, @Url) Where idVideos=@idVideos", CommandType.Text, parametros);
        return View();
    }


    }
    }
