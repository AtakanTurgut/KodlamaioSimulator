using BusinessLayer.Concretes;
using DataAccessLayer.Concretes;
using DataAccessLayer.EntityFramework;
using EntityLayer.Entities;

Console.WriteLine("-- Kategoriler --");

CategoryManager categoryManager = new(new CategoryDal());
List<Category> categories = categoryManager.TGetAll();

for (int i = 0; i < categories.Count; i++)
{
    Console.WriteLine(categories[i].CategoryId + " / " + categories[i].Title);
    Console.WriteLine(new string('-', 10));
}

Console.WriteLine("\n-- Eğitmenler --");

InstructorManager instructorManager = new(new InstructorDal());
List<Instructor> instructors = instructorManager.TGetAll();

for (int i = 0; i < instructors.Count; i++)
{
    Console.WriteLine(instructors[i].InstructorId + " / " + instructors[i].ImageUrl + " / " + instructors[i].Name + " " + instructors[i].Surname + " / " + instructors[i].Description);
    Console.WriteLine(new string('-', 10));
}

Console.WriteLine("\n-- Kurslar --");

CourseManager courseManager = new(new CourseDal());
List<Course> courses = courseManager.TGetAll();

for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].CourseId + " / " + courses[i].CategoryId + " / " + courses[i].ImageUrl + " / " + courses[i].Title + " / " + courses[i].ProgressBar + " / " + courses[i].InstructorId);
    Console.WriteLine(new string('-', 10));
}

Console.WriteLine("\n-- Kurs1 Silindi --");
courseManager.TDelete(courses[0]);
for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].CourseId + " / " + courses[i].CategoryId + " / " + courses[i].ImageUrl + " / " + courses[i].Title + " / " + courses[i].ProgressBar + " / " + courses[i].InstructorId);
    Console.WriteLine(new string('-', 10));
}

Console.WriteLine("\n-- Kurs5 Eklendi --");
Course course5 = new Course();
course5.CourseId = 5;
course5.ImageUrl = "jsbasic";
course5.Title = "Javascript Temel";
course5.ProgressBar = 0;
course5.CategoryId = 1;
course5.InstructorId = 2;

courseManager.TAdd(course5);
for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].CourseId + " / " + courses[i].CategoryId + " / " + courses[i].ImageUrl + " / " + courses[i].Title + " / " + courses[i].ProgressBar + " / " + courses[i].InstructorId);
    Console.WriteLine(new string('-', 10));
}