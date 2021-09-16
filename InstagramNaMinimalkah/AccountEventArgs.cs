using System;
using System.Collections.Generic;
using System.Text;

namespace InstagramNaMinimalkah
{
    delegate void AccountStateHandler(int a);

    //Класс
    class AccountEventArgs
    {
        Account account;
        AccountMethods accountMethods;
        public AccountEventArgs(AccountMethods accountMethods)
        {
            this.accountMethods = accountMethods;
            this.account = new Account();
            this.accountMethods.Liked += PutLike;
            this.accountMethods.Commented += CommentOn;
            this.accountMethods.Subscribed += SubscribeOn;            
        }       

        public void PutLike(int a)
        {
           account.LikeMethod(a);
             
        }

        public void CommentOn(int a)
        {
            account.CommentMethod(a);
            
        }

        public void SubscribeOn(int a)
        {
            account.SubscribeMethod(a);
        }

        

       
           
              

            
        
    }
}
