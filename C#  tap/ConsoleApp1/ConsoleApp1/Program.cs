using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(tap(10,2));
            //Repeat("hi!", 3);
          //int answer =  Quv2(65);
           int answer = Rek(24);
            Console.WriteLine(answer);

        }
        static int Tap(int n,int m)
        {
            return n / m;
        }

        static void Repeat(string word,int count)
        {

            for (int i = 0; i < count; i++)
            {
                Console.Write(word);
            }
        }

        static int Say(char letter ,string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                {
                    count++;
                }
            }


            return count ;
        }


        static int Quv2(int n)
        {
            int count = 0;

            if (n == 0)
            {
                return count + 1;
            }

            else if (n % 2 != 0)
            {
                return -1;

            }
            else
            {

                while (n > 1)
                {
                    n /= 2;
                    count++;
                }
            }

            return count;
        }


        static int Rek(int n ,int count=0)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n%2==0)
            {
                count++;
                return Rek(n / 2,count);
            }
            else
            {
                return - 1;
            }
           
          

            
            return count;
        }

    }
}
