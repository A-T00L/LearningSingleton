using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSingleton
{
    public sealed class Singleton5
    {
        private Singleton5()
        {
            //default pattern of a Singleton class
        }

        //using Lazy<Singleton5>, the Singleton5 instance is created only when it’s accessed for the first time
        private static readonly Lazy<Singleton5> lazyObj = new Lazy<Singleton5>(()=> new Singleton5());

        private static Singleton5 Instance
        {
            get
            {
                return lazyObj.Value;
            }
        }
    }
}
