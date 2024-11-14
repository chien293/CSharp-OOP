// Base Person Class
public abstract class Person
{
    public string Name { get; set; }
    
    public Person(string name)
    {
        Name = name;
    }

    public virtual string GetDetails() => $"Name: {Name}";
}

// Student Class
public class Student : Person
{
    public int ClassNumber { get; set; }

    public Student(string name, int classNumber) : base(name)
    {
        ClassNumber = classNumber;
    }

    public string GetStudentInfo() => $"{GetDetails()}, Class Number: {ClassNumber}";
}

// Discipline Class
public class Discipline
{
    public string Name { get; set; }
    public int NumberOfLectures { get; set; }
    public int NumberOfExercises { get; set; }

    public Discipline(string name, int numberOfLectures, int numberOfExercises)
    {
        Name = name;
        NumberOfLectures = numberOfLectures;
        NumberOfExercises = numberOfExercises;
    }

    public string GetDisciplineInfo() => $"Discipline: {Name}, Lectures: {NumberOfLectures}, Exercises: {NumberOfExercises}";
}

// Teacher Class
public class Teacher : Person
{
    public List<Discipline> Disciplines { get; set; } = new List<Discipline>();

    public Teacher(string name) : base(name) {}

    public void AddDiscipline(Discipline discipline) => Disciplines.Add(discipline);
    public void RemoveDiscipline(Discipline discipline) => Disciplines.Remove(discipline);

    public string GetTeacherInfo() => $"{GetDetails()}, Disciplines: {string.Join(", ", Disciplines.Select(d => d.Name))}";
}

// Class (School Class) Class
public class Class
{
    public string Identifier { get; set; }
    public List<Student> Students { get; set; } = new List<Student>();
    public List<Teacher> Teachers { get; set; } = new List<Teacher>();

    public Class(string identifier)
    {
        Identifier = identifier;
    }

    public void AddStudent(Student student) => Students.Add(student);
    public void RemoveStudent(Student student) => Students.Remove(student);
    
    public void AddTeacher(Teacher teacher) => Teachers.Add(teacher);
    public void RemoveTeacher(Teacher teacher) => Teachers.Remove(teacher);

    public string GetClassInfo() => $"Class: {Identifier}, Students: {Students.Count}, Teachers: {Teachers.Count}";
}

// School Class
public class School
{
    public List<Class> Classes { get; set; } = new List<Class>();

    public void AddClass(Class schoolClass) => Classes.Add(schoolClass);
    public void RemoveClass(Class schoolClass) => Classes.Remove(schoolClass);

    public string GetSchoolInfo() => $"School has {Classes.Count} classes.";
}
