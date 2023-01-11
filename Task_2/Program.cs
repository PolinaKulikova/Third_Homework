// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = 3;
int x2 = 2;
int y1 = 6;
int y2 = 1;
int z1 = 8;
int z2 = -7;

// int x1 = 7;
// int x2 = 1;
// int y1 = -5;
// int y2 = -1;
// int z1 = 0;
// int z2 = 9;

double distance = GetDistance(x1, y1, z1, x2, y2, z2);
System.Console.WriteLine(Math.Round(distance, 2));

double GetDistance(int x1, int y1, int z1, int x2, int y2, int z3)
{
       return Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));

}

