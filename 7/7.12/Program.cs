int [] monthsNormal = [31,28,31,30,31,30,31,31,30,31,30,31]; 
int [] monthsLeap = [31,29,31,30,31,30,31,31,30,31,30,31];

for (int year = 2000 ; year<=2020 ; year++) {
    int[] pointer = monthsNormal; //default reference to pointer, pointer=months current year
    if (year%4 == 0){ 
        pointer = monthsLeap;
    }
Console.Write(year+": ");
    foreach (int length in pointer) { //for each time pointer gets referenced to an array, this goes through each index/element and prints it plus a space
    Console.Write(length+" "); 
} 
Console.WriteLine("");
}
