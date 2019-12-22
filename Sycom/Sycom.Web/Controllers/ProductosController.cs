using Sycom.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sycom.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();
            var ListadeProductos = productosBL.ObtenerProductos();

            return View(ListadeProductos);
        }
    }
}