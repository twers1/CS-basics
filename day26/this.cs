using System;

namespace properties
{
    // ключевое слово this
    class Program 
    {
        static void Main(string[] args)
        {
            Student student = new Student("аыав", new DateTime(2000, 10, 5));
            student.Print();
            // ключевое слово this дает доступ к текущему экземпляру класса
            // Мы не можем использовать ключевое слово this в статистических методах static
            // когда мы используемся модификатор static, у нас нет необходимости
            // создавать экземпляр класса
            
            
            
        }
    }

   
    class Student
    {
        public Student(string lastName, DateTime birthday)
        {
            // ключевое слово this используется в конструкторах, либо же в методах(свойсвах) - есть какаыя-то неоднозначнасть в названии
            // переменных, которые принимаем в качестве параметрах, полей и методов класса
            // this. Слева у нас lastName относится к this, то есть к текущему экземпляру
            // класса. А справа это та переменная, которая используется в качестве параметра
            this.lastName = lastName;
            this.birthday = birthday;
        }

        public Student(string lastName, string firstName, string middleName, DateTime birthday):this(lastName, birthday)   // чтобы не было перегрузки конструкторов и дублирование кода    
        {
            this.firstName = firstName;
            this.middleName = middleName;

        }
        public Student(Student student)
        {
            firstName = student.firstName;
            middleName = student.middleName;
            lastName = student.lastName;
            birthday = student.birthday;
        }

        public  void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }
        private string firstName;
        private string middleName;
        private string lastName;
        private DateTime birthday;

        public void Print()
        {
            // Тут можно не использовать ключевое слово this, потому что тут нет неоднозначности, потому что 
            // в контексте метода принт нет lastName, поэтому он использует нашу переменную lastName
            Console.WriteLine($"{firstName} {lastName} {middleName} {birthday}");
        }
        
    }

    

   
}
