using System;

namespace ListadeOp
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputersList computersList = new ComputersList();

            Console.WriteLine("Code to insert");
            int insert = int.Parse(Console.ReadLine());

            Console.WriteLine("After you want to insert it");
            int after = int.Parse(Console.ReadLine());

            Computers pc1 = new Computers(); //herencia - instancia de clase
            pc1.Mark = "Acer Nitro 5";
            pc1.Ram = 16;
            pc1.Barcode = 1002654894;
            pc1.Processor = "Intel Core i5 8300H";
            computersList.Add(pc1, insert, after); // .Add para llamar una funcion dentro de ComputerList;

            Computers pc2 = new Computers(); //herencia - instancia de clase
            pc2.Mark = "Alienware";
            pc2.Ram = 32;
            pc2.Barcode = 1002654895;
            pc2.Processor = "Intel Core i7 10700k";
            computersList.Add(pc2, insert, after); // .Add para llamar una funcion dentro de ComputerList;

            Computers pc3 = new Computers(); //herencia - instancia de clase
            pc3.Mark = "Legion";
            pc3.Ram = 8;
            pc3.Barcode = 1002654896;
            pc3.Processor = "Amd Ryzen 3 3200g";
            computersList.Add(pc3, insert, after); // .Add para llamar una funcion dentro de ComputerList;

            Computers pc4 = new Computers(); //herencia - instancia de clase
            pc4.Mark = "Lenovo";
            pc4.Ram = 4;
            pc4.Barcode = 1002654897;
            pc4.Processor = "Intel Core i3 8300H";
            computersList.Add(pc4, insert, after); // .Add para llamar una funcion dentro de ComputerList;

            Computers pc5 = new Computers(); //herencia - instancia de clase
            pc5.Mark = "Samsung";
            pc5.Ram = 8;
            pc5.Barcode = 1002654898;
            pc5.Processor = "Amd Ryzen 5 3600";
            computersList.Add(pc5, insert, after); // .Add para llamar una funcion dentro de ComputerList;

            Computers pc6 = new Computers(); //herencia - instancia de clase
            pc6.Mark = "Asus";
            pc6.Ram = 12;
            pc6.Barcode = 1002654899;
            pc6.Processor = "Intel Core i7 8300";
            computersList.Add(pc6, insert, after); // .Add para llamar una funcion dentro de ComputerList;

            computersList.Print();
        }
    }
}
