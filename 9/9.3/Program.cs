/*very bad try
int[] grades = [4,7,02,00,10,4,12];
int GetGrade (int courseid) {
   try {
       int grade = grades[courseid];
        if (grade != 02 || 4 || 7 || 10 || 12) {
           throw new Exception ("InvalidGrade");
       }
    } catch (Exception) {} 

   return (grade);
}
*/


//new try
int[] grades = [4,7,02,00,10,4,12];

int GetGrade (int courseid) {
    int grade = grades[courseid];
      if (grade>=2) { //return grade only if it is bigger or equal to 2 (Perhaps also impliment only returning valid grades) 
          return (grade);
      }
      else {
          throw new Exception ("FailingGrade");
      }
}

int count = 0;
int sum = 0; 

for (int courseid = 0 ; courseid<grades.Length ; courseid++) {
    try {
        sum +=  GetGrade(courseid);
        count++; //has to be after sum, otherwise it runs regardless of exception being thrown
    } catch (Exception) {}
}

Console.WriteLine("Average grade is: "+((float) sum/count));