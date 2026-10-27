/*rewrite this program to a while loop and do while?

for (double c = -5 ; c<=40 ; c += 0.5) {
    double f = 32 + 9.0/5*c ;
    Console.WriteLine("{0,5:F1}°C {1,5:F1}°F", c, f);
}

*/


//while loop
double c = -5;
double f = 32 + 9.0/5*c ;
while (c <=40){
    Console.WriteLine("{0,5:F1}°C {1,5:F1}°F", c, f);
    c += 0.5;
}

Console.WriteLine("_____________________________"); //seperator for the two loops (that do the exact same thing)

//do-while loop
double c2 = -5;
double f2 = 32 + 9.0/5*c ;

do {
    Console.WriteLine("{0,5:F1}°C {1,5:F1}°F", c2, f2);
c2 += 0.5; 
} while (c2 <=40);


//do while loop
