Console.WriteLine("Введите количество элементов, которые будут в нашем массиве");
int a = int.Parse(Console.ReadLine());
string [] array = new string[a];
int count = 0;
string c = String.Empty;
Console.WriteLine("Вводите элементы в массив");
for(int index=0;index<a;index++)
{
    c=Console.ReadLine();
    array[index]=c;
    if(c.Length<=3)
    {
        count++;
    }
}
Console.WriteLine("Массив, в котором все элементы меньше или равны 3-м:");
string [] array2 = new string[count];
int index2=0; 
for(int index=0;index<a;index++)
{
    if(array[index].Length<=3)
    {
        array2[index2]=array[index];
        index2++;
    }
}
string o = "[";
for(int i=0;i<count;i++)
{
    if(o.Length==1)
    {
        o = o +$"{array2[i]}";
    }
    else
    {
        o = o + $", {array2[i]}";
    }
}
o= o + "]";
Console.WriteLine(o);
