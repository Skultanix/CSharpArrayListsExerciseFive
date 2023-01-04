namespace ArrayListsExerciseFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers;
            while (true)
            { 
            Console.WriteLine("Please input a list of five numbers separated by commas.");
            var userinput = Console.ReadLine();

                if(!String.IsNullOrWhiteSpace(userinput))
                {
                    numbers = userinput.Split(",");
                    if (numbers.Length >= 5)
                        break;
                    Console.WriteLine("List is invalid.");
                }
            }
            List<int> numsAsInt = new List<int>();
            foreach(var number in numbers)
            {
                numsAsInt.Add(Convert.ToInt32(number));
            }
            var smallestNums = new List<int>();
            while(smallestNums.Count < 3)
            {
                var min = numsAsInt[0];
                foreach (var number in numsAsInt)
                {
                    if(number < min)
                        min = number;
                }
                 smallestNums.Add(min);
                 numsAsInt.Remove(min);
            }
            Console.WriteLine("The three smallest numbers are:");
            Console.WriteLine(string.Join(", ", smallestNums));
        }
    }
}