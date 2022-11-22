class House{
    private List<string> house = new List<string>();
    public Creator myCreator = new JSONCreator();
    public House(){
        house.Add("   *  ");
        house.Add("  /*\\ ");
        house.Add(" /***\\ ");
        house.Add(" -----");
        house.Add("|     |");
        house.Add("|     |");
        house.Add("|_____|");
    }

    public House(int height){
        house.Add("   *  ");
        house.Add("  /*\\ ");
        house.Add(" /***\\ ");
        house.Add(" -----");
        for (int i = 0; i < height; i++){
            house.Add("|     |");
        }
        house.Add("|_____|");
    }

    public Product createProduct(){
        return myCreator.createProduct(house);
    }
}