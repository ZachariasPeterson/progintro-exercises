//point in time chosen as startpoint january 1st 1970
int TS1970 = 1788958886; //time since 1970 january 1st 1970
int DS1970 = TS1970/60/60/24;
int YS1970 = DS1970/365; //Calculating years since 1970
int DI2026 = DS1970%365; //calculating the days into 2026 by calculating the rest from the division by 365
Console.WriteLine(YS1970);
Console.WriteLine(DI2026);