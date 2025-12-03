using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Solution.DAL
{
    internal class PatientRepository
    {
        
        public static int addPatient(string name, string gender, DateTime DOB, string phone, bool cb1, bool cb2, bool cb3, bool cb4, bool cb5, bool cb6, bool cb7, bool cb8, bool cb9, bool cb10, string email = null, string address = null, string bloodGroup = null, string medicalHistory = null, string allergies = null, string emcyContactName = null, string emcyContactPhone = null)
        {
            HMSDataContext db = new HMSDataContext();

            int result = db.insertIntoPatient(name, gender, DOB, phone, email, address, bloodGroup, medicalHistory, allergies, emcyContactName, emcyContactPhone, cb1, cb2, cb3, cb4, cb5, cb6, cb7, cb8, cb9, cb10);
            
            db.SubmitChanges(); 

            return result; // Just called the SP and return its value from result
        }

        public static int updatePatient(string patientID, string name, string gender, DateTime DOB, string phone, bool cb1, bool cb2, bool cb3, bool cb4, bool cb5, bool cb6, bool cb7, bool cb8, bool cb9, bool cb10, string email = null, string address = null, string bloodGroup = null, string medicalHistory = null, string allergies = null, string emcyContactName = null, string emcyContactPhone = null)
        {
            HMSDataContext db = new HMSDataContext();

            int result = db.updatePatients(int.Parse(patientID), name, gender, DOB, phone, email, address, bloodGroup, medicalHistory, allergies, emcyContactName, emcyContactPhone, cb1, cb2, cb3, cb4, cb5, cb6, cb7, cb8, cb9, cb10); 

            db.SubmitChanges();
            
            return result; // Just called the SP and return its value from result
        }

        public static List<searchPatientsWithDetailsResult> searchPatient(string name, string phone)
        {
            HMSDataContext db = new HMSDataContext();

            var rawResult = db.searchPatientsWithDetails(name, phone).ToList();
            
            return rawResult;

        }

        public static int deletePatient(int ID)
        {
            HMSDataContext db = new HMSDataContext();
            return db.deletePatient(ID);
        }

        public static List<viewAllPatientsResult> getAllPatients()
        {
            HMSDataContext db = new HMSDataContext();

            List<viewAllPatientsResult> allPatients = db.viewAllPatients().ToList();

            return allPatients;
        }
    }
}
