using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSingleton
{
    //No Thread Safe Singleton
    public sealed class Singleton1
    {
        private Singleton1()
        {
            //empty constructor for Singleton
            //prevent instantiation from outside the class 
            //can only be instantiated within
        }
        private static Singleton1 instance = null;
        public static Singleton1 Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Singleton1();
                }
                return instance;
            }
        }
    }
}
