int[] accounts = {903, 716, 67};

int GetAccountNumber () {
    Console.WriteLine("Enter an account number: ");
    while(true) { //makes the code run until a valid input is given, then it returns and the code exits. 
        try {
            return Convert.ToInt32(Console.ReadLine());
        } catch (FormatException) { //catches if the users input cannot be converted to an int
                Console.WriteLine("Invalid input, try again");
            }
    }
}
void PrintAccountState (int accountId){
Console.WriteLine("Account " + accountId + " contains " + accounts[accountId]);
}

try {
    while (true) { //makes the code run again and again unless something forces an exit
            int accountId = GetAccountNumber();
            PrintAccountState(accountId);
        if (accountId>3){  //unecessary, exception gets thrown regardless, you should simply catch IndexOutOfRangeExcpetion
            throw new Exception("Invalid account Id: "+accountId);
        }
    }
}
catch (Exception) {}
