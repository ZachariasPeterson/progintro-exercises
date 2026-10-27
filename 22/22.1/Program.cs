class Timing () {
static double initialValue = 1.0000001;

    static double Fun (double x, double y) { //has to be static, otherwise we cannot use it without initializing an member of the class
        if (y <= 1) {
            return x; 
        } return Fun(x,y-1)*Fun(x,y-1); 
    }

    public static void Main () {

        for (double y = 1 ; y<=32 ; y++) { //how much to increment y by?
            long start = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            double result = Fun(initialValue,y);
            Console.WriteLine("Fun(x,"+y+") = "+result);
            long end = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            long processingTime = end - start;
            Console.WriteLine("Processing Time = "+processingTime+" milliseconds");
            Console.WriteLine(""); //for seperating each iteration
        }
    }
    
}