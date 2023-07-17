// creating array
int[] grades = new int[9];  // empty array
string[] names = { "Justin", "Ethan", "Billy" };

// accessing values
Console.WriteLine(names[1]);
int chosen = 2;
Console.WriteLine(names[chosen]);

// write full array
foreach (string n in names)
{
    Console.WriteLine(n);
}

// changing values
names[2] = "Yumi";
Console.WriteLine(names[2]);

// -------------------------------------------------------------
// looping through arrays
double[] prices =
{
    40,
    1000,
    150,
    5,
    200
};

// for loop
// i == index
// can edit array mid loop

for (int i = 0; i < prices.Length; i++)
{
    if (prices[i] >= 100)
    {
        prices[i] = prices[i] * .85;
    }
    Console.WriteLine(prices[i]);
}

                       // find avg
double total = 0;                  

for (int i = 0; i < prices.Length; i++)
{
    total += prices[i];
}
double avg = total / prices.Length;
Console.WriteLine($"Average price with discounts {avg}");
Console.WriteLine(prices.Average()); // <-- another way to write 

//--------------------------------------------------------------------

// foreach
// simplifies code
// always run through all
// cant change value as you loop
// dont have access to index

double[] prices2 = { 8, 10, 13, 10, 25, 8 };

//double largest = prices2[0];
double largest = double.MinValue;     // finding largest value in loop and storing it
foreach (double p in prices2)
{
    if (p > largest)
    {
        largest = p;
    }
    Console.WriteLine(p);
}
Console.WriteLine($"Largest = {largest}");


// Find the lowest value in the array

//Console.WriteLine(prices2.Min()); <-- another way to write

double smallest = double.MaxValue;
foreach (double p in prices2)
{
    if (p < smallest)
    {
        smallest = p;
    }
}
Console.WriteLine($"Smallest = {smallest}");

//--------------------------------------------------------------------

// rectangle array
int[,] rectangle = new int[3, 5];       // [column, row]
rectangle[2, 3] = 100;
Console.WriteLine(rectangle[2, 3]);     // 100
Console.WriteLine(rectangle[1, 3]);     // 0 (default value)

// jagged arrays
int[][] jagged = new int[3][];
jagged[0] = new int[5];
jagged[1] = new int[3];
jagged[2] = new int[4];
jagged[0][2] = 9;

// methods
int[] values = { 1, 2, 3, 4 };
int[] result = AddOne(values);

Console.WriteLine("Values");
foreach (int v in values)
{
    Console.WriteLine(v);
}
Console.WriteLine("Results");

foreach (int r in result)
{
    Console.WriteLine(r);
}
static int[] AddOne(int[] numArr)
{
    // any changes to arrays in methods effect the original array
    int[] temp = new int[numArr.Length];
    for (int i = 0; i < numArr.Length; i++)
    {
        temp[i] = numArr[i] + 1;
    }
    return temp;
}



// exercise 1
// make an array of values
// ask user to choose an index 0-(Length-1)
// use the index and display and value in console

int[] ex1 = {2, 3, 5, 6, 7};
Console.WriteLine($"Please choose an index. 0 - {ex1.Length - 1}");
int index = int.Parse(Console.ReadLine());
Console.WriteLine(ex1[index]);

// excercise 2
// create another array of values (Make sure there are some duplicates
// ask user to choose any number
// loop through the array and only display index location when the value matches

int[] ex2 = { 3, 6, 3, 2, 6, 7 };
Console.WriteLine("Please enter a number");

int choice = int.Parse(Console.ReadLine());

for (int i = 0; i < ex2.Length; i++)
{
    if (ex2[i] == choice)
    {
        Console.WriteLine(i);
    }
}
