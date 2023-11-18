using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace practice_11
{
    public class LiteDbHandler : IDatabaseHandler
    {
        private string _dbPath;

        public LiteDbHandler(string dbPath)
        {
            _dbPath = dbPath;
        }

        public void SaveCourierReceipt(CourierReceipt receipt)
        {
            try
            {
                using (var db = new LiteDatabase(_dbPath))
                {
                    var collection = db.GetCollection<CourierReceipt>("courierReceipts");
                    collection.Insert(receipt);
                }
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }

        public List<CourierReceipt> GetAllCourierReceipts()
        {
            try
            {
                using (var db = new LiteDatabase(_dbPath))
                {
                    var collection = db.GetCollection<CourierReceipt>("courierReceipts");
                    return collection.FindAll().ToList();
                }
            }
            catch (Exception ex)
            {
                HandleError(ex);
                return null;
            }
        }

        public CourierReceipt GetCourierReceiptInfo(int id)
        {
            try
            {
                using (var db = new LiteDatabase(_dbPath))
                {
                    var collection = db.GetCollection<CourierReceipt>("courierReceipts");
                    return collection.FindById(id);
                }
            }
            catch (Exception ex)
            {
                HandleError(ex);
                return null;
            }
        }

        private void HandleError(Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
