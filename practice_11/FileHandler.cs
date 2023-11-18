using System;
using System.IO;

namespace practice_11
{
    public class FileHandler : IFileHandler
    {
        public void CreateReceiptFile(CourierReceipt receipt, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine($"ID квитанции: {receipt.Id}");
                    writer.WriteLine($"Дата создания: {receipt.DateCreated}");
                    writer.WriteLine($"Отправитель: {receipt.SenderName}");
                    writer.WriteLine($"Получатель: {receipt.RecipientName}");                }

                Console.WriteLine($"Файл успешно создан: {filePath}");
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }

        public void CopyFile(string sourceFilePath, string destinationPath)
        {
            try
            {
                File.Copy(sourceFilePath, destinationPath, true);
                Console.WriteLine($"Файл успешно скопирован в: {destinationPath}");
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }

        private void HandleError(Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
