using HMS_Solution.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Solution.BLL
{
    internal class AppointmentService
    {
        public static List<viewAppointmentRangeResult> validateAppointmentRange(DateTime from, DateTime till)
        {
            return AppointmentRepository.viewAppointmentRange(from, till);
        }
        public static List<viewAppointmentSingleResult> validateViewAppointmentSingle(DateTime date)
        {
            return AppointmentRepository.ViewAppointmentSingle(date);
        }
        public static bool validateAppointmentDetails(string P_ID, string D_ID, DateTime appDate, DateTime appTime, string reason)
        {
            bool cpid = int.TryParse(P_ID, out int pid);
            bool cdid = int.TryParse(D_ID, out int did);

            if (!(cpid && cdid))
            {
                throw new Exception("Please enter valid integer ID");
            }
            if (!AppointmentRepository.patientExists(pid))
            {
                throw new Exception("Patient does not exists. Please check patient ID");
            }
            if (!AppointmentRepository.doctorExists(did))
            {
                throw new Exception("Doctor does not exists. Please check Doctor ID");
            }

            DateTime Date = appDate.Date; TimeSpan Time = appTime.TimeOfDay;
            DateTime AppDateTime = Date.Add(Time);
            DateTime now = DateTime.Now;

            if (AppDateTime <= now)
            {
                throw new Exception("Appointments cannot be set in past time");
            }
            return true;
        }

        public static int validateAddAppointment(string P_ID, string D_ID, DateTime appDate, DateTime appTime, string reason)
        {
            bool check = validateAppointmentDetails(P_ID, D_ID, appDate, appTime, reason);

            if (!check)
            {
                throw new Exception("Unknown error occured");
            }
            TimeSpan Time = appTime.TimeOfDay;
            return AppointmentRepository.addAppointment(int.Parse(P_ID), int.Parse(D_ID), appDate, Time, reason);
        }

        public static int validateDeleteApp(string appID)
        {
            bool converted = int.TryParse(appID, out int ID);
            if (!converted)
            {
                throw new Exception("Please enter valid integer ID");
            }

            if (!AppointmentRepository.appointmentExists(ID))
            {
                throw new Exception("No appointment found");
            }
            return AppointmentRepository.DeleteAppointment(ID);
        }

        // update method here
        public static int validateUpdateAppointment(string appID, string P_ID, string D_ID, DateTime appDate, DateTime appTime, string reason)
        {
            if (!int.TryParse(appID, out int AppID))
            {
                throw new Exception("Please enter a valid appointment ID");
            }

            bool check = validateAppointmentDetails(P_ID, D_ID, appDate, appTime, reason);
            
            if (!check)
            {
                throw new Exception("Unknown error occured");
            }

            TimeSpan Time = appTime.TimeOfDay;

            return AppointmentRepository.updateAppointment(int.Parse(appID), int.Parse(P_ID), int.Parse(D_ID), appDate, Time, reason);
        }
    }
}
