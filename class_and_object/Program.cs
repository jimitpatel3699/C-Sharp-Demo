using class_and_object.clcx;

Console.WriteLine("Hello, World!");
Class1 claobj = new Class1();
int a, b;

Console.WriteLine("Enter no 1:");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter no 2:");
b = Convert.ToInt32(Console.ReadLine());
Class1.sum(a,b);
//claobj.sum(a, b);

