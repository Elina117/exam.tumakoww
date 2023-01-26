using System;
namespace DK.exam
{
	public class Two
	{
        //public int[] array;
        //public int leftIndex;
        //public int rightIndex;

        //public Two(int[] array, int leftIndex, int rightIndex)
        //{
        //    this.array = array;
        //    this.leftIndex = leftIndex;
        //    this.rightIndex = rightIndex;
        //}

        public static Queue<int> QueckSort(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }

                Queue<int> cards = new Queue<int>(array);
                return cards;

            }

            
        }
    }

    public class Cards
    {
        public void Play()
        {
            //1 - взять карту
            //2- посмотреть верхнюю карту и сбросить
            //3 - положить в сброс

            Console.Write("take the cards and chose the action: ");
            Queue<int> cards = new Queue<int>(7);
            int action = 0;
            if (cards.Count>0)
            {
                switch (action)
                {
                    case 1:
                        {
                            cards.Enqueue(1);//добавляем в конец еще одну карту
                            break;
                        }
                    case 2:
                        {
                            cards.Peek();
                            break;
                        }
                    case 3:
                        {
                            cards.Dequeue();
                            break;
                        }

                }
            }
            else
            {
                int[] array = cards.ToArray();
                
                Two sort = new Two();
                Two.QueckSort(array, 0, 5);
            }
            
        }
    }
}

