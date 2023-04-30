namespace ExampleProjWarchallAlgorithm
{
    internal class Program
    {

        /* ------ Floyd Warshall Algorithm ------ */

        public static void FloydWarshall(int[,] graph, int verticesCount)
        {
            int[,] distance = new int[verticesCount, verticesCount];

            for(int i = 0; i < verticesCount; i++)
            {
                for(int j = 0; j < verticesCount; j++)
                {
                    distance[i, j] = graph[i, j];
                }
            }

            for(int k = 0; k < verticesCount; k++)
            {
                for(int i = 0;i < verticesCount; i++)
                {
                    for(int j = 0;j < verticesCount; j++)
                    {
                        if (distance[i, k] + distance[i, k] < distance[i, j])
                        {
                            distance[i, j] = distance[i, k] + distance[k, j];
                        }
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            
        }
    }
}