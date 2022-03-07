using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDemo
{
    interface IDataAccess<T>
    {
        bool AddRecord(T obj);
    }
    class CommonDataAccess<T> : IDataAccess<T> where T : class
    {
        List<T> records;
        public CommonDataAccess()
        {
            this.records = new List<T>();
        }
        public virtual bool AddRecord(T obj)
        {
            this.records.Add(obj);
            return true;
        }
    }
    class StudentDataAccess : CommonDataAccess<Student>
    {
        public override bool AddRecord(Student obj)
        {
            return base.AddRecord(obj);
        }
    }
    //class StudentDataAccess : IDataAccess<Student>
    //{
    //    public bool AddRecord(Student obj)
    //    {
    //        return null;
    //    }
    //}
}
