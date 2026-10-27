Console.WriteLine("Hello World!");


public class Student {
    public string name;
    public int id;
    
    public Student (string nameValue, int idValue) {
            name = nameValue;
                id = idValue;
    }
    
public string GetName () {
    return name;
    }
    
}

public class Course {
    string
    name;
    
    Student[] participants;
    public Course (string nameValue) {
        name = nameValue;
        participants = new Student[10]; // NOTE: This constant is BAD!
    }
    
    public void Enroll (Student student) {
        for (int i=0 ; i<participants.Length ; i++) {
            if (participants[i] == null) {
                participants[i] = student;
                return;
            }
        }
    }
    
    public void Remove (Student student) {
        for (int i=0 ; i<participants.Length ; i++) {
            if (participants[i] == student) {
                participants[i] = null;
            }
        }
    }
    
    public Student[] GetParticipants () {
        // count number of entries
        int count = 0;
        foreach (Student student in participants) {
            if (student != null) {
                count++;
            }
        }

        // make a copy
        Student[] result = new Student[count];
        int index = 0;
        foreach (Student student in participants) {
            if (student != null) {
                result[index++] = student;
            }
        }
        return result;
    }
}

public class EnrollmentSystem {
    public Student[] students;
    public Course[] courses;

    public void AddStudent (Student newStudent){
        //avoid duplicates  
        foreach (Student i in students) {
            if (newStudent == i){
                Console.WriteLine("Trying to add duplicate student");
                break;
            }
        }
        
        //make a new list
        Student[] NewList = new Student[students.Length+1];
        //copy contents to new list 
        for (int i = 0 ; i<students.Length ; i++){
            NewList[i] = students[i];
            }
        //add newStudent at the last index of NewList
        NewList[students.Length+1] = newStudent;
        //make students point at NewList array
        students = NewList;
    }

    public void RemoveStudent (Student rmStudent) {
        //student not in list, we want to find whether or not a single student in the list matches rmStudent. (use boolean array or boolean?), could also just declare i outside loop and if after the loopit is equal to students.length, we return
        bool found = false;
        
        //find the student to remove and set their index value to null
        for (int i = 0 ; i<students.Length ; i++) {
            if (rmStudent == students[i]) {
                found = true;
                students[i] = null; 
                break;
            }
        }
        if (found == false) {
            Console.WriteLine("Student not found");
            return;
        }
        //create new array, copying all non-null indexes
        Student[] NewList = new Student[students.Length-1];
        for (int i = 0 ; i<students.Length ; i++) {
            if (students[i] != null) {
                NewList[i] = students[i];
            }
        }
    }
   
    public void Enroll(Student student, Course course) {
        course.Enroll(student);
    }
    
    public void Remove(Student student, Course course) {
        course.Remove(student);
    }
    
    public void ShowParticipants(Course course) {
        foreach (Student student in course.GetParticipants()) {
            Console.WriteLine(student.GetName());
        }
    }
    
    public void GetCourses() {
        Console.WriteLine("void for a getter?");
    }
    
    public void GetStudents() {
        Console.WriteLine("void for a getter?");
    }
}