using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mobilerush.Web.Controllers
{
    /// <summary>
    /// Display Error Pages
    /// </summary>
    [Route("Error")]
    public class ErrorController : Controller
    {

        /// <summary>
        /// Used for authorization errors
        /// </summary>
        /// <returns>
        /// An <see cref="ActionResult" /> encapsulating a 403 error
        /// </returns>
        [Route("Error/Forbidden")]
        public ActionResult Forbidden()
        {
            this.Response.StatusCode = 403;

            return this.View();
        }

        /// <summary>
        /// Used for not found errors
        /// </summary>
        /// <returns>
        /// An <see cref="ActionResult" /> encapsulating a 404 error
        /// </returns>
        [Route("Error/NotFound")]
        public ActionResult NotFound()
        {
            this.Response.StatusCode = 404;

            return this.View();
        }

        /// <summary>
        /// Used for unspecified errors
        /// </summary>
        /// <param name="code">
        /// The error code (defaults to 500)
        /// </param>
        /// <returns>
        /// An <see cref="ActionResult" /> encapsulating an unspecified error
        /// </returns>
        [Route("Error")]
        public ActionResult Error(int? code)
        {
            this.Response.StatusCode = code ?? 500;

            return this.View();
        }

    }
}