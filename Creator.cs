abstract class Creator{

 public abstract Product createProduct(List<string> s);

}

class StringCreator : Creator{
    public override Product createProduct(List<string> s){
        Product p = new StringProduct(s);

        return p;
    }
}

class JSONCreator : Creator{
    public override Product createProduct(List<string> s){
        Product p = new JSONProduct(s);

        return p;
    }
}
