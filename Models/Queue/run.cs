using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace queue.Models.Queue
{
    public class run
    {
        public int Runner() { 
        Queue que=new Queue(10);
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Dequeue();

            int q=que.peek();
            return q;

        }
    }
}