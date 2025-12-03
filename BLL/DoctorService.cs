using HMS_Solution.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HMS_Solution.BLL
{
    internal class DoctorService
    {
        public static bool validateDetails(string name, string gender, string phone, string timing)
        {
            if(name.Length < 3)
            {
                throw new ArgumentException("Names cannot be less than 3 characters");
            }
            if (gender != "male" && gender != "female" && gender != "other")
            {
                throw new ArgumentException("Unknown gender. Please select from list only.");
            }
            if(phone.Length < 11)
            {
                throw new ArgumentException("Please enter a valid phone number");
            }
            if(timing != "morning" && timing != "evening" && timing != "night")
            {
                throw new ArgumentException("Please enter valid shift timings");
            }

            return true;    
        }

        public static int validateDoctorDetails(string name, string gender, DateTime DOB, string phone, string timing, string specialization, string qualification, string email = null, string address = null, string yearOfEx = null, string license = null) 
        {
            int? opYearsOfExp = null;

            if(!string.IsNullOrWhiteSpace(yearOfEx))
            {
                bool converted = int.TryParse(yearOfEx, out int intYearsOfExp);
                if(converted)
                {
                    opYearsOfExp = intYearsOfExp;
                }
                else
                {
                    throw new ArgumentException("Please enter a valid integer for experience");
                }
            }

            if (validateDetails(name, gender, phone, timing))
            {
                return DoctorRepository.addDoctor(name, gender, DOB, phone, timing, specialization, qualification, opYearsOfExp, email, address, license);
            }
            return -1;
        }
        public static int validateUpdateDoctorDetails(string ID, string name, string gender, DateTime DOB, string phone, string timing, string specialization, string qualification, string email = null, string address = null, string yearOfEx = null, string license = null)
        {
            int? opYearsOfExp = null;

            if (!string.IsNullOrWhiteSpace(yearOfEx))
            {
                bool converted = int.TryParse(yearOfEx, out int intYearsOfExp);
                if (converted)
                {
                    opYearsOfExp = intYearsOfExp;
                }
                else
                {
                    throw new ArgumentException("Please enter a valid integer for experience");
                }
            }

            if (validateDetails(name, gender, phone, timing))
            {
                return DoctorRepository.updateDoctor(ID, name, gender, DOB, phone, timing, specialization, qualification, opYearsOfExp, email, address, license);
            }
            return -1;
        }
    
        public static int validateDeleteDcotor(string ID)
        {
            bool converted = int.TryParse(ID, out int id);

            if (converted)
            {
                return DoctorRepository.deleteDoctor(id);
            }
            else
            {
                throw new ArgumentException("Please enter valid integer ID");
            }
        }
    }
}
