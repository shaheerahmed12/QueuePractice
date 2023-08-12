using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace queue.Models.Queue
{
    public  class Queue
    {
        public int Maxsize {get;set;}
        public int[] QueueArray { get;set;}
        public int Front { get;set;}
        public int Rear { get;set; }
        public int Nitem { get; set; }
        public Queue(int size)
        {
            this.Maxsize = size;
            this.QueueArray = new int[size];
            this.Front = 0;
            this.Rear = -1;
        }
        public void Enqueue(int item)
        {
            Rear++;
            QueueArray[Rear]=item;
            Nitem++;
        }
        public int Dequeue() {
            int temp = QueueArray[Front];
            Front++;
                if(Front==Maxsize) {
                Front = 0;
                if(Front==0) { 
                
                }
            }
                Nitem--;
            return temp;
        }
        public int peek()
        {
            return QueueArray[Front];
        }
    }

}