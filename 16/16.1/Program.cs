class Test {
    static void Main (String[] args) {
    }
    
}

public interface IExpirable {
    bool IsExpired (); //no defined body, just an interface that tells all classes that implement the interface must have this function
}

//things in class, attributes: name, price method: getName, getPrice
public abstract class Item : IExpirable {
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

    public abstract bool IsExpired ();
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

    public override bool IsExpired () {
        return DateTime.Now > expiresAt; 
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

    public override bool IsExpired () {
        return false; 
    }
}

public class Inventory {
    Item[] items;

    public Inventory (Item[] inItems){
        items = inItems; 
    }

    public void AddItem (Item newItem) {
        //make a new array that is one larger (Does not check for duplicates! which is maybe ok, we can have multiple of the same item i would say)
        Item[] newItems = new Item[items.Length+1];
        // copy each item of the old array into the new
        for (int i = 0 ; i<items.Length ; i++) {
            newItems[i] = items[i];
        }
        //add new item
        newItems[items.Length+1] = newItem;
        //reassign items to the new array
        items = newItems;
    }

    public void RemoveItem (Item discontinuedItem) {
        //find dicontinued item and set it to null, then copy all non-null items into a new array, finally reassign old array to the new
        int count = 0;
        for (int i = 0 ; i<items.Length ; i++) {
            count++;
            if (items[i] == discontinuedItem) {
                //items[i] = null; //can also have a variable outside to count and then find which element by a count
                break; //breaks out of the loop
            } if (items[count] != discontinuedItem) { //guard if the item is not part of the inventory
                Console.WriteLine("Selected Item is not part of the inventory");
                return;
            }
        }
        Item[] newItems = new Item[items.Length-1];

        for (int i = 0 ; i<items.Length-1 ; i++) {
            if (items[i] != items[count]) { //skips the item we want to remove
                newItems[i] = items[i];
            }
        }
    }

    public double GetInventoryValue () {
        double value = 0;
        foreach (Item item in items) {
            value += item.GetPrice();
        }
        return value;
    }

    public void PrintInventory () {
        string inventory = "";
        for (int i = 0 ; i<items.Length ; i++) {
            inventory += (i==0 ? "" : ", ")+items[i].GetName();
        } 
    Console.WriteLine("Inventory: "+inventory);
    }
}

