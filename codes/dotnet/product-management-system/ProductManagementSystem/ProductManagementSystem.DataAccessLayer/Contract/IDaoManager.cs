using System.Collections.Generic;

namespace ProductManagementSystem.DataAccessLayer.Contract
{
    //generic interface with constraint
    public interface IDaoManager<T> where T : class
    {
        List<T> GetAllRecords();
        T GetARecordById(int id);
        bool InsertRecord(T newData);
        bool UpdateRecord(T updatedData);
        bool DeleteRecord(int id);
    }    
}
