int SSN = 21816000; //Seconds since newyear
double price = 599.95;
int MSY = SSN/60/60/24/30; //Months since newyear
if (MSY == 12) {
    price = 0.70*price;
}
Console.WriteLine(price);