using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleContactUsApp.Data.Model;
using SampleContactUsApp.Repository;
namespace SampleContactUsApp.Services
{
    public class ContactServices : IContactUsService
    {
        public void SaveData(ContactUsModel contactUsForm)
        {
            string file = System.Web.HttpContext.Current.Server.MapPath("~/Temp/Sampleapp.txt");

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(file))
            {
                writer.WriteLine("FirstName :" + contactUsForm.FirstName + "\r\n" + "LastName :" + contactUsForm.LastName + "\r\n" + "Email :" + contactUsForm.Email + "\r\n" + "Message :" + contactUsForm.Message);

            }
        }
    }
}
