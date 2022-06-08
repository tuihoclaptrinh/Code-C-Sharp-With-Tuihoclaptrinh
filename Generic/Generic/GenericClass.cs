using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class GenericClass<T>
    {
        private T id;
        public void SetID(T _id)
        {
            this.id = _id;
        }

        public void Infomation()
        {
            Console.WriteLine($"Your id is {id}");
        }


    }
}
