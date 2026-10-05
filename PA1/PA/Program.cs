// I have understood the the task to be, to find the largest negative number, meaning that in an array [1,2,-1, 5 -7] the "correct" number would be -1

int[] num;

num = [-5,4,-7,8,-9,-1,0,-17,50,-2]; 

int ln = num[0]; //current largest negative. Note that num[0] has to be negative, otherwise the following code would always just print num[0]

for(int i = 1 ; i<num.Length ; i++) //going through all indexes in the array
    if (num[i]>=ln && num[i]<0 ){  //Checking if each index is both larger than the current ln and also negative 
        ln = num[i]; //assigning new largest negative 
}
Console.WriteLine(ln); //Writing the largest negative number