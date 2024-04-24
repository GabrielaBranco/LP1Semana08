using System;
using System.Collections.Generic;
namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        private bool order;
        public CompareByName(bool order)
        {
            this.order = order;
        }

        public int Compare(Player x, Player y)
        {
            if(x == null || y == null) // If null, return sort by score
            {
                return 0;
            }
            else
            {
                if(order) //if true, ascending order.
                {
                    return string.Compare(x.Name, y.Name);
                }
                else //If false, descending order.
                {
                    return string.Compare(y.Name, x.Name);
                }
            }
        }
    }
}