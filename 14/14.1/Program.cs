//add variable cuteness

class Program {
    public static void Main (string[] args) {
        for(double i = 0; i < 7 ; i++) {
        new Kitten(i); //currently the kittens are not assigned to any variable, so the garbage collector will kill them :(
    }

      Console.WriteLine(Kitten.count);
    
    }
}


public class Kitten {
    //Attributes
    public double cuteness; 
    public static int count = 0;

    //Constructor
    public Kitten (double cutenessValue) {
        this.cuteness = cutenessValue;
        count++;
    }
}