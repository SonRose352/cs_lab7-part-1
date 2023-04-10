//Проверка для класса Cylinder
using Task_2;

Cylinder cylinder = new Cylinder();
cylinder.input();
cylinder.output();
Console.WriteLine($"Площадь основания цилиндра: {cylinder.baseSquare()}");
Console.WriteLine($"Периметр основания цилиндра: {cylinder.basePerimeter()}");
Console.WriteLine($"Объём цилиндра: {cylinder.volume()}");
Console.WriteLine($"Площадь боковой поверхности цилиндра: {cylinder.sideSurfaceSquare()}");

//Проверка для класса TriangularPrism
TriangularPrism triangularPrism = new TriangularPrism();
triangularPrism.input();
triangularPrism.output();
Console.WriteLine($"Площадь основания треугольной призмы: {triangularPrism.baseSquare()}");
Console.WriteLine($"Периметр основания треугольной призмы: {triangularPrism.basePerimeter()}");
Console.WriteLine($"Объём треугольной призмы: {triangularPrism.volume()}");
Console.WriteLine($"Площадь боковой поверхности треугольной призмы: {triangularPrism.sideSurfaceSquare()}");

//Проверка для класса QuadrilateralPrism
QuadrilateralPrism quadrilateralPrism = new QuadrilateralPrism();
quadrilateralPrism.input();
quadrilateralPrism.output();
Console.WriteLine($"Площадь основания четырёхугольной призмы: {quadrilateralPrism.baseSquare()}");
Console.WriteLine($"Периметр основания четырёхугольной призмы: {quadrilateralPrism.basePerimeter()}");
Console.WriteLine($"Объём четырёхугольной призмы: {quadrilateralPrism.volume()}");
Console.WriteLine($"Площадь боковой поверхности четырёхугольной призмы: {quadrilateralPrism.sideSurfaceSquare()}");
if (quadrilateralPrism.isCube())
    Console.WriteLine("Куб");
else if (quadrilateralPrism.isPryamParall())
    Console.WriteLine("Прямоугольный параллелепипед");
else if (quadrilateralPrism.isParall())
    Console.WriteLine("Параллелепипед");
else
    Console.WriteLine("Ни куб, ни прямоугольный параллелепипед, ни параллелепипед");