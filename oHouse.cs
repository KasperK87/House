class House{
    private List<string> house = new List<string>();
    public House(){
        house.Add("   *  ");
        house.Add("  /*\\ ");
        house.Add(" /***\\ ");
        house.Add(" -----");
        house.Add("|     |");
        house.Add("|     |");
        house.Add("|_____|");
    }

    public void PrintHouse(){
        foreach(string line in house){
            System.Console.WriteLine(line);
        }
    }
}