using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ToasterCutaway.Controllers.API
{
    public class PhotosController : ApiController
    {
        // GET /api/photos
        [HttpGet]
        public IEnumerable<Photo> GetPhotos()
        {
            const string category = "With famous people";
            var photos = new []
            {
                new { description = "", src = "/Content/Images/Photo/132.jpg"},
                new { description = "", src = "/Content/Images/Photo/2.jpg"},
                new { description = "", src = "/Content/Images/Photo/3.jpg"},
                new { description = "", src = "/Content/Images/Photo/4093500.jpg"},
                new { description = "", src = "/Content/Images/Photo/5.jpg"},
                new { description = "", src = "/Content/Images/Photo/52.jpg"},
                new { description = "", src = "/Content/Images/Photo/6 (2).jpg"},
                new { description = "", src = "/Content/Images/Photo/6.jpg"},
                new { description = "", src = "/Content/Images/Photo/76.jpg"},
                new { description = "", src = "/Content/Images/Photo/sv1.jpg"},
                new { description = "", src = "/Content/Images/Photo/foto2_1493.jpg"},
                new { description = "", src = "/Content/Images/Photo/Igor-Nikolaev.jpg"},
                new { description = "", src = "/Content/Images/Photo/images.jpg"},
                new { description = "", src = "/Content/Images/Photo/rt.jpg"},
                
            };

            return photos.Select(x => new Photo()
            {
                category = category,
                description = x.description,
                fullsrc = x.src,
                lowsrc = x.src
            }).ToList();
        }

        [HttpPost]
        public IHttpActionResult AddPhoto(Photo photo)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var p = new Photo();
            return Created(new Uri(Request.RequestUri + "/" + 11), p);
        }

        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
