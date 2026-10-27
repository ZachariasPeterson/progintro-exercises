//First iteration
/* 
class Circle {
    public double x, y;
    public double r;

        public Circle (double x, double y, double radius) {
            this.x = x;
            this.y = y;
            this.r = radius;
        }
}

class TestCircle {
    static void Main (string[] args) {
        Circle c = new Circle(1.24, 2.83, 12.7);
        Console.WriteLine("x=" + c.x + " y=" + c.y + " r=" + c.r);
        c.r *= 1.37;
        c.x += 0.65;
        Console.WriteLine("x=" + c.x + " y=" + c.y + " r=" + c.r);
    }
}
*/

//Changing r to d
/*
class Circle {
    public double x, y;
    public double d;

        public Circle (double x, double y, double diameter) {
            this.x = x;
            this.y = y;
            this.d = diameter;
        }
}

class TestCircle {
    static void Main (string[] args) {
        Circle c = new Circle(1.24, 2.83, 6.35);
        Console.WriteLine("x=" + c.x + " y=" + c.y + " d=" + c.d);
        c.d *= 0.685;
        c.x += 0.65;
        Console.WriteLine("x=" + c.x + " y=" + c.y + " d=" + c.d);
    }
}
*/

// Encapsualting all attributes
/*
class Circle {
    private double x, y;
    private double r;

    //Constructor 
        public Circle (double x, double y, double radius) {
            this.x = x;
            this.y = y;
            this.r = radius;
        }

        //getters
        public double GetX (){
            return this.x;
        }

        public double GetY (){
            return this.y;
        }

        public double GetR (){
            return this.r;
        }

        //setters
        public void PlusX (double change) {
            this.x += change;
        }

        public void ScaleR (double scaleBy) {
            this.r *= scaleBy;
        }
        
}

class TestCircle {
    static void Main (string[] args) {
        Circle c = new Circle(1.24, 2.83, 12.7);
        Console.WriteLine("x=" + c.GetX() + " y=" + c.GetY() + " r=" + c.GetR());
        c.ScaleR(1.37);
        c.PlusX(0.65);
        Console.WriteLine("x=" + c.GetX() + " y=" + c.GetY() + " r=" + c.GetR());
    }
}
*/

//Adding coordinate class 
class Coordinate {
    private double x, y;

    public Coordinate (double xValue, double yValue) {
        this.x = xValue;
        this.y = yValue;
    }

    //getters
    public double GetX (){
        return this.x;
    }
    
    public double GetY (){
        return this.y;
    }

    //setters
    public void PlusX (double change) {
        this.x += change;
    }

    public void PlusY (double change) {
        this.y += change;
    }

    
}
class Circle {
    private Coordinate c;
    private double r;

    //Constructor 
        public Circle (Coordinate coordinate, double radius) {
            this.c = coordinate;
            this.r = radius;
        }

        //getters
        public double GetX (){
            return c.GetX();
        }

        public double GetY (){
            return c.GetY();
        }

        public double GetR (){
            return this.r;
        }

        //setters
        public void PlusX (double change) {
            c.PlusX(change);
        }

        public void ScaleR (double scaleBy) {
            this.r *= scaleBy;
        }
        
}


class TestCircle {
    static void Main (string[] args) {
        Coordinate b = new Coordinate(1.24, 2.83);
        Circle c = new Circle(b, 12.7);
        Console.WriteLine("x=" + c.GetX() + " y=" + c.GetY() + " r=" + c.GetR());
        c.ScaleR(1.37);
        c.PlusX(0.65);
        Console.WriteLine("x=" + c.GetX() + " y=" + c.GetY() + " r=" + c.GetR());
    }
}
