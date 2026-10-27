/*Write a program that calculates all prime numbers below 1,000,000 and prints out the largest.
Hints (unless you want more of a challenge):






//subtasks, 1. iterate through all positive integers below 1 mil 2. determine whether it is a prime number 3. print prime number

// 1.
Console.WriteLine("All prime numbers under 1 million");
for (int i = 1 ; i<1000000 ; i++)  {
//2. check if it has modulo larger than zero, if it does stop and continue to next number
    for (int j = 1; j<1000 ; j++) { //only need to check up until square root of 1 mil
        if (i%j==0) continue; //skips non primes 
    } Console.WriteLine(i+" is a prime number");
}



//second try (even worse)

for (int i = 1 ; i<1000000 ; i++)  {
    if (i==1) {
        Console.WriteLine (i+"is a prime number");
    }
    if (i%2==0) continue;
        for (int j = 5 ; j<1000 ; j+=2) {
            if (j==i) continue;
    if (i%j==0) continue;
    else Console.WriteLine(i+" is a prime number");
        }
}
*/

//Third try
int currentprime = 1; 
for (int i = 2 ; i<1000000 ; i++)  {
    bool isprime = true; 
    
    for (int j = 2 ; j<Math.Sqrt(i) ; j++) { //Only need to check up until square root of i,something bigger than than ca
        if (i%j == 0) {
            isprime = false;
            break; //breaks the loop if it is not a prime number (ie. breaks the inner loop for j, not for i)
        }
    }
    
    if (isprime) { //only goes if isprime==true
        if (currentprime<i) {
            currentprime = i; //sets currentprime to i if i is larger
        }
    }
}
Console.WriteLine(currentprime);


