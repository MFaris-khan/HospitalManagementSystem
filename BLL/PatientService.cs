using HMS_Solution.DAL;
using HMS_Solution.Forms.PatientForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HMS_Solution.BLL
{
    internal class PatientService
    {
        public static bool ValidateDetails(string name, string gender, string phone) // General function to check input values from textboxes
        {
            if (name.Length < 3)
            {
                throw new ArgumentException("Names cannot be lass than 3 characters");
            }
            if (gender != "male" && gender != "female" && gender != "other")
            {
                throw new ArgumentException("Unknown gender. Please select valid gender");
            }
            if (phone.Length < 11)
            {
                throw new ArgumentException("Invalid phone number.");
            }

            return true;
        }

        public static int ValidateAddPatient(string name, string gender, DateTime DOB, string phone, bool cb1, bool cb2, bool cb3, bool cb4, bool cb5, bool cb6, bool cb7, bool cb8, bool cb9, bool cb10, string email=null, string address = null, string bloodGroup = null, string medicalHistory = null, string allergies = null, string emcyContactName = null, string emcyContactPhone = null)
        {
            if (ValidateDetails(name, gender, phone))
            {   
                // calling another function which will call Stored procedure and return the value from the DB which will return to UI
                return PatientRepository.addPatient(name, gender, DOB, phone, cb1, cb2, cb3, cb4, cb5, cb6, cb7, cb8, cb9, cb10, email, address, bloodGroup, medicalHistory, allergies, emcyContactName, emcyContactPhone);
            }

            return -1; // if something unexpected happens
        }

        public static int ValidateUpdatePatient(string patientID, string name, string gender, DateTime DOB, string phone, bool cb1, bool cb2, bool cb3, bool cb4, bool cb5, bool cb6, bool cb7, bool cb8, bool cb9, bool cb10, string email = null, string address = null, string bloodGroup = null, string medicalHistory = null, string allergies = null, string emcyContactName = null, string emcyContactPhone = null)
        {
           if(ValidateDetails(name, gender, phone))
           {
                // calling another function which will call Stored procedure and return the value from the DB which will return to UI
                return PatientRepository.updatePatient(patientID, name, gender, DOB, phone, cb1, cb2, cb3, cb4, cb5, cb6, cb7, cb8, cb9, cb10, email, address, bloodGroup, medicalHistory, allergies, emcyContactName, emcyContactPhone);
           }

            return -1; // if something unexpected happens
        }

        public static List<searchPatientsWithDetailsResult> validateSearchDetails(string searchName, string searchPhone)
        { 
            // Checking if any parameter is empty so initialize with null then pass to DAL -> DB
            string name     = string.IsNullOrWhiteSpace(searchName) ? null : searchName;
            string phone    = string.IsNullOrWhiteSpace(searchPhone) ? null : searchPhone;

            return PatientRepository.searchPatient(name, phone);
        }

        public static int validatePatientID(string patientID)
        {

            if ( !(int.TryParse(patientID, out int ID) && ID > 0 && ID < int.MaxValue) )
            {
                throw new FormatException("Please enter a valid integer");
            }

            return PatientRepository.deletePatient(ID);
        }

        public static List<viewAllPatientsResult> allPatients()
        {
            return PatientRepository.getAllPatients();
        }
    }
}
