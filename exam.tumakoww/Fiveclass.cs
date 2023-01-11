using System;
namespace exam.tumakoww
{

    public struct first_struct
    {
        public string str;

        public first_struct(string str)
        {
            this.str = str;
        }

        public second_struct create(int arg)
        {
            second_struct bukva = new second_struct(str[arg]);
            
            return bukva;
        }

    }

    public struct second_struct
    {
        public char ch;

        public second_struct(char ch)
        {
            this.ch = ch;
        }

    }






}

