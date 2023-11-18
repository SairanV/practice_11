using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_11
{
    public interface IFileHandler
    {
        void CreateReceiptFile(CourierReceipt receipt, string filePath);
        void CopyFile(string sourceFilePath, string destinationPath);
    }

}
