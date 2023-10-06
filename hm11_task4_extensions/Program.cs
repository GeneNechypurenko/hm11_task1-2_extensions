using hm11_task4_extensions;

//Point3D p = new Point3D(3, 2, 5);
//Console.WriteLine($"{p}\n");
//Point3D pr = new Point3D();
//Console.WriteLine($"{pr}\n");

Random rnd = new Random();

int length = rnd.Next(3, 15);

Point3D[] point = new Point3D[length];

for (int i = 0; i < length; ++i) { point[i] = new Point3D(); }

foreach (var el in point) { Console.WriteLine(el); }

double maxDistance = point.CalculateMaxDistance();

Console.WriteLine($"\nMax distance = {maxDistance:F2}");