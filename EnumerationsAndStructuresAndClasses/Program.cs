namespace EnumerationsAndStructuresAndClasses
{
    internal class Program
    {
        public class Journal
        {
            private string Name;
            private int YearFounded;
            private string Description;
            private string ContactNumbers;
            private string ContactEmail;

            public Journal()
            {
                Name = "";
                YearFounded = 0;
                Description = "";
                ContactNumbers = "";
                ContactEmail = "";
            }

            public Journal(string title, int yearFounded, string description, string contactNumbers, string contactEmail)
            {
                Name = title;
                YearFounded = yearFounded;
                Description = description;
                ContactNumbers = contactNumbers;
                ContactEmail = contactEmail;
            }
            public void Input()
            {
                Console.WriteLine("Название журнала:");
                Name = Console.ReadLine();

                Console.WriteLine("Год основания:");
                yearFounded = int.Parse(Console.ReadLine());

                Console.WriteLine("Описание:");
                Description = Console.ReadLine();

                Console.WriteLine("Введите контактные номера:");
                ContactNumbers = Console.ReadLine();

                Console.WriteLine("Введите контактный имейл:");
                contactEmail = Console.ReadLine();
            }

            public void Output()
            {
                Console.WriteLine($"Название журнала: {Name}");
                Console.WriteLine($"Год выпуска: {YearFounded}");
                Console.WriteLine($"Описание: {Description}");
                Console.WriteLine($"Контактный номер: {ContactNumbers}");
                Console.WriteLine($"Контактный имейл: {ContactEmail}");
            }
            public string name
            {
                get { return Name; }
                set { Name = value; }
            }

            public int yearFounded
            {
                get { return YearFounded; }
                set { YearFounded = value; }
            }

            public string description
            {
                get { return Description; }
                set { Description = value; }
            }

            public string contactNumbers
            {
                get { return ContactNumbers; }
                set { ContactNumbers = value; }
            }

            public string contactEmail
            {
                get { return ContactEmail; }
                set { ContactEmail = value; }
            }
        }




        public class Plane
        {
            private string Name;
            private string Manufacturer;
            private int YearOfManufacture;
            private string Type;

            public Plane()
            {
                Name = "";
                Manufacturer = "";
                YearOfManufacture = 0;
                Type = "";
            }
            public Plane(string name, string manufacturer, int yearOfManufacture, string type)
            {
                Name = name;
                Manufacturer = manufacturer;
                YearOfManufacture = yearOfManufacture;
                Type = type;
            }

            public void Input()
            {
                Console.WriteLine("Введите название самолета:");
                Name = Console.ReadLine();

                Console.WriteLine("ВВедите производителя:");
                Manufacturer = Console.ReadLine();

                Console.WriteLine("Год производства:");
                YearOfManufacture = int.Parse(Console.ReadLine());

                Console.WriteLine("Тип самолета:");
                Type = Console.ReadLine();
            }

            public void Output()
            {
                Console.WriteLine($"Название самолета: {Name}");
                Console.WriteLine($"Название производителя: {Manufacturer}");
                Console.WriteLine($"Год выпуска: {YearOfManufacture}");
                Console.WriteLine($"Тип самолёта: {Type}");
            }
            public string GetPlaneName()
            {
                return Name;
            }

            public void SetPlaneName(string name)
            {
                Name = name;
            }

            public string GetManufacturer()
            {
                return Manufacturer;
            }

            public void SetManufacturer(string manufacturer)
            {
                Manufacturer = manufacturer;
            }

            public int GetYearOfManufacture()
            {
                return YearOfManufacture;
            }

            public void SetYearOfManufacture(int year)
            {
                YearOfManufacture = year;
            }

            public string GetPlaneType()
            {
                return Type;
            }

            public void SetPlaneType(string type)
            {
                Type = type;
            }
        }
    


        public class RangeSumCalculator
        {
            public static int CalculateSum(int start, int end)
            {
                int sum = 0;

                for (int i = start; i <= end; i++)
                {
                    sum += i;
                }

                return sum;
            }
        }

        public enum ClientStatus
        {
            First,
            Second,
            Third,
            Fourth,
            Fifth
        }

        struct Client
        {
            public int ClientCode { get; set; }
            public string FullName { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
            public int NumberOfOrders { get; set; }
            public decimal TotalOrderAmount { get; set; }
            public ClientStatus Status { get; set; }

            public Client(int clientCode, string fullName, string address, string phone, int numberOfOrders, decimal totalOrderAmount, ClientStatus status)
            {
                ClientCode = clientCode;
                FullName = fullName;
                Address = address;
                Phone = phone;
                NumberOfOrders = numberOfOrders;
                TotalOrderAmount = totalOrderAmount;
                Status = status;
            }

            public void Print()
            {
                Console.WriteLine($"Код клиента: {ClientCode}");
                Console.WriteLine($"ФИО: {FullName}");
                Console.WriteLine($"Адрес: {Address}");
                Console.WriteLine($"Телефон: {Phone}");
                Console.WriteLine($"Количество заказов: {NumberOfOrders}");
                Console.WriteLine($"Общая сумма заказов: {TotalOrderAmount}");
                Console.WriteLine($"Статус клиента: {Status}");
            }
        }
        static void Main(string[] args)
        {
            //1) Описать структуру Client, содержащую поля: код клиента; ФИО;
            //адрес; телефон; количество заказов, осуществленных клиентом; общая сумма заказов клиента.
            //Описать перечисление ClientType, определяющее важность клиента,
            //и добавить соответствующее поле в структуру Client.
            //Включите в структуру конструктор с параметрами и метод Print().
            //Создать экземпляр структуры.

            Console.WriteLine("1 Задание");
            Client client = new Client(
                clientCode: 1,
                fullName: "Бучко Виктория Игоревна",
                address: "Садовая",
                phone: "12345678",
                numberOfOrders: 10,
                totalOrderAmount: 2000m,
                status: ClientStatus.First
            );
            client.Print();


            //2) Напишите метод, который возвращает сумму чисел
            //в указанном диапазоне. Метод принимает в качестве параметров границы диапазона.
            Console.WriteLine("\n2 Задание");
            Console.WriteLine("Введите начальное значение диапазона:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите конечное значение диапазона:");
            int end = int.Parse(Console.ReadLine());

            int sum = RangeSumCalculator.CalculateSum(start, end);

            Console.WriteLine($"Сумма чисел в диапазоне от {start} до {end} = {sum}");



            //3) Реализуйте класс «Самолёт». Необходимо хранить в полях класса:
            ////название самолёта, название производителя, год выпуска, тип самолёта.
            //Реализуйте конструкторы и методы класса для ввода данных, вывода данных
            //, реализуйте доступ к отдельным полям через методы класса.

            Console.WriteLine("\n3 Задание");
            Plane plane1 = new Plane("Boeing", "Boeing", 2000, "Пасажирский");

            Console.WriteLine("Информация о первом самолете:");
            plane1.Output();

            Console.WriteLine();

            Plane plane2 = new Plane();
            Console.WriteLine("Введите информацию для 2 самолета:");
            plane2.Input();

            Console.WriteLine("\nИнформация о 2 самолете:");
            plane2.Output();

            //4) Создайте класс «Журнал». Необходимо хранить в полях класса:
            //название журнала, год основания, описание журнала, контактный телефон, контактный e-mail.
            //Реализуйте методы класса для ввода данных, вывода данных,
            //реализуйте доступ к отдельным полям через свойства класса.
            Console.WriteLine("\n4 Задание");
            Journal journal1 = new Journal("Книжун", 1995, "123456789", "123456", "12345.com");

            Console.WriteLine("Информация об 1 журнале:");
            journal1.Output();

            Console.WriteLine();
            Journal journal2 = new Journal();
            Console.WriteLine("Введите информацию для 1 журнала:");
            journal2.Input();

            Console.WriteLine("\nИнформация об 2 журнале:");
            journal2.Output();
        }
    }
}
