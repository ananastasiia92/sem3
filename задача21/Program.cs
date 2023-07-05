/*Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();
Console.WriteLine("Введите координату A по оси Х: ");
double Ax = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату A по оси Y: ");
double Ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату A по оси Z: ");
double Az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату B по оси Х: ");
double Bx = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату B по оси Y: ");
double By = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату B по оси Z: ");
double Bz = Convert.ToInt32(Console.ReadLine());

double qarter = Math.Sqrt(Math.Pow((Ax - Bx),2) + Math.Pow((Ay - By),2) + Math.Pow((Az - Bz),2));
Console.WriteLine($"qarter = {qarter:F4}");
