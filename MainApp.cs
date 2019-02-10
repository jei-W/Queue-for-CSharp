using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class MainApp
    {
        static void Main( string[] args )
        {
            int arg;
            string num;

            Console.Write("Queue의 저장공간을 입력하세요 : ");
            arg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Queue queue = new Queue(arg);

            do
            {
                Console.WriteLine("현재 총 저장 공간 : {0}", arg);
                Console.WriteLine("원하는 작업의 번호를 입력하세요.\n");
                Console.WriteLine("1. 저장공간 다시 설정하기\n" +
                                    "2. 데이터 입력하기\n" +
                                    "3. 데이터 꺼내기\n" +
                                    "4. 저장 공간이 비었는지 확인하기\n" +
                                    "5. 저장 공간이 꽉 찼는지 확인하기\n" +
                                    "6. 저장된 데이터 출력하기\n" +
                                    "7. 모두 삭세하기\n" +
                                    "8. 처음으로 돌아가기");
                num = Console.ReadLine();

                switch( num )
                {
                    case "1":
                        Console.Write("저장공간을 입력하세요 : ");
                        arg = Convert.ToInt32(Console.ReadLine());
                        queue.Resize(arg);
                        break;

                    case "2":
                        Console.Write("저장할 값을 입력하세요 : ");
                        queue.Push(Convert.ToInt32(Console.ReadLine()));
                        break;

                    case "3":
                        queue.Pop();
                        break;

                    case "4":
                        if( queue.IsEmpty() )
                            Console.WriteLine("비었다.");
                        else
                            Console.WriteLine("뭔가 들어있다.");
                        System.Threading.Thread.Sleep(700);
                        break;

                    case "5":
                        if( queue.IsFull() )
                            Console.WriteLine("꽉찼다.");
                        else
                            Console.WriteLine("덜 찼다.");
                        System.Threading.Thread.Sleep(700);
                        break;

                    case "6":
                        queue.Print();
                        System.Threading.Thread.Sleep(700);
                        break;

                    case "7":
                        queue.Clear();
                        break;
                }
                Console.Clear();
                
            } while( num != "8" );
        }    
    }
}
