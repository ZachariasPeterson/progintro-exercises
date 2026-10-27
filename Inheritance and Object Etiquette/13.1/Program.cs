class Program {
    static void Main (string[] args){
        FoodItem[] Dairy = new FoodItem[10];

        //filling array with milk
        for (int i = 0 ; i<Dairy.Length ; i++) {
            Dairy[i] = new FoodItem("Milk nr." + i, 9.99, new DateTime(2026, 10, 11, 0, 0, 0));
    
        }

        //Printing out all array elements
        string allMilk = "";
        for (int i = 0 ; i<Dairy.Length ; i++) {
            allMilk += Dairy[i].ToString();     
        }
    Console.WriteLine(allMilk);
    }
}
//things in class, attributes: name, price method: getName, getPrice
public class Item {
    string name;
    double price;

//constructor 
    public Item (string nameValue, double priceValue) {
        name = nameValue;
        price = priceValue;
    }

    //Methods 
    public string GetName () {
        return name; 
    }
    public double GetPrice () {
        return price; 
    }
}


public class FoodItem : Item {
    //added attributes
    DateTime expiresAt;

    //Constructor
    public FoodItem (string name, double price, DateTime expiresAtValue) : base(name, price) {
        expiresAt = expiresAtValue;
    }
    
    //Methods
    public DateTime GetExpiresAt () {
        return expiresAt;
    }
    
    public override string ToString () {
    return GetName() + "\n"+
    "Price: "+ GetPrice() + "\n"+
    "Expires at: " + GetExpiresAt() + "\n\n";
    }

}

public class NonFoodItem : Item {
    //added attributes 
    string[] materials;

    //Constructor 
    public NonFoodItem (string name, double price, string[] materialValues) : base(name, price) {
        materials = materialValues;
    }

    //Methods
    string[] GetMaterials () {
        return materials;
    }

    public override string ToString () {
       string allMaterials = "";
        for (int i = 0 ; i<materials.Length ; i++) {
            allMaterials += (i==0 ? "" : ",") + materials[i]; //i==0 ? means if i is 0 write "" else write ","
        }
        return "FoodItem name: " + GetName() +"\n"+ 
        "FoodItem price: " + GetPrice() +"\n"+ 
        "Materials: " + allMaterials+"\n\n";
    }//have some code that for each element in materials takes that string and adds it to a string value with space and comma
}

