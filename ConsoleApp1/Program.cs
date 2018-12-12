using System;
using ClassLibrary1;

namespace StaticVarApplication
{
    
    class StaticVar
    {
        public int num;

        public void count()
        {
            num++;
        }
        public int getNum()
        {
            return num;
        }
    }
    class StaticTester
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            StaticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();
            
            s1.count();
            s1.count();
            s1.count(); 
            c1.Add(1,2);
            
            s2.count();
            s2.count();
            s2.count();

            Console.WriteLine("Variable num for s1: {0}", s1.getNum());
            Console.WriteLine("Variable num for s2: {0}", s2.getNum());
            Console.ReadKey();
        }
    }
}