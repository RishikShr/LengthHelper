using System;
namespace Length
{
       

        public class LengthHelper
        {
            public int findLength(string s)
            {
                if (s == null)
                {
                    throw new ArgumentException("string  cannot be null");
                }
                return s.Length;
            }
        }
    
}
