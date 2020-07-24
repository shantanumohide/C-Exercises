using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}


class Bike{
  public string brand;
  public string model;
  public int price;
  Bike(string brand, string model, int price){
    brand = brand; model=model; price=price;
  }
  public virtual int getMilage(){
    return 2*price;
  }

  public void startEngine(){
    Console.WriteLine("Engine started");
  }
}

class Car:Bike{
    public string roof_type;
    
    Car(string brand, string model, int price, string roof_type){
      brand = brand; model=model; price=price; roof_type=roof_type;
    }

    public override int getMilage(){
      return price;
    }

}

class Jeep:Bike{
    public string roof_type;
    
    Jeep(string brand, string model, int price, string roof_type){
      brand = brand; model=model; price=price; roof_type=roof_type;
    }

    public override int getMilage(){
      return price;
    }

}

