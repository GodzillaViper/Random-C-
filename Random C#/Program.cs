internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        // random.Next(1,101);
        
        // for (int i = 0; i < 100; i++){
        // Console.Write(random.Next(1,101)+ " ");
        // }

        // int mysterynumber = random.Next(1,101);

        // Console.WriteLine("Guess the secret number between 1-100.");

        // while (true) {
        //     int guess = Convert.ToInt32(Console.ReadLine());

        //     if (guess > mysterynumber) {
        //         Console.WriteLine("Guess Lower!");
        //     }

        //     else if (guess < mysterynumber) {
        //         Console.WriteLine("Guess Higher!");
        //     }
        //     else {
        //         Console.WriteLine("Correct!");
        //     }
        // }

        int faces = 6; 
        int throws = 2; 

        //for (int i = 1; i <= throws; i++){
            //int value = random.Next(1, faces + 1);
            //Console.WriteLine($"Throw {i}: {value}");
        //}

        Console.WriteLine("Enter dice example (2t6, 12t20, 4t7 ect....): ");
        string dice = Console.ReadLine();
        string[] components = dice.Split("t");

        throws = int.Parse(components[0]);
        faces = int.Parse(components[1]); 


        
    }
} 