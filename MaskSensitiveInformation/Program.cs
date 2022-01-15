// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter a secret: ");
string input = Console.ReadLine();
char[] array = input.ToCharArray();

for (int i = 0; i < array.Length; i++)
{
    if (i < array.Length - 4)
    {
        Console.Write('*');
    }
    else
    {
        Console.Write(array[i]);
    }
}