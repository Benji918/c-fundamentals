int num1 = 0;
int num2 = 0;
int num3 = 0;
int num4 = 0;

//declare array
int[] myintarray =  new int[4];

myintarray[0] = 4;
myintarray[1] = 0;
myintarray[2] = 0;
myintarray[3] = 45;
string[] strarr = ["dff", "ffd" ];

foreach (int i in myintarray)
{
    Console.WriteLine(i);
}

Console.WriteLine("Array length " + strarr.Length);

Console.ReadKey();