int TSNW =  22779180 ; //time since newyear
int DSNW = TSNW/60/60/24; //days since newyear
int CM = DSNW/30; //Current month
int DICM = DSNW%30; //Days into current month

Console.WriteLine("Current month: "+CM);
Console.WriteLine("Day in month: "+DICM);

if (DSNW == 354) {
    Console.WriteLine("It’s Christmas!");
}