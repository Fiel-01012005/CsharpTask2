// See https://aka.ms/new-console-template for more information
// Row 0: Even numbers
// Row 1: Odd numbers
        int[][] numberMatrix = new int[][]
        {
            new int[] { 2, 4, 6, 8, 10 },
            new int[] { 1, 3, 5, 7, 9 }
        };

        Console.WriteLine("The number matrix has been initialized.");

{
    // Digit 1 The number at Row 1, Index 3
    int digit1 = numberMatrix[1][3];

    // Digit 2 The number at Row 0, Index 0
    int digit2 = numberMatrix[0][0];
    
    // Digit 3 The number at Row 1, Index 4
    int digit3 = numberMatrix[1][4]; 

    // Combine the digits (The Key)
    string key = string.Format("{0}{1}{2}", digit1, digit2, digit3);

    // Displaying them as password
    Console.WriteLine();
    Console.WriteLine("These are the extracted numbers from each 3 digits:");
    Console.WriteLine($"Digit 1 is: {digit1}");
    Console.WriteLine($"Digit 2 is: {digit2}");
    Console.WriteLine($"Digit 3 is: {digit3}");
    Console.WriteLine();
    Console.WriteLine($"The password are: {key}");
}
Console.WriteLine("Hello, World!");
