using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static HMS_Solution.bill;

namespace HMS_Solution.DAL
{
    internal class BillingRepository
    {
        public static int addBill(int ID, decimal amount, string paymentMethod, string status, decimal receivedMoney)
        {
            HMSDataContext db = new HMSDataContext();

            return db.insertIntoBill(ID, amount, paymentMethod, status, receivedMoney);
        }

        public static bool patitentExists(int ID)
        {
            HMSDataContext db = new HMSDataContext();

            return db.patients.Any(x => x.patientID == ID);
        }
        public static bool billExists(int ID)
        {
            HMSDataContext db = new HMSDataContext();
            
            return db.bills.Any(x => x.billID == ID);
        }

        public static bill viewBill(int ID)
        {
            HMSDataContext db = new HMSDataContext();

            return db.bills.FirstOrDefault(x => x.billID == ID);
        }

        public static List<viewAllBillsResult> viewAllBills()
        {
            HMSDataContext db = new HMSDataContext();

            return db.viewAllBills().ToList();
        }

        public static int payInstallment(int billID, decimal amount)
        {
            HMSDataContext db = new HMSDataContext();

            return db.payInstallment(billID, amount);
        }

        public static List<installmentHistoryResult> installmentHistory(int billID)
        {
            HMSDataContext db = new HMSDataContext();
            
            return db.installmentHistory(billID).ToList();
        }

        public static int addService(string serviceName, decimal serviceAmount)
        {
            HMSDataContext db = new HMSDataContext();

            return db.insertIntoServices(serviceName, serviceAmount);
        }

        public static int updateService(int servID, string servName, decimal servAmount)
        {
            HMSDataContext db = new HMSDataContext();

            return db.updateServices(servID, servName, servAmount);
        }

        public static List<searchServiceNameResult> searchServicesName(string servName)
        {
            HMSDataContext db = new HMSDataContext();

            return db.searchServiceName(servName).ToList();
        }

        public static List<allServicesResult> allServices()
        {
            HMSDataContext db = new HMSDataContext();

            return db.allServices().ToList();
        }
        public static int deleteService(int servID)
        {
            HMSDataContext db = new HMSDataContext();

            if( ! db.services.Any(x => x.serviceID == servID))
            {
                return 0;
            }
            
            return db.deleteServices(servID);
        }

        public static service searchServiceWithID(int servID)
        {
            HMSDataContext db = new HMSDataContext();

            return db.services.FirstOrDefault(x => x.serviceID == servID);
        }

        public static int addDetailedBill(int billID, int servID, string servName, decimal servCost, int QTY)
        { 
            HMSDataContext db = new HMSDataContext();

            return db.insertIntoDetailedBill(billID, servID, servName, servCost, QTY);
            
        }

        public static List<getDetailedBillResult> getDetailedBill(int billID)
        {
            HMSDataContext db = new HMSDataContext();

            return db.getDetailedBill(billID).ToList();
        }
    }
}
