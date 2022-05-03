/* check if values in array are even
int[] nbrs = { 7, 11, 42, 99, 32, -14, 1, 72, -54, -45 };

var idx = 0;

while (idx < nbrs.Length) 
    {
    if (nbrs[idx] % 2 == 0) {
        Console.WriteLine($"{nbrs[idx]} is even");
        }
    idx++;    
    }
*/

//create a program that asks user to enter number, then tell if that number is odd or even
Console.Write("Enter an integer. Enter 0 to end. ");
var resp = Console.ReadLine();
var nbr = Convert.ToInt32(resp);

while (nbr != 0) {
    if (nbr % 2 == 0) {
        Console.WriteLine($"{nbr} is even");
        }
    else { Console.WriteLine($"{nbr} is odd"); }

    Console.Write("Enter an integer. Enter 0 to end. ");
     resp = Console.ReadLine();
     nbr = Convert.ToInt32(resp);
    }
Console.WriteLine("Done :)");


/*//count 1-50, sum only numbers evenly divisible by 5 or 7
var sum = 0;
for(var idx = 0; idx <=50; idx++) {
    if (idx % 5 ==0 || idx % 7 == 0) {
        sum = sum + idx;
        }
    }
Console.WriteLine($"Sum is {sum}. ");
*/

