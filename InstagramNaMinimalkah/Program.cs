using System;

namespace InstagramNaMinimalkah
{
    class Program
    {

       
        
        static void Main(string[] args)
        {

            Console.WriteLine("Нажмите 1, чтобы отметить понравившееся, 2, чтобы оставить комментарий и 3, чтобы подписаться");
            int a = Convert.ToInt32(Console.ReadLine());
            AccountMethods accountMethods = new AccountMethods();

            switch (a)
            {
                case 1:
                    {
                        accountMethods.LikedEvent(a);
                        break;
                    }
                case 2:
                    {
                        accountMethods.CommentedEvent(a);
                        break;
                    }
                case 3:
                    {
                        accountMethods.SubscribedEvent(a);
                        break;
                    }
            }

            

        }
       


        }
    }

