using lesson_27;

Console.WriteLine("*****8Fun with Object Cloning****\n");
//две ссылки на один и тот же обьект 
Point p1 = new Point(50, 50);
Point p2 = p1;
p2.X = 0;
Console.WriteLine(p1);
Console.WriteLine(p2);
Console.ReadLine();


Point p3= new Point(100, 100);
Point p4 = (Point)p3.Clone();

//изменить p4.X(Что не приводит к изменению p3.X).
p4.X = 0;

//вывксти все обьекты 
Console.WriteLine(p3);
Console.WriteLine(p4);
Console.ReadLine();