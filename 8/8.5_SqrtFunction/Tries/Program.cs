//n is the number that must be found the square root to, d is the amount of decimals
double sqrt (double n) {
    double temp = 0.0;
    for (int i = 1 ; i*i<=n ; i++) { //incremented by one makes digits smaller impossible to calculate 
        temp++; //Increasing temp until it squared is equal to the first digit of the result of the square root
}
    if (n==temp*temp){ 
        return temp; //returning temp if there is no rest, ie. the square root is correct
}
    double rest = (n-(temp*temp)); //wrong
    return temp+sqrt(rest)/10; //wrong
}


Console.WriteLine(sqrt(24));
Console.WriteLine(sqrt(16));

    //BIG ISSUE, the code will run infinitely if provided with a number where the decimals are infinite, find solution. 





    //second try, maybe use cases (for decimal points??)
    
    //as long as some value n^2 is less than the input, we can increase the input (until it is less or equal then)
    
    double sqrt (double n) {
    double temp = 0.0;
    for (int i = 1 ; i*i<=n ; i++) { //incremented by one makes digits smaller impossible to calculate, find some way to on second, third loop, increment by /10 less
        temp++;
    }
        if (n==temp*temp){ 
            return temp; //returning temp if there is no rest, ie. the square root is correct
    }
    for (double i = temp ; i*i<=n ; i+=0.1) { //incremented by one makes digits smaller impossible to calculate, find some way to on second, third loop, increment by /10 less
        temp+=0.1;
    }
        if (n==temp*temp){ 
            return temp;
    }
    return temp;
    }
    
    //smarter way to write this pattern?
    Console.WriteLine(sqrt(24));
    Console.WriteLine(sqrt(16));
    
    
    //have some pointer indicating decimal points and use this
    // also have use cases (if temp*temp>n break)
