
var student2 = new Student(2, "qwer", "543");

var teacher1 = new Teacher(1, "Mahmud", "555");

var student1 = new Student(1, "Muhammad", "qwe");

var teacher2 = new Teacher(2, "Dovud", "444");



var users = new List<User>()
{
    student1,
    student2,
    teacher1,
    teacher2
};
 
 foreach(var item in users)
 {
    item.GetUserInfo();
 }