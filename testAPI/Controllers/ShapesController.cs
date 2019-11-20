using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using testAPI.Models;

namespace testAPI.Controllers
{
    public class ShapesController : ApiController
    {
        Shape[] shapes = new Shape[] {
            new Shape { Id = 1, Name = "Square"},
            new Shape { Id = 2, Name = "Circle"},
            new Shape { Id = 3, Name = "Rectangle"}
        };

        public IHttpActionResult GetProduct(int id)
        {
            var shape = shapes.FirstOrDefault((p) => p.Id == id);
            if (shape == null)
            {
                return NotFound();
            }
            return Ok(shape);
        }
    }
}
