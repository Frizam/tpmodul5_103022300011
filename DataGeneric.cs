using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_103022300011
{
    class DataGeneric<T>//kelas generic yang menyimpan data dengan tipe fleksibel (T)
    {
        private T Data; //properti untuk menyimpan data

        public DataGeneric(T data)
        {
            this.Data = data;//konstruktor yang menerima parameter untuk menginisialisasi data
        }

        public void PrintData()// Method untuk print data yang tersimpan
        {
            Console.WriteLine($"Data yang tersimpan adalah: {Data}");
        }
    }
}
