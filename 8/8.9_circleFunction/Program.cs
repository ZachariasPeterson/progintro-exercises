double Area (int r) {
    return (r*r*3.14);
}
double Circumference (int r) {
    return (r*2*3.14);
}

for (int r=1 ; r<=5 ; r+=2) {
    Console.WriteLine("Area of circle with radius of "+r+": "+Area (r));
    Console.WriteLine("Circumference of circle with radius of "+r+": "+Circumference (r));
}