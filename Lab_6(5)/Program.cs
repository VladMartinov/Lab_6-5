string path = @"C:\Users\Соня\Pictures\Saved Pictures\test1.bmp";
string path2 = @"C:\Users\Соня\Pictures\Saved Pictures\test3.bmp";
using (var breader = new BinaryReader(File.OpenRead(path)))
{
    Console.WriteLine("\n1-е Изображение - test1.bmp");
    breader.BaseStream.Position = 2;
    Console.WriteLine($"Размер файла: {breader.ReadInt32()}");
    breader.BaseStream.Position = 18;
    Console.WriteLine($"Ширина изображения в пикселях: {breader.ReadInt32()}");
    breader.BaseStream.Position = 22;
    Console.WriteLine($"Высота изображения в пикселях: {breader.ReadInt32()}");
    breader.BaseStream.Position = 28;
    Console.WriteLine($"Бит/пиксел: {breader.ReadInt32()}");
    breader.BaseStream.Position = 38;
    Console.WriteLine($"Горизонтальное разрешение, пиксел/м: {breader.ReadInt32()}");
    breader.BaseStream.Position = 42;
    Console.WriteLine($"Вертикальное разрешение, пиксел/м: {breader.ReadInt32()}");
    breader.BaseStream.Position = 30;
    Console.WriteLine($"Тип сжатия: {breader.ReadInt32()}");
}
using (var breader1 = new BinaryReader(File.OpenRead(path2)))
{
    Console.WriteLine("\n2-е Изображение - test3.bmp");
    breader1.BaseStream.Position = 2;
    Console.WriteLine($"Размер файла: {breader1.ReadInt32()}");
    breader1.BaseStream.Position = 18;
    Console.WriteLine($"Ширина изображения в пикселях: {breader1.ReadInt32()}");
    breader1.BaseStream.Position = 22;
    Console.WriteLine($"Высота изображения в пикселях: {breader1.ReadInt32()}");
    breader1.BaseStream.Position = 28;
    Console.WriteLine($"Бит/пиксел: {breader1.ReadInt32()}");
    breader1.BaseStream.Position = 38;
    Console.WriteLine($"Горизонтальное разрешение, пиксел/м: {breader1.ReadInt32()}");
    breader1.BaseStream.Position = 42;
    Console.WriteLine($"Вертикальное разрешение, пиксел/м: {breader1.ReadInt32()}");
    breader1.BaseStream.Position = 30;
    Console.WriteLine($"Тип сжатия: {breader1.ReadInt32()}");
}