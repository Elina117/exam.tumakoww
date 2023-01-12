using System;
namespace exam.tumakoww
{
	public abstract class Secondtask
	{
		protected int a { get; set; }
		protected int b { get; set; }

		public Secondtask(int a, int b)
		{
			this.a = a;
			this.b = b;
		}
		public int[] numbers = new int[] { };

		public abstract int this[int index] { get; set; }
		
	}


	interface Iinterface
	{
		public int method_1(int c);
	}


	class Deal : Secondtask, Iinterface
	{
		public Deal(int a, int b) : base(a, b)
		{

		}

        public override int this[int index]
		{
			set { }
			get
			{
				if (index % 2 == 0)
				{
					return a;
				}
				else
				{
					return b;
				}
			}
		}

        public int method_1(int c)
		{
			int result = (a + b)*c;

			return result;
		}
	}


	public class Program
	{
        static void Main(string[] args)
		{

		}

    }
}

