using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Solution.DAL
{
    internal class AppointmentRepository
    {
        public static List<viewAppointmentRangeResult> viewAppointmentRange(DateTime from, DateTime till)
        {
            HMSDataContext db = new HMSDataContext();
            return db.viewAppointmentRange(from.Date, till.Date).ToList();
        }
        public static List<viewAppointmentSingleResult> ViewAppointmentSingle(DateTime date)
        {
            HMSDataContext db = new HMSDataContext();
            return db.viewAppointmentSingle(date.Date).ToList();
        }
        public static int addAppointment(int pid, int did, DateTime appDate, TimeSpan appTime, string reason = null)
        {
            HMSDataContext db = new HMSDataContext();

            return db.insertIntoAppointment(pid, did, appDate, appTime, reason);
        }

        public static bool patientExists(int pid)
        {
            HMSDataContext db = new HMSDataContext();

            return db.patients.Any(p => p.patientID == pid);
        }
        public static bool doctorExists(int did)
        {
            HMSDataContext db = new HMSDataContext();

            return db.doctors.Any(p => p.doctorID == did);
        }
        public static int DeleteAppointment(int appID)
        {
            HMSDataContext db = new HMSDataContext();

            return db.deleteAppointment(appID);
        }

        public static bool appointmentExists(int appID)
        {
            HMSDataContext db = new HMSDataContext();
            
            return db.appointments.Any(x => x.appointmentID == appID);
        }

        public static int updateAppointment(int appID, int pid, int did, DateTime appDate, TimeSpan appTime, string reason = null)
        {
            HMSDataContext db = new HMSDataContext();

            return db.updateAppointment(appID, pid, did, appDate, appTime, reason);
        }



    }
}
