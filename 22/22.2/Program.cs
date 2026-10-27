/*
long milliseconds = 1000 ; 

DateTimeOffset thousand = DateTimeOffset.FromUnixTimeMilliseconds(milliseconds);


//could create loop or method for creating all of these

for (int i = 0 ; i < 4 ; i++) {
    DateTime a = System.DateTimeOffset.FromUnixTimeMilliseconds(milliseconds).DateTime ;
    Console.WriteLine(a.ToString());
    milliseconds = milliseconds*10;
}
*/
//cleaned up version after looking at Aslak

class DateTest {
    public static void Main (string[] args) {
        for (long milliseconds = 1000 ; milliseconds <= 1000000  ; milliseconds *= 10) {
        DateTime b = System.DateTimeOffset.FromUnixTimeMilliseconds(milliseconds).DateTime ; //the datetime variable b gets reassigned for each loop, so all but the last iteratiomn of the loop are discareded and collected by the garbage collector
        Console.WriteLine(b.ToString());
        }
    }

}

