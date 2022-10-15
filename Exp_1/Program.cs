using System.Linq;
bool IsEven(int value)
{
    return value % 2 == 0;
}
//* bool IsEven(int value) => value % 2 == 0;

//** var IsEven = (int v) => v % 2 == 0;

var a = 12;
// Console.WriteLine(a.GetType());

var data = new int[]{1,2,3,4}
    .Where(e => e > 0)
    .Select(e=> new{q= e, w = e + 1});

Console.WriteLine(data.GetType().Name);