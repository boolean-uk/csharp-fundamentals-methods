// See https://aka.ms/new-console-template for more information
int lower = 10;
int upper = 13;
int[] nums = Enumerable.Range(lower, upper-lower).ToArray();
foreach(var num in nums)
{
    Console.WriteLine(num);
}
Console.WriteLine(nums.Length);
