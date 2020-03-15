using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;

using MvcPlantilla.Utilerias;
	
		 


namespace MvcPlantilla.Controllers
{
    public class VideoController : Controller
    {
        //
   //Get:/video/

        public ActionResult Index()
        {

 ViewData["video"] = BaseHelper.EjecutarConsulta("Select * from video",CommandType.Text);

            return View();
        }

        public ActionResult Create()
        {

            return View();

        }

        [HttpPost]

        public ActionResult Create(int idVideo, string titulo, int Repro, string Url)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@idVideo", idVideo));

            parametros.Add(new SqlParameter("@titulo", titulo));

            parametros.Add(new SqlParameter("@Repro", Repro));

            parametros.Add(new SqlParameter("@Url", Url));

            BaseHelper.EjecutarSentencia("INSERT into Video values (@idVideo,@titulo,@Repro, @Url)", CommandType.Text, parametros);

            return View();

        }

        public ActionResult Delete()
        {

            return View();

        }

        [HttpPost]

        public ActionResult Delete(int idVideo)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@idVideo", idVideo));

            BaseHelper.EjecutarSentencia("Delete from Video Where @idVideo=idVideo", CommandType.Text, parametros);

            return View();

        }

        public ActionResult Update()
        {

            return View();

        }

        [HttpPost]

        public ActionResult Update(int idVideo, string titulo, int Repro, string Url)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@idVideo", idVideo));

            parametros.Add(new SqlParameter("@titulo", titulo));

            parametros.Add(new SqlParameter("@Repro", Repro));

            parametros.Add(new SqlParameter("@Url", Url));

            BaseHelper.EjecutarSentencia("UPDATE SET @idVideo=idVideo,@titulo=tiulo,@Repro=Repro, @Url=Url  Where @idVideo=idVideo", CommandType.Text, parametros);

            return View();

        }

    }

}