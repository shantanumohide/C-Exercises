using System;

public class Vehicle{
  public string brand;
  public string model;
  public int price;
  public Vehicle(string abrand, string amodel, int aprice){
    brand = abrand; model=amodel; price=aprice;
  }
  public virtual int getMileage(){
    return price;
  }

  public void startEngine(){
    Console.WriteLine("Engine started");
  }
}

public class Bike:Vehicle{ 
    public Bike(string abrand, string amodel, int aprice):base(
      abrand, amodel, aprice){
      brand = abrand; model=amodel; price=aprice; //roof_type=aroof_type;
    }
    
    public override int getMileage(){
        return 2*price;
    }
}

public class Car:Vehicle{
    public string roof_type;
    
    public Car(string abrand, string amodel, int aprice):base(
      abrand, amodel, aprice){
      brand = abrand; model=amodel; price=aprice; //roof_type=aroof_type;
    }

    public void getRooftype(string aroof_type){
      roof_type=aroof_type;
    }

    //overriding method of base class
    public override int getMileage(){
      return price;
    }

}

public class Jeep:Vehicle{
    public string roof_type;
    
    public Jeep(string abrand, string amodel, int aprice):base(
     abrand, amodel, aprice){
      brand = abrand; model=amodel; price=aprice; //roof_type=aroof_type;
    }

    public void getRooftype(string aroof_type){
      roof_type=aroof_type;
    }
    //overriding method of base class
    public override int getMileage(){
      return price;
    }

}

class MainClass {
  public static void Main (string[] args) {
    
    Bike pulsar = new Bike("Bajaj","Pulsar",50000);
    Console.WriteLine(pulsar.getMileage());
    pulsar.startEngine();

    Car Benz = new Car("Mersedes","Benz",2000000);
    Jeep Scorpio = new Jeep("Mahindra","Scorpio",1500000);
    Benz.getRooftype("HardtTop");
    Scorpio.getRooftype("Sunroof");
    Console.WriteLine(Benz.getMileage());
    Console.WriteLine(Scorpio.getMileage());

    Benz.startEngine();Scorpio.startEngine();
    Console.WriteLine($"Roof type of Benz is: {Benz.roof_type}");
    Console.WriteLine($"Roof type of Scorpio is: {Scorpio.roof_type}");

  }
  
}

