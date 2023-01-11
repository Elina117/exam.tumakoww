//Напишите программу, содержащую абстрактный базовый класс ArrayAbstract с защищенным полем,
//являющимся ссылкой на целочисленный массив. У класса должен быть конструктор с одним аргументом
//(определяет размер массива и создает его), В производном классе описать абстрактный метод из базового класса,
//чтобы он сортировал массив по возрастанию методом пузырька. Индексатор определить так, чтобы с его помощью можно
//было прочитать значение элемента массива и присвоить значение элементу массива.целочисленное свойство (значение - размер массива),
//абстрактный метод Sort (без аргументов, не возвращает результат) и индексатор с целочисленным индексом (доступен для чтения и записи).




using System;

namespace exam.tumakoww
{

    abstract class ArrayAbstract
    {
        protected int[] mas;
        private int length { get; set; }


        public int this[int index]
        {
            set { mas[index] = value; }
            get { return mas[index]; }
        }

        public ArrayAbstract(int length)
        {
            this.length = length;
            int[] mas = new int[length];
            this.mas = mas;
        }

        public abstract void Sort();

    }

    class BubbleSort : ArrayAbstract
    {
        public BubbleSort(int length) : base(length)
        {
        }

        public override void Sort()
        {
            int temp;
           
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] < mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;

                    }
                }
            }
            
        }

       class Program
        {

            static void Main(string[] args)
            {
                BubbleSort realis = new BubbleSort(2);
                realis[0] = 3;
                realis[1] = 1;
                realis.Sort();
                Console.WriteLine(realis[0].ToString(), realis[1].ToString());
            }
        }
        

    }


}