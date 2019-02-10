using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue
    {
        // int volume=.Length
        int count = 0;
        int index = 0;
        int[] queue;

        //생성자에서 저장공간 설정가능
        //배열 이용
        public Queue( int arg )
        {
            queue = new int[arg];
        }

        //Resize 저장공간 변경가능
        public void Resize( int arg )
        {
            int[] resize = new int[arg];
            int recount = count;

            for( int i = 0; i < recount; i++ )
            {
                resize[i] = Pop();
            }

            queue = resize;
            index = 0;
            if( recount > arg )
                recount = arg;
            count = recount;
        }

        //Push 입력
        public void Push( int value )
        {
            if( IsFull() )
            {
                Console.WriteLine("더 이상 값을 넣을 수 없습니다.");
                System.Threading.Thread.Sleep(700);
                return;
            }
            queue[( index + count ) % queue.Length] = value;
            ++count;
        }

        //Pop
        public int Pop()
        {
            if( IsEmpty() )
            {
                Console.WriteLine("저장된 값이 없습니다.");
                System.Threading.Thread.Sleep(700);
                return 0;
            }

            int pop = queue[index];
            Array.Clear(queue, index, 1);
            --count;
            ++index;

            if( index >= queue.Length )
                index = index % queue.Length;

            return pop;
        }

        //IsEmpty
        public bool IsEmpty()
        {
            if( count == 0 )
                return true;
            return false;
        }

        //IsFull
        public bool IsFull()
        {
            if( count == queue.Length )
                return true;
            return false;
        }

        //Print
        public void Print()
        {
            for( int i = 0; i < queue.Length; i++ )
            {
                Console.Write($"{queue[( i + index ) % queue.Length]} ");
            }
        }

        //Clear
        public void Clear()
        {
            Array.Clear(queue, 0, queue.Length);
            count = 0;
            index = 0;
        }
    }
}
