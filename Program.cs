internal class Program
{
    private static void Main(string[] args)
    {
    //
        Circles myCircleOne = new Circles(12);
        Console.WriteLine("Dien tich duong tron la{0}",myCircleOne.AreaCircle());
        Console.WriteLine("Chu vi duong tron la{0}",myCircleOne.PerimeteCircle());
        //
    Circles myCircleTwo = new Circles(15);
        Console.WriteLine("Dien tich duong tron la{0}",myCircleTwo.AreaCircle());
        Console.WriteLine("Chu vi duong tron la{0}",myCircleTwo.PerimeteCircle());
        //
        
        //
    Inventory myInventory = new Inventory();

    foreach (var item in myInventory.myItems)
    {
        Console.Write(item.itemName+",");
        Console.Write(item.attack+",");
        Console.Write(item.health+",");
        Console.WriteLine("");
    }
    }  
}