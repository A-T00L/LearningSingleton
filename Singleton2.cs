using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSingleton
{
    //Thread Sfe Singleton
    public sealed class Singleton2
    {
        private Singleton2()
        {
            //empty constructor for the Singleton2 class
        }

        //Using this lockObj :: this becomes the thread safe singleton
        private static readonly object lockObj = new object();
        private static Singleton2 instance = null;
        public static Singleton2 Instance
        {
            get
            {
                //Making sure only one thread is accessing the instance creation at a time
                lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton2();
                        }
                        return instance;
                    }
            }
        }
    }
}
