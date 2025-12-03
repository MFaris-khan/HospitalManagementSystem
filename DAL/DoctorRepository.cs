using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Solution.DAL
{
    internal class DoctorRepository
    {
        public static int addDoctor(string name, string gender, DateTime DOB, string phone, string timing, string specialization, string qualification, int? yearOfEx, string email = null, string address = null, string license = null)
        {
            HMSDataContext db = new HMSDataContext();

            return db.insertIntoDoctor(name, gender, DOB, phone, email, address, specialization, qualification, yearOfEx, timing, license);
        }
        public static int updateDoctor(string ID, string name, string gender, DateTime DOB, string phone, string timing, string specialization, string qualification, int? yearOfEx, string email = null, string address = null, string license = null)
        {
            HMSDataContext db = new HMSDataContext();

            return db.updateDoctor(int.Parse(ID), name, gender, DOB, phone, email, address, specialization, qualification, yearOfEx, timing, license);
        }

        public static int deleteDoctor(int ID)
        {
            HMSDataContext db = new HMSDataContext();
            
            return db.deleteDoctor(ID);
        }

    }
}
