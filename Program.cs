using modul5_1302190044;
using System;
using System.Collections.Generic;

using System.Threading.Tasks;

namespace tpmodul5_1302190044
{
    class Program
    {

        class SimpleDataBase<T> : List<DateTime>
        {
            public SimpleDataBase(){ }
          
            void AddNewData(T StoredData, DateTime inputDates)
            {
                inputDates = DateTime.Now;
            }
            void PrintAllData()
            {

            }
            static void Main(string[] args)
            {
                Penjumlahan jml = new Penjumlahan();
               // PrintAllData();
            }
        }
    }
}