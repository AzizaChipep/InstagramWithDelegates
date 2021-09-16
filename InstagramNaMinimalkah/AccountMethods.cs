using System;
using System.Collections.Generic;
using System.Text;

namespace InstagramNaMinimalkah
{
    class AccountMethods
    {

        public AccountMethods()
        {
            new AccountEventArgs(this);
        }
        public event AccountStateHandler Liked = null;
        public event AccountStateHandler Commented = null;
        public event AccountStateHandler Subscribed = null;

        public void LikedEvent(int a)
        {
            Liked.Invoke(a);
        }

        public void CommentedEvent(int a)
        {
            Commented.Invoke(a);
        }
        public void SubscribedEvent(int a)
        {
            Subscribed.Invoke(a);
        }
    }
}
