using System;
using System.Collections.Generic;
using System.Text;

namespace REDDE.v1.Services
{
    public static class ReddeUtilities
    {
        public static string ClientReferenceNumber(int size)
        {
            string randomno = "1234567890";
            StringBuilder builder = new StringBuilder();
            char ch;
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                ch = randomno[random.Next(0, randomno.Length)];
                builder.Append(ch);
            }
            return builder.ToString();
        }

        public static string ClientReferenceNumber()
        {
            string randomno = "1234567890";
            StringBuilder builder = new StringBuilder();
            char ch;
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                ch = randomno[random.Next(0, randomno.Length)];
                builder.Append(ch);
            }
            return builder.ToString();
        }

        public static string RandomClientTransactionID(int size)
        {
            string randomno = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghjklmnopqrstuvwxyz";
            StringBuilder builder = new StringBuilder();
            char ch;
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                ch = randomno[random.Next(0, randomno.Length)];
                builder.Append(ch);
            }
            return builder.ToString();
        }

        public static string RandomClientTransactionID()
        {
            string randomno = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghjklmnopqrstuvwxyz";
            StringBuilder builder = new StringBuilder();
            char ch;
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                ch = randomno[random.Next(0, randomno.Length)];
                builder.Append(ch);
            }
            return builder.ToString();
        }
    }
}
