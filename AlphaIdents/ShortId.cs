using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlphaIdents
{
    public class ShortId
    {
        public string Alphabet = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public string Encode(Int64 Number)
        {
            string result = String.Empty;
            for (int i = (int)Math.Floor(Math.Log(Number) / Math.Log(Alphabet.Length)); i >= 0; i--)
            {
                result += Alphabet.Substring((int)(Math.Floor(Number / BcPow(Alphabet.Length, i)) % Alphabet.Length), 1);
            }
            return ReverseString(result);
        }

        public Int64 Decode(string Id)
        {
            string str = ReverseString(Id);
            Int64 result = 0;
            int end = str.Length - 1;
            for (int i = 0; i <= end; i++)
            {
                result = result + (Int64)(Alphabet.IndexOf(str.Substring(i, 1)) * BcPow(Alphabet.Length, end - i));
            }
            return result;
        }

        public double BcPow(double _a, double _b)
        {
            return Math.Floor(Math.Pow(_a, _b));
        }

        public string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
