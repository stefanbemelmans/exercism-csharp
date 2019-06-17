using System;
using System.Collections.Generic;

public class CircularBuffer<T>
{   
    Queue<T> Buffer;
    int BufferCap;
    public CircularBuffer(int capacity)
    {   
      BufferCap = capacity;
      Buffer = new Queue<T>(BufferCap);
    }

    public T Read()
    {
       return Buffer.Dequeue();
    }


    public void Write(T value)
    {
        if(Buffer.Count + 1 <= BufferCap)
        {
            Buffer.Enqueue(value);
        }
        else{
        throw new InvalidOperationException();
        }    
    }

    public void Overwrite(T value)
    {
        if(Buffer.Count + 1 <= BufferCap)
        {
            Buffer.Enqueue(value);
        }
        else{
            Buffer.Dequeue();
            Buffer.Enqueue(value);
        }    
    }

    public void Clear()
    {
        Buffer.Clear();
    }
}