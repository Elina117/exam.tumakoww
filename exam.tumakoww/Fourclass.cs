using System;
namespace exam.tumakoww
{
	public class Fourclass
	{
		private int[] array { get; set; }

		public Fourclass(int[] array)
		{
			this.array = array;
		}

		public int this[int index]
		{
			set { array[index] = value; }
			get { return array[index]; }
		}

		public int GetResult(int[] array)
		{
			return array.Length;
		}
		
	}


	public class Derivedclass
	{
		private char[] mass { get; set; }

		public Derivedclass(char[] mass)
		{
			this.mass = mass;
		}

        public char this[char index]
        {
            set { mass[index] = value; }
            get { return mass[index]; }
        }
    }
}

