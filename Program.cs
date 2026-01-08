Random dice = new Random();
int roll = dice.Next(1,6);

if(roll >3)
{
    Console.Write(">3");
}
 else if (roll%2 == 0)  {
    Console.WriteLine("even");
} else {
    Console.WriteLine("Neither");

}
Console.WriteLine(roll);


