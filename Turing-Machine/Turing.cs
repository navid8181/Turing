using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Turing
    {
        Char[] Tape;
        int heade = 1;
        public Turing(int size,String data)
        {
            Tape = new char[size];

            char[] tmp = data.ToCharArray();

            for (int i = 0; i < tmp.Length; i++)
            {
                Tape[i+1] = tmp[i];
            }
        }


        public char getHead () => Tape[heade];

        public void GoRight (char data)
        {
            Tape[heade] = data;
            heade++;
        }

        public void GoLeft(char data)
        {
            Tape[heade] = data;
            heade--;
        }

        public void showInput()
        {
             for (int i = 1; ; i++)
             {
            if (Tape[i] == '\0')
                break;
                 Console.Write(Tape[i]);
                }   
        }
    }

