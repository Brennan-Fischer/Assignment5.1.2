namespace Assignment5._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number which you wish to have individual digits added together");
            string userInput = Console.ReadLine();
            int runningTotal = 0;

            for (int i = 0; i<userInput.Length; i++)
            {
                runningTotal= runningTotal + Convert.ToInt32(Convert.ToString((userInput[i])));
            }
            Console.WriteLine($"Total is{runningTotal}");



            int index = 0;
            runningTotal = 0;
            int total = addNext(index, userInput, runningTotal);
            Console.WriteLine($"Total is {total}");
        }

        static int addNext(int index ,string userInput, int runningTotal) 
        {
             runningTotal = runningTotal + Convert.ToInt32(Convert.ToString(userInput[index]));
            index++;

            if (index>=userInput.Length)
            {
                return runningTotal;
            }

            int total = addNext(index, userInput, runningTotal);
            return total;


        }
    }
}
