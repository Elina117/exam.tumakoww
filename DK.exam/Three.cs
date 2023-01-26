using System;
namespace DK.exam
{
	public class Three
	{
        public static void buildgraph(bool[][] inputGraph)
        {

            Queue<int> vershina = new Queue<int>();
            int NumberOfVersh = inputGraph.Length;
            List<int> visitedversh = new List<int>();

            vershina.Enqueue(0);

            while (vershina.Count > 0)
            {
                int currentVershina = vershina.Dequeue();
                for (int j = 0; j < NumberOfVersh; j++)
                {
                    if (inputGraph[currentVershina][j] == true
                        && (visitedversh.Contains(j) == false)
                        && (vershina.Contains(j) == false)
                        )
                    {
                        vershina.Enqueue(j);

                    }
                }
                visitedversh.Add(currentVershina);
            }
            int[] expected = visitedversh.ToArray();
            
            Console.WriteLine(expected);
            Console.WriteLine(expected.Length);
        }


        public static void graph(bool[][] inputgraph)
        {
            Queue<int> vershina = new Queue<int>();
            int numberofvershina = inputgraph.Length;
            List<int> visitedvershina = new List<int>();

            vershina.Enqueue(0);

            while(vershina.Count>0)
            {
                int currentvershina = vershina.Dequeue();
                for(int j = 0; j<numberofvershina; j++)
                {
                    if (inputgraph[currentvershina][j] ==true
                        && visitedvershina.Contains(j)==false
                        && vershina.Contains(j)== false)
                    {
                        vershina.Enqueue(j);
                    }
                }
                visitedvershina.Add(currentvershina);
            }
            int[] expected = visitedvershina.ToArray();
        }
    }
}

