using hm11_task4_extensions;
using hm11_task4_extensions.hm11_task4_extensions;

Point3D[] point = new Point3D[]
{
    new Point3D(),
    new Point3D(),
    new Point3D(),
    new Point3D(),
    new Point3D(),
    new Point3D(),
    new Point3D(),
    new Point3D(),
    new Point3D(),
    new Point3D(),
    new Point3D(),
    new Point3D(),
    new Point3D(),
};

foreach (var el in point) { Console.WriteLine(el); }

double maxDistance = point.CalculateMaxDistance();

Console.WriteLine($"\nMax distance = {maxDistance:F2}");