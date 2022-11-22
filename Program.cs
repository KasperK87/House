// See https://aka.ms/new-console-template for more information
//build a house

/*
System.Console.WriteLine("   *  ");
System.Console.WriteLine("  /*\\ ");
System.Console.WriteLine(" /***\\ ");
System.Console.WriteLine(" -----");
System.Console.WriteLine("|     |");
System.Console.WriteLine("|     |");
System.Console.WriteLine("|_____|");
*/

House house = new House(5);
Product myHousePlan = house.createProduct();

myHousePlan.print();
