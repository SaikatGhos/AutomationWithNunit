using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;
namespace OpenMRS
{
    class viewPatients:BaseMethods
    {
        public static void viewPatient(string patientName)
        {
            findApatient.findPatients(patientName);
            wait(2000);
            Click(propertype.Xpath, "(//*[@id='patient-search-results-table']//child::tr)[2]");
            wait(3000);
        }
    }
}
