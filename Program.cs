class Program
{
    static List<Student> students = new List<Student>();

    static void Main(string[] args)
    {
        string command = "";

        while(command != "exit")
        {
            Console.WriteLine("buyruq kiriting(add, view, delete, exit): ");
            command = Console.ReadLine();

            switch(command)
            {
                case "add":
                    AddStudent();
                    break;
                case "view":
                    View();
                    break;
                case "delete":
                    delete();
                    break;
                case "exit":
                    Console.WriteLine("dasturdan chiqilmoqda...");
                    break;
                default:
                    Console.WriteLine("Noto'g'ri buyruq...");
                    break;
            }

            static void AddStudent()
            {
                Console.WriteLine("Familiyangizni kiriting: ");
                string sureName = Console.ReadLine();
                Console.WriteLine("Talabaniing ismi: ");
                string name = Console.ReadLine();
                Console.WriteLine("Talabaning yoshi: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Telefon raqami: ");
                int tell = Convert.ToInt32(Console.ReadLine());

                students.Add(new Student(sureName, name, age, tell));
                Console.WriteLine("Talaba qo'shildi.");
            }

            static void View()
            {
                Console.WriteLine("Talabalar ro'yxati: ");
                for(int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine($"{i+1}. Familya: {students[i].SureName}, Ismi: {students[i].Name}, Yoshi: {students[i].Age}, Telefon: {students[i].Tell}");
                }
            }

            static void delete()
            {
                View();
                Console.WriteLine("O'chirish uchun student raqamini kiriting: ");
                int studentNumber = Convert.ToInt32(Console.ReadLine());
                if(studentNumber > 0 && studentNumber <= students.Count)
                {
                    students.RemoveAt(studentNumber-1);
                    Console.WriteLine("Talaba o'chirildi.");
                }
                else
                {
                    Console.WriteLine("Noto'g'ri raqam.");
                }
            }
        }
    }

    class Student
    {
        public string SureName {get; set;}
        public string Name {get; set;}

        public int Age {get; set;}

        public int Tell {get; set;}

        public Student(string sureName, string name, int age, int tell)
        {
            Name = name;
            Age = age;
            SureName = sureName;
            Tell = tell;
        }
    }
}

//class program - bu kod Program nomli sinfni aniqlaydi.
//C# dasturlari Main metodini o'z ichiga olgan sinfdan boshlanadi

//ststaic List<Student> students - new List<Student>(); - bu yerda students nomli List<Student>
//turdagi static o'zgaruvchi yaratilmoqda. Bu ro'yxat barcha talaba obyektlarini saqlaydi.

//static void Main(string[] args) - Main metodi datur ishga tushirilganda birinchi bolib bajaradigan metoddir
//string[] args parametrini qabul qladi, bu orqali dasturga komanda qatori argumentlarini yuborilishi mumkin

//string command = ""; - comman nomli o'zgaruvchi yaratilmoqda b u foydalanuvchi kiritgan buyruqlarni saqlashuchun ishlatiladi
//Console.WriteLine("Buyruq kiriting:{add, view, delete, exit}") - foydalanuvchidan buyruq kiritishini so'raydi va ekranga chqaradi

//Comman.Console.ReadLine() - Foydalanuvchi tomonidan kiritgan buyruqni o'zlashtiradi va command o'zgaruvchiga saqlaydi.

//Sinf(Class) C# dasturlash tilida sinf - bu ma'lumotlar va metodlarni o'zida saqlovchi mantiqiy tuzilma.
//Student sinfini yaratdik
//hususiyatlari(Properties) - Xususiyatlar sinifning kirishni taminlovchi o'zgaruvchilar

//Class Student - buyerda student nomli sinf yaratildi, Bu sinf talabaning ismi va yoshi haqida malumot saqlaydi

//public string Name(get, set) - bu xususiyat talabaning ismini saqlaydi, public calit so'zi bu xususiyatni sinfdan tashqarida
//public int Age (get, set) - yoshini saqlaydi xuddi Name kabi, bu ham ochiq(public) va o'qish yozish imkoniyatiga ega.

//public Student(string name, int age) - bu konstruktor metodi bo'lib yangi student obyektini yaratishda chaqiriladi.
//U ikkita parametrini (name, age) qabul qiladi va bu qiymatlarni Name va Age xususiyatlariga o'rnatadi