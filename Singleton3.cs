using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSingleton
{
    //Singleton with the Double checked locking Safety
    public sealed class Singleton3
    {
        private Singleton3() { }

        private static Singleton3 instance = null;

        private static readonly object lockObj = new object();

        public static Singleton3 Instance
        {
            get
            {
                //the below if condition is to avoid locking every time the instance is accessed
                if(instance == null)
                {
                    lock(lockObj)
                    {
                        //check to ensure that another thread hasn’t created the instance while waiting to acquire the lock.
                        if (instance == null)
                        {
                            instance = new Singleton3();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
