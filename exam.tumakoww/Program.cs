using System;

namespace exam.tumakoww
{

    abstract class ArrayAbstract
    {
        private int[] _mas;

        public int[] mas
        {
            set { _mas = value; }
            get { return _mas; }
        }

        public ArrayAbstract(int[] mas)
        {
            this.mas = mas;
        }

        public int[] BibbleSort()
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;

                    }
                }
            }
            
        }
        

    }

    class Realis : ArrayAbstract
    {
  
        
        public override void BubbleSort()
        {
            Console.WriteLine(mas);
        }

    }


}