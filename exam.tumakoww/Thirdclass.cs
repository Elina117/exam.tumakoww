using System;
namespace exam.tumakoww
{
	public class Thirdclass
	{
		public int number { get; set; }
        

        public string str { get; set; }
        

        public Thirdclass(int number, string str)
		{
			this.str = str;
			this.number = number;
		}


		public static bool operator > (Thirdclass str_1, Thirdclass str_2)
		{
			return str_1 > str_2;
		}
		public static bool operator < (Thirdclass str_1, Thirdclass str_2)
		{
			return !(str_1 < str_2);
		}



		public static bool operator >= (Thirdclass number_1, Thirdclass number_2)
		{
			return number_1 >= number_2;
		}
		public static bool operator <= (Thirdclass number_1, Thirdclass number_2)
		{
			return number_1 <= number_2;
		}



		public static bool operator == (Thirdclass number_1, int number_2)
		{
			return number_1 == number_2;
		}
		public static bool operator != (Thirdclass number_1, int number_2)
		{
			return !(number_1 == number_2);
		}


        public static bool operator ==(Thirdclass str_1, string str_2)
        {
            return str_1 == str_2;
        }
        public static bool operator !=(Thirdclass str_1, string str_2)
        {
            return !(str_1 == str_2);
        }




        public override bool Equals(object? obj)
        {
            return obj is Thirdclass thirdclass &&
                   number == thirdclass.number;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(number);
        }
    }
}

