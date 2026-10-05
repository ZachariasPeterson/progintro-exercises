class Program {

    // 3. This is the Main-method (the starting line)
    static void MainOld(string[] args) {
        // You write your code here, the execututable code, not the classes/objects 

       
        Customer aCustomer = new Customer("Jack",123456789); 

        aCustomer.Deposit(100);

        aCustomer.Withdraw(50);

        Console.WriteLine(aCustomer.GetBalance());

       
    } //end of MainOld

   
    //start of Main
    static void Main(string[] args) {
        CustomerDatabase SDU = new CustomerDatabase();

        SDU.AddCustomer(new Customer("Brooke",1));
        SDU.AddCustomer(new Customer("Sjawn",2));
        SDU.rmCustomer(2);
        SDU.AddCustomer(new Customer("Shawn",2));
        
        SDU.PrintCustomers();
        
    } //end of Main2
    
}//end of program

// Customer information
class Customer {
    public string name;
    public int id; 
    public double balance; 

    //constructor 1 
    public Customer (string inName, int inId) {
        name = inName;
        id = inId;
        balance = 0; 
    }
    //constructor 2, in=initial
    public Customer (string inName, int inId, double inBalance) {
        name = inName;
        id = inId;
        balance = inBalance; 
    }

    //Method to deposit an amount into the balance of a customers account
    public void Deposit (double amount) {
        balance += amount; 
    }

    //Method to withdraw from an account
    public void Withdraw (double amount) {
        if (balance >= amount) { //add some message or something if this is not the case?
            balance -= amount; 
        }
    }
    public double GetBalance () {
        return balance; 
    }
    
} //end of customer class

    //class for customer database
class CustomerDatabase {
    public Customer?[] customers;

    //constructor for CustomerDatabase
    public CustomerDatabase (){
        customers = new Customer[10];
    }
    //Method for adding customer (check if this actually does what it is supposed to != ??
    public bool AddCustomer (Customer newCustomer) {
        for (int i = 0 ; i<customers.Length ; i++) {
                if (customers[i] == null) {  
                    customers[i] = newCustomer; 
                    return true; 
            } 
        } 
        return false;
    }
    //Method for removing customer, warning at null assignment 
    public bool rmCustomer (int id) {
        for (int i = 0 ; i<customers.Length ; i++) {
            // 1 checking that the account is not null
            // 2. checking if the id field matches the id parameter
            if (customers[i]?.id == id) { //Seeing if id matches any of the id in any accounts - changed from  if (customers[i] != null && customers[i].id == id), so that it now evaluates to false if null
                    customers[i] = null; // Clear the slot, find a way not to use ! (forces it, tells the compiler, i know what i am doing and i dont)
                    return true; 
            } 
        } 
        return false; //customer with given id not found
    }
    //Method for returning contents of the customers array
    public Customer?[] GetCustomers () {
        return (Customer?[])customers.Clone();; //changed from return customers; so we give a shallow copy and protect our database
    }

    //Method for printing all Customer objects in customers
    public void PrintCustomers () {
        Console.WriteLine("----------------");
        foreach (Customer? c in customers) { //c has to be nullable
            if (c == null) continue; //skipping any null elements
        Console.WriteLine("Customer: "+c.name);
        Console.WriteLine("ID: "+c.id);
        Console.WriteLine("Balance: "+c.balance);
        Console.WriteLine("----------------");
        }
    }
}//end of CustomerDatabase class