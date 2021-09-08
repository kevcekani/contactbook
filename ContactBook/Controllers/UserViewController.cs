using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ContactBook.Models;
using IdentitySample.Models;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.UI;

namespace ContactBook.Controllers
{
    public class UserViewController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: UserView
        public ActionResult Index(string searchString)
        {
            var contacts = from c in db.Contacts
                           select c;
            if (!String.IsNullOrEmpty(searchString))
            {
                contacts = contacts.Where(s => s.FirstName.Contains(searchString) || s.LastName.Contains(searchString) ||
                           s.Email.Contains(searchString) || s.Phone.Contains(searchString) || s.Address.Contains(searchString));
            }
            return View(contacts);
        }     
    }
}