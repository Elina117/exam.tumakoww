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
        private int _length;
        public int length
        {
            set { _length = value; }
            get { return _length; }
        }


        public ArrayAbstract(int length)
        {
            this.length = length;
        }

        public abstract void BibbleSort();



        public static implicit operator int(ArrayAbstract v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator ArrayAbstract(int v)
        {
            throw new NotImplementedException();
        }



    }

    class Realis : ArrayAbstract
    {
       
        public int[] mas;

        public int this[int index]
        {
            set { mas[index] = value; }
            get { return mas[index]; }
        }

        public Realis(int[] mas, int length) : base(length)
        {
            this.mas = mas;
        }

        public override void BibbleSort()
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
            Console.WriteLine(mas);
        }

       class Program
        {

            static void Main(string[] args)
            {
                Realis realis = new Realis(new[] {3, 2}, 2);
                Console.WriteLine(realis.BibbleSort);
            }
        }
        

    }


}