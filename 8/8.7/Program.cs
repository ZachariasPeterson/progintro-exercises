//inputs
double a = 2;
double b = 4;
double c = -1;

//helping functions
double discriminant (double a, double b, double c) {
    double d = b*b-4*a*c;
    return d;
}


//int NumberOfRoots (double a, double b, double c) {
    //if (discriminant(a,b,c)<0) {
//}



//main
double[]? roots (double a, double b, double c) { //make it nullable? if no roots or one root?
    double d = discriminant(a,b,c);
    if (d>0) {  //if d>0 there is 2 roots, we calculate these and assign them to an array
        double[] roots = new double[2];
        roots[0] = (-b - Math.Sqrt(d))/2*a;
        roots[1] = (-b + Math.Sqrt(d))/2*a;
        Console.WriteLine("2 roots = "+roots[0]+" and "+roots[1]);
        return roots; 
    }

    else if (d==0) { //if d==0 there is 1 root, we calculate it and assign it to an array
        double[] roots = new double[1];
        roots[0] = (-b)/2*a;
        Console.WriteLine("1 root = "+roots[0]);
        return roots; 
    }
    else {
        Console.WriteLine("No roots");
        return null; 
    }
    
   
}

//test
roots(a,b,c); //try to make the call and printout seperate things

//build up the basic program and then get more complicated, make a base function for the roots



//if (discriminant(a,b,c) < 0) {
    
    //return roots[]; //throw exception? for one root simply change the array to length 1 and then return that 
//}
//if (discriminant(a,b,c) == 0 {
//return //array with one value and one null?????
//}