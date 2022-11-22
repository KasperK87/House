using System.Text.Json;
using System.Text.Json.Serialization;

class Product
{
    public virtual void print(){
        
    }
}

class StringProduct : Product{
    private List<string> myProdukt;

    public StringProduct(List<string> setProdukt){
        myProdukt = setProdukt;
    }

    public override void print(){
        foreach(string line in myProdukt){
            System.Console.WriteLine(line);
        }
    }
}

class JSONProduct : Product{
    private string myProdukt;

    public JSONProduct(List<string> setProdukt){
        myProdukt = JsonSerializer.Serialize(setProdukt);
    }

    public override void print(){
        Console.WriteLine(myProdukt);
    }
}