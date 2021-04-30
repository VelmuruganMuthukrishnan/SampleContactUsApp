using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleContactUsApp.Data.Model;
namespace SampleContactUsApp.Repository
{
    public interface IContactUsForm
    {
        void SaveData(ContactUsForm contactUsForm);
    }
}
