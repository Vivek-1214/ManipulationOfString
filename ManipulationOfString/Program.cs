
using System;
namespace Abc
{

    class program
    {
        static void Main(string[] args)
        {

            /* Console.WriteLine("enter any string");
             var st = Console.ReadLine();
          Console.WriteLine(st);                       //print the string*/

            program p = new program();
            //  lenghtofString();
            //countWhiteSpaces();
            // countWords();
            //countVowel();
            //countConsonant();

            stringManupilation();



        }

        

        static void lenghtofString()
        {                                                   //my name is lakhan
            var count = 0;
            Console.WriteLine("enter any string");
            var st = Console.ReadLine();
            foreach (var items in st)
            {
                count++;
            }
            Console.WriteLine("length of a string is = " + count);   //length =17
        }

        static void countWhiteSpaces()
        {
            var countspace = 0;                              //my name is lakhan
            Console.WriteLine("enter any string");
            var st = Console.ReadLine();

            foreach(var items in st)
            {
                if (items ==' ')
                {
                    countspace++;
                }

            }
            Console.WriteLine("no of spaces are =" + countspace);   //whitespace = 3


        }

        static void countWords()
        {
            var countwords = 0; var countspace = 0;                             //my name is lakhan
            Console.WriteLine("enter any string");
            var st = Console.ReadLine();

            foreach (var items in st)
            {
                if (items == ' ')
                {
                    countspace++;
                    countwords = countspace + 1;
                }

            }
            Console.WriteLine("no of spaces are =" + countwords); //words= 4
        }

         static void countVowel()
        {                                                         //my name is lakhan
            var vowelcount = 0;
            Console.WriteLine("enter any string");
            var st = Console.ReadLine();

            foreach (var ch in st)
            {
                if (ch =='a' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'e' ||
                    ch == 'A' || ch == 'I' || ch == 'O' || ch == 'U' || ch == 'E' 
                    )
                {
                    vowelcount++;
                }

            }
            Console.WriteLine("no of vowels are =" + vowelcount );  //vowel = 5
        }

        static void countConsonant()
        {                                                         //my name is lakhan
            var consonentcount = 0;
            Console.WriteLine("enter any string");
            var st = Console.ReadLine();

            foreach (var ch in st)
            {
                if ( !(ch == 'a' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'e' || ch==' ' ||
                    ch == 'A' || ch == 'I' || ch == 'O' || ch == 'U' || ch == 'E')
                    )
                {
                    consonentcount++;
                }

            }
            Console.WriteLine("no of consonent are =" + consonentcount);  //consonents =  9
        }

        static void stringManupilation()
        {
            var countLength = 0;var countSpaces = 0;
            var noOfSpace = 0; var countwords=0;
            var countVowel = 0; var countConsonent = 0;

            Console.WriteLine("Enter any string =");
            var str = Console.ReadLine();

            foreach (var items in str)
            {
                countLength++;
            }

            foreach (var items in str)
            {
                if (items == ' ')
                {
                    countSpaces++;
                }

            }
            foreach (var items in str)
            {
                if (items == ' ')
                {
                    noOfSpace++;
                    countwords = noOfSpace + 1;
                }

            }
            foreach (var ch in str)
            {
                if (ch == 'a' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'e' ||
                    ch == 'A' || ch == 'I' || ch == 'O' || ch == 'U' || ch == 'E'
                    )
                {
                    countVowel++;
                }

            }
            foreach (var ch in str)
            {
                if (!(ch == 'a' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'e' || ch == ' ' ||
                    ch == 'A' || ch == 'I' || ch == 'O' || ch == 'U' || ch == 'E')
                    )
                {
                    countConsonent++;
                }

            }
            
            Console.WriteLine("length of a string is = " + countLength);
            Console.WriteLine("no of spaces are =" + countSpaces);
            Console.WriteLine("no of words are =" + countwords);
            Console.WriteLine("no of vowels are =" + countVowel);
            Console.WriteLine("no of consonent are =" + countConsonent);

        }
    }
}