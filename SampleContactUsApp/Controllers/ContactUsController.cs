using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleContactUsApp.Models;
using SampleContactUsApp.Services;
using SampleContactUsApp.Repository;
using SampleContactUsApp.Data.Model;
using AutoMapper;
namespace SampleContactUsApp.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: ContactUs
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Create ContactUsForm View.
        /// </summary>
        /// <returns></returns>
        public ActionResult ContactSave()
        {
            return View();
        }
        /// <summary>
        /// Save ContactUsForm information.
        /// </summary>
        /// <param name="contactUsForm"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ContactSave(ContactUsFormViewModel contactUsForm)
        {
            if (ModelState.IsValid)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<ContactUsFormViewModel, ContactUsForm>());
                var mapper = new Mapper(config);
                ContactServices services = new ContactServices();

                var contactDTO = mapper.Map<ContactUsFormViewModel, ContactUsForm>(contactUsForm);
                services.SaveData(contactDTO);
                TempData["message"] = "ContactUs Data Saved Successfully";
                ModelState.Clear();
                return View();
            }
            else
            {
                return View(contactUsForm);
            }
        }


    }
}