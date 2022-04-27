using System;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //string n = Console.ReadLine();
            //con("salam",'z');
            string word = "salam";
            Console.WriteLine(word);
            //string b = Str(n ,2, 5);
         //   StringBuilder a = replace(n,'a','1');
         //Console.WriteLine(a);
         

        }
        static void con(string word,char letter)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]==letter)
                {
                    count++;
                }
            }
            if (count ==1)
            {
                Console.WriteLine(letter +" herfi var bir eded");
            }
            else
            {
                Console.WriteLine("yoxdur");
            }
        }
       static StringBuilder replace(string word,char letter ,char change)
        {
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]==letter)
                {
                    temp.Append(change);  

                    continue;
                }
             
                temp.Append(word[i]);
            }
           
            return temp;
        }
        static StringBuilder replace(string word, string letter, char change)
        {
            StringBuilder temp = new StringBuilder();
            bool check = true;
            string memory = "";
            for (int i = 0; i < word.Length; i++)
            {

                for (int j = 0; j < letter.Length; j++)
                {
                    if (word[i] == letter[j])
                    {
                        
                        if (letter.Length-1==j)
                        {
                            memory += i.ToString(); 
                        }
                        
                    }
                    else
                    {
                        break;
                    }
                }
               

                temp.Append(word[i]);
            }

            for (int i = 0; i < word.Length; i++)
            {
                if (memory[i] == letter )
                {

                }
            }

            return temp;
        }

        //static StringBuilder replace(string word, char letter, char change)
        //{
        //    StringBuilder temp = new StringBuilder();
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (word[i] == letter)
        //        {
        //            temp.Append(change);

        //            continue;
        //        }

        //        temp.Append(word[i]);
        //    }

        //    return temp;
        //}
        static string Str(string word, int letterBefore ,int letterAfter)
        {
            string temp = "";
            for (int i = word.Length - 1; i > -1; i--)
            {
                if (i > letterBefore  && i<=letterAfter )
                {
                    continue;
                }
                temp = word[i] + temp;
            }

            return temp;
        }


      
    }
}
