using HMS_Solution.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Solution.BLL
{
    internal class BillingService
    {
        public static int validateAddBill(string P_ID, string amount, string paymentMethod, string status, string receivedAmount)
        {
            if( ! int.TryParse(P_ID, out int pid))
            {
                throw new ArgumentException("Please enter valid patient ID");
            }
            if ( ! decimal.TryParse(amount, out decimal money))
            {
                throw new ArgumentException("Please enter valid amount");
            }
            if (!decimal.TryParse(receivedAmount, out decimal receivedMoney))
            {
                throw new ArgumentException("Please enter valid amount");
            }

            if ( ! BillingRepository.patitentExists(pid))
            {
                throw new ArgumentException("Patient does not exists");
            }

            if(receivedMoney < 0 || receivedMoney > money)
            {
                throw new ArgumentException("Please enter valid received amount");
            }

            return BillingRepository.addBill(pid, money, paymentMethod, status, receivedMoney);
        }

        public static bill validateViewBill(string id)
        {
            if(string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Please enter ID to search");
            }

            if( ! int.TryParse(id, out int ID))
            {
                throw new Exception("Please enter valid integer ID");
            }

            if( ! BillingRepository.billExists(ID))
            {
                throw new Exception("Bill not found. Enter correct Bill ID");
            }

            return BillingRepository.viewBill(ID);
        }

        public static List<viewAllBillsResult> callViewAllBills()
        {
            return BillingRepository.viewAllBills();
        }

        public static int validateInstallment(string billID, string instAmount, string remaining)
        {
            if (!decimal.TryParse(instAmount, out decimal money))
            {
                throw new ArgumentException("Please enter valid installment amount");
            }
                        
            if(money > decimal.Parse(remaining))
            {
                throw new Exception("Installment amount cannot be greater then remaining amount");
            }

            if(money <= 0)
            {
                throw new Exception("Installments cannot be negative or zero");
            }

            return BillingRepository.payInstallment(int.Parse(billID), money);
        }

        public static List<installmentHistoryResult> validateInstHistory(string billID)
        {
            if(string.IsNullOrWhiteSpace(billID))
            {
                throw new ArgumentException("Please select a bill to see history");
            }
            return BillingRepository.installmentHistory(int.Parse(billID));
        }

        public static int validateAddService(string serviceName, string serviceAmount)
        {
            if( ! decimal.TryParse(serviceAmount, out decimal money) )
            {
                throw new ArgumentException("Please enter valid amount");
            }
            return BillingRepository.addService(serviceName, money);
        }

        public static int validateUpdateService(string ID, string serviceName, string serviceAmount)
        {
            if( ! int.TryParse(ID, out int ServID))
            {
                throw new ArgumentException("Please enter valid Service ID");
            }
            if ( ! decimal.TryParse(serviceAmount, out decimal money))
            {
                throw new ArgumentException("Please enter valid amount");
            }

            return BillingRepository.updateService(ServID, serviceName, money);
        }
        public static List<searchServiceNameResult> validateSearchServiceName(string servName)
        {
            if (string.IsNullOrWhiteSpace(servName))
            {
                throw new ArgumentException("Please enter something to search");
            }

            return BillingRepository.searchServicesName(servName);
        }

        public static List<allServicesResult> validateAllServices()
        {
            return BillingRepository.allServices();
        }

        public static int validateDeleteService(string servID)
        {
            if (string.IsNullOrWhiteSpace(servID))
            {
                throw new ArgumentException("Please enter service ID to delete");
            }
            if( ! int.TryParse(servID, out int ID))
            {
                throw new ArgumentException("Please enter valid integer ID");
            }

            return BillingRepository.deleteService(ID);
        }

        public static service validateSearchServiveWithID(string servID)
        {
            if(string.IsNullOrWhiteSpace(servID))
            {
                throw new ArgumentException("Please enter ID first");
            }
            if( ! int.TryParse(servID, out int ID))
            {
                throw new ArgumentException("Please enter valid integer ID");
            }

            return BillingRepository.searchServiceWithID(ID);
        }

        public static int validateAddDetailedBill(int billID , string servID, string servName, string servCost, string qty)
        {
            if( ! int.TryParse(servID, out int SID))
            {
                throw new ArgumentException("Please enter correct service ID");
            }
            if( ! decimal.TryParse(servCost, out decimal cost))
            {
                throw new ArgumentException("Unknown error occured in cost");
            }
            if( ! int.TryParse(qty, out int QTY))
            {
                throw new ArgumentException("Please enter correct Quantity");
            }

            return BillingRepository.addDetailedBill(billID, SID, servName, cost, QTY);
            
        }

        public static List<getDetailedBillResult> ValidateGetDetailedBill(string billID)
        {

            return BillingRepository.getDetailedBill(int.Parse(billID));
        }
    }
}
