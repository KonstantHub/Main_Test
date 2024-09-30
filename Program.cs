internal class Program
{
    private static void Main(string[] args)
    {
        void printStrArr(string[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.Write(array[array.Length - 1]);
        }

        string[] getNewArray(string[] array)
        {
            int n = 0;
            foreach (string c in array)
            {
                if (c.Length <= 3)
                {
                    n++;
                }
            }
            string[] newStrArray = new string[n];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    newStrArray[j] = array[i];
                    j++;
                }
            }
            return newStrArray;
        }
        Console.Clear();
        string[] strArray = { "Wait", "-5", "Dri", "1he4", "#f" };
        string[] resultArray = getNewArray(strArray);
        printStrArr(resultArray);
    }
}