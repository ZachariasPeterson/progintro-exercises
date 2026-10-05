int factorial (int n) {
    //Spexial case: stop when n reaches 0
    if (n<=1){
        return 1;
}
//recursive step
    return n*factorial(n-1);
}

Console.WriteLine("3!="+factorial(3));
Console.WriteLine("5!="+factorial(5));