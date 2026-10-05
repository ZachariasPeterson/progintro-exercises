//seperate values
double TempDiff (double t1, double t2) {
    return t2-t1;
}

//array
double[] week = [21.5, 23.7, 19.6, 22.5, 25.3, 21.7, 18.9];


void WTempDiff (double[] W1) {
    for (int i = 0 ; i<7 ; i++) {
    Console.WriteLine(W1[i+1]-W1[i]);
}
}
WTempDiff(week);