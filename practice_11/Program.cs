using practice_11.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dbPath = "C:/Users/aidyn/OneDrive/Документы/University/Practic/test.db"; // P.S. надо корректно ввести путь, иначне ршибка и нету больше файлов

            IDatabaseHandler databaseHandler = new LiteDbHandler(dbPath);
            IFileHandler fileHandler = new FileHandler();

            // Создаем тестовую курьерскую накладную
            CourierReceipt testReceipt = new CourierReceipt(1, DateTime.Now, "John Doe", "Jane Doe");

            // Сохраняем накладную в БД
            databaseHandler.SaveCourierReceipt(testReceipt);

            // Получаем список всех курьерских накладных
            var allReceipts = databaseHandler.GetAllCourierReceipts();
            Console.WriteLine("Все курьерские накладные:");
            foreach (var receipt in allReceipts)
            {
                Console.WriteLine(receipt.GetFullInfo());
            }

            // Получаем информацию о конкретной курьерской накладной
            var receiptInfo = databaseHandler.GetCourierReceiptInfo(1);
            Console.WriteLine("Информация о курьерских накладных:");
            Console.WriteLine(receiptInfo.GetFullInfo());

            // Создаем файл с информацией о курьерской накладной
            string filePath = "C:/Users/aidyn/OneDrive/Документы/University/Practic/save_file.txt";  // P.S. надо корректно ввести путь, иначне ршибка и нету больше файлов
            fileHandler.CreateReceiptFile(testReceipt, filePath);

            // Копируем файл в другую директорию
            string destinationPath = "C:/Users/aidyn/OneDrive/Документы/University/Practic/copy_file.txt"; // P.S. надо корректно ввести путь, иначне ршибка и нету больше файлов
            fileHandler.CopyFile(filePath, destinationPath);
        }
    }
}