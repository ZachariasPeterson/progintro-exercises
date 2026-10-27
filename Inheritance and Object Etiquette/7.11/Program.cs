/*sieve of erastothenos
Create a list of consecutive integers from 2 through n: (2, 3, 4, ..., n).
Initially, let p equal 2, the smallest prime number.
Enumerate the multiples of p by counting in increments of p from 2p to n, and mark them in the list (these will be 2p, 3p, 4p, ...; the p itself should not be marked).
Find the smallest number in the list greater than p that is not marked. If there was no such number, stop. Otherwise, let p now equal this new number (which is the next prime), and repeat from step 3.
When the algorithm terminates, the numbers remaining not marked in the list are all the primes below n.
*/

// list of booleans representing if a number is a prime or not
bool[] numbers = new bool[1000000]; //just a bunch of true booleans (remember that that the first element of the array has the adress 0

int pool = numbers.Length;
//initial p = 2
for(int p = 2 ; p<=Math.Sqrt(pool) ; p++){
    if (numbers[p-1] == true) continue; //skips any values that have been marked as true (which here means not a prime) -1 as our array position 2 is the third position
    for (int temp = p ; temp*p<=pool ; temp++){
        numbers[temp*p-1] = true;  //first 2*2 then 2*3 etc.  -1 as we any array element p*temp is one less than what we mean as we start our list at 1 and the array starts at zero
    }
}

//printing out the false values (primes) of our array, to test that it works
for (int i = 0 ; i<10 ; i++){
    if (numbers[i] == false) {
        Console.WriteLine(i+1+" is a prime number"); //+1 as our array starts at 0 and effectively we mean 1 in that zero position, so we increment by 1
    }
}

//find biggest prime, ie. find the first prime counting down from the length of the numbers array
// int biggestprime = 0;
for (int j = 1000000 ; j>1 ; j--){
    if (numbers[j-1] == false){ //-1 so j represents the true number we are looking for and not the array index
        biggestprime = j; 
        break; 
    }
}
Console.WriteLine(biggestprime+" is the largest prime number in the set");



