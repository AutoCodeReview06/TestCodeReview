using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeReviewDemo
{
    internal class DeadlockDemo
    {
        object myLock1 = new object();
        object myLock2 = new object();
        void StartThreads()
        {
            Thread t1 = new Thread(ExecuteThread1);
            Thread t2 = new Thread(ExecuteThread2);
            t1.Start();
            t2.Start();
        }

        private void ExecuteThread1()
        {
            lock (myLock1)
            {
                Thread.Sleep(1000);
                lock (myLock2)
                {
                    //throw new NotImplementedException();
                }
            }
        }

        private void ExecuteThread2()
        {
            lock (myLock2)
            {
                lock (myLock1)
                {
                    //throw new NotImplementedException();
                }
            }
        }
    }
}
