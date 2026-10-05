//third try

//as long as some value n^2 is less than the input, we can increase the input (until it is less or equal then)

double sqrt(double n){
    double temp = 0.0; // our value eventually represnting the squareroot
    for (double placeValue = 10000 ; placeValue>0.0000001 ; placeValue/=10){ 
        temp += 10*placeValue; //goes through from most significant digit to least, adding the maximum* for each digit from most significant to least.
        for (int i = 0 ; i<10 ; i++){
            temp -= placeValue; //this then subtracts from the maximum (max 10 times, which would then end with 0), until break statement
            if (temp*temp<n) {
            break; //breaks the statement when temp*temp<=n ie. when placeValue has been subtracted enough times that we have found a digit of the squareroot. (ie. the script runs as long as temp*temp is larger than n) 
            }
        }
   
    }
return(temp);
}

Console.WriteLine("squareroot of 16 = "+sqrt(16));
Console.WriteLine("Squareroot of 20 =  "+sqrt(20));
Console.WriteLine("Squareroot of 25 =  "+sqrt(25));

