using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6232_Group_6_Store.Model
{
    public class RentalReturnTransactionSummary
    {
        public int TransactionId { get; set; }
        public int Id { get; set; }
        public int ReturnId { get; set; }
        public int RentalItemId { get; set; }
        public string FurnitureName { get; set; }
        public int Quantity { get; set; }
        public string MemberName { get; set; }
        public string EmployeeName { get; set; }
        public DateTime DueDate { get; set; }
    }
}
