//Get Academy som konsollapp
//Student
//Lærer
//Fag
//Klasser

using System.Runtime.InteropServices;
using UndervisningUke2;

/*
 let students = [
{
    name: 'Torstein',
    age: 20
 },
{
    name: 'Camilla'
    age: 38
}
]
 */

List<Student> students = new List<Student>()
{ 
    new Student("Torstein",20),
    new Student("Camilla", 38)
};

Student espen = new Student("Espen", 30);
students.Add(espen);

List<Teacher> teachers = new List<Teacher>() { new Teacher("Marie"), new Teacher("Marius") };
bool runProgram = true;
while (runProgram)
{
    Menu();
}

void Menu()
{
    Console.WriteLine("Welcome to Get academy");
    Console.WriteLine("1. Show all students");
    Console.WriteLine("2. Show all Teachers");
    Console.WriteLine("3. Select teacher to preform lecture");
    Console.WriteLine("4. Add new Teacher");
    Console.WriteLine("5. Exit program");

    var menuChoice = Console.ReadLine();

    switch (menuChoice)
    {
        case "1":
            ShowAllStudents();
            break;
        case "2":
            ShowAllTeachers();
            break;
        case "3":
            var teachInput = Console.ReadLine();
            var teacher = FindTeacher(teachInput);
            teacher.GiveLecture();
            break;
        case "4":
            AddNewTeacher();
            break;
        case "5":
            runProgram = false;
        break;
        default:
            Console.WriteLine("Wrong menuChoice");
            break;

    }
}

void AddNewTeacher()
{
    Console.WriteLine("What is the name of the new teacher?");
    var nameInput = Console.ReadLine();
    teachers.Add(new Teacher(nameInput));
}

void RemoveTeacher(string nameToRemove)
{
  var teacherToRemove =  FindTeacher(nameToRemove);
  teachers.Remove(teacherToRemove);
    
}

void ShowAllTeachers()
{
    foreach(var teacher in teachers)
    {
        teacher.Introduction();
    }
}

void ShowAllStudents()
{
    foreach (var student in students)
    {
        student.Introduction();
    }
}

void StudentsWatchLecture()
{
    foreach (var student in students)
    {
        student.WatchLecture();
    }
    //torstein.WatchLecture();
    //camilla.WatchLecture();
}
Teacher FindTeacher(string name)
{
    var teacher = teachers.Where(teacher => teacher.name == name).FirstOrDefault();
    return teacher;
}