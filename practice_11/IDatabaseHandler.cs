using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_11
{
    public interface IDatabaseHandler
    {
        void SaveCourierReceipt(CourierReceipt receipt);
        List<CourierReceipt> GetAllCourierReceipts();
        CourierReceipt GetCourierReceiptInfo(int id);
    }

}
