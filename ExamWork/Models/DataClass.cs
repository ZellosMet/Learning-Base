namespace ExamWork.Models
{
    // Класс занятий
    public class Classes  
    {
        public string Discipline { get; set; }
        public string Date { get; set; }
        public string ClassForm { get; set; }

        public Classes(string discipline, string date, string class_form)
        {
            Discipline = discipline;
            Date = date;
            ClassForm = class_form;
        }
    }
    //Класс студента
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SurName { get; set; }
        public int StudentId { get; set; }
        public bool GroupLeader { get; set; }
        public string Group {  get; set; }

        public Student(string first_name, string last_name, string sur_name, int stud_id, bool group_leader, string group)
        { 
            FirstName = first_name;
            LastName = last_name;
            SurName = sur_name;
            StudentId = stud_id;
            GroupLeader = group_leader;
            Group = group;
        }
    }
    //Класс Лекций
    public class Lecture
    { 
        public string Topic { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Date {  get; set; }


        public Lecture(string topic, string description, string type, string date)
        {
            Topic = topic;
            Description = description;
            Type = type;
            Date = date;
        }   
    }
    //Сервис Групп
    public class GroupServices
    {
        public IList<string> GroupList = new List<string> { "PD-212", "PD-321", "PU-114" };

        public string CurrentGroup;
        //Метод Добавленя
        public bool AddGroup(string name)
        {
            try
            {
                GroupList.Add(name);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Метод Удаления
        public bool DeleteGroup(string name) 
        {
            try
            {
                GroupList.Remove(name);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Метод Изменения
        public bool EditGroup(string name)
        {
            try
            {
                GroupList.Remove(CurrentGroup);
                GroupList.Add(name);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
    //Сервис Занятий
    public class ClassesServices
    {
        readonly static Classes classes1 = new Classes("C++", "10.10.2010", "Morning");
        readonly static Classes classes2 = new Classes("C#", "11.11.2011", "Day");
        readonly static Classes classes3 = new Classes("SQL", "12.12.2012", "Evening");

        public IDictionary<string, Classes> ClassesList = new Dictionary<string, Classes>() 
        { 
            { classes1.Discipline, classes1 }, 
            { classes2.Discipline, classes2 },
            { classes3.Discipline, classes3 }
        };

        public Classes CurrentClasses { get; set; }
        //Метод Добавления
        public bool AddClasses(string discipline, string date, string class_form)
        {
            try
            {
                Classes new_classes = new Classes(discipline, date, class_form);
                ClassesList.Add(discipline, new_classes);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Метод Изменения
        public bool EditClasses(string discipline, string date, string class_form)
        {
            try
            {
                ClassesList.Remove(CurrentClasses.Discipline);
                AddClasses(discipline, date, class_form);
                return true;
            }
            catch (Exception)
            {
                return false;                
            }

        }
        //Метод Получения
        public Classes GetClasses(string discipline)
        { 
            if (ClassesList.TryGetValue(discipline, out var classes))
                return classes;
            return null;
        }
        //Метод Удаления
        public bool DeleteClasses(string discipline)
        {
            try
            {
                ClassesList.Remove(discipline);
                return true;
            }
            catch (Exception)
            {
                return false;                
            }
        }
    }
    //Сервис Студентов
    public class StudentsServices
    {
        readonly static Student student1 = new Student("Petrov", "Petr", "Petrovich", 3546, false, "PD-212");
        readonly static Student student2 = new Student("Ivanov", "Ivan", "Ivanovich", 8675, true, "PD-321");
        readonly static Student student3 = new Student("Grigoriev", "Grigiri", "Grigorievich", 7736, false, "PU-114");

        public IDictionary<int, Student> StudentList = new Dictionary<int, Student>()
        {
            { student1.StudentId, student1 },
            { student2.StudentId, student2 },
            { student3.StudentId, student3 }
        };

        public Student CurrentStudent { get; set; }
        //Метод Получения
        public Student GetStudent(int id)
        { 
            if(StudentList.TryGetValue(id, out var student))
                return student;
            return null;
        }
        //Метод Добавления
        public bool AddStudent(string first_name, string last_name, string sur_name, int stud_id, bool group_leader, string group)
        {
            try
            {
                Student new_student = new Student(first_name, last_name, sur_name, stud_id, group_leader, group);
                StudentList.Add(stud_id, new_student);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Метод Изменения
        public bool EditStudent(string first_name, string last_name, string sur_name, int stud_id, bool group_leader, string group)
        {
            try
            {
                StudentList.Remove(CurrentStudent.StudentId);
                Student new_student = new Student(first_name, last_name, sur_name, stud_id, group_leader, group);
                StudentList.Add(stud_id, new_student);
                return true;

            }
            catch (Exception)
            {
                return false;
            }        
        }
        //Метод удаления
        public bool DeleteStudent(int stud_id)
        {
            try
            {
                StudentList.Remove(stud_id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
    //Сервис Лекций
    public class LectureServices
    {
        readonly static Lecture lecture1 = new Lecture("ASP.NET Routing", "Routing", "Course Work", "20.20.2020");
        readonly static Lecture lecture2 = new Lecture("Date Base", "T-SQL", "Team Project", "23.23.2023");

        public IDictionary<string, Lecture> LectureList = new Dictionary<string, Lecture>()
        {
            { lecture1.Topic, lecture1}, { lecture2.Topic, lecture2}
        };

        public Lecture CurrentLecture { get; set; }
        //Метод Добавления
        public bool AddLecture(string topic, string description, string type, string date)
        {
            try
            {
                Lecture new_lection = new Lecture(topic, description, type, date);
                LectureList.Add(topic, new_lection);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Метод изменения
        public bool EditLecture(string topic, string description, string type, string date)
        {
            try
            {
                LectureList.Remove(CurrentLecture.Topic);
                AddLecture(topic, description, type, date);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Метод Получения
        public Lecture GetLecture(string topic)
        {
            if (LectureList.TryGetValue(topic, out var lecture))
                return lecture;
            return null;
        }
        //Метод Удаления
        public bool DeleteLecture(string topic)
        {
            try
            {
                LectureList.Remove(topic);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
