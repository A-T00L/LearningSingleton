using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSingleton
{
    //Thread Safe Singleton without using locks and no lazy instantiation
    public sealed class Singleton4
    {
        static Singleton4()
        {
            //static constructor has to be there
        }
        private Singleton4()
        {
            //default nature of the Singleton class
        }

        //immediately initialized when the class is first loaded.
        //This approach is called eager initialization
        private static readonly Singleton4 instance = new Singleton4();

        //Uses eager initialization to create the Singleton instance when the class is first loaded.
        //Ensures thread safety without locking.
        public static Singleton4 Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
