using Lab29_Console_App;

class Program
{

    static UserDatabase userDb = new UserDatabase();
    static Zoomarket zoomarket = new Zoomarket();
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Istediyiniz prosesin reqemini secin:");
            Console.WriteLine("1. Giriş");
            Console.WriteLine("2. Qeydiyyat");
            Console.WriteLine("3. Çıxış");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Duzgun secin!");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Login();
                    break;
                case 2:
                    Register();
                    break;
                case 3:
                    Console.WriteLine("Çıxış edilir...");
                    return;
                default:
                    Console.WriteLine("Duzgun secin!");
                    break;
            }
        }
    }

   

    static void Register()
    {
        Console.WriteLine("Istifadeci adı: ");
        string username = Console.ReadLine();
        Console.WriteLine("Şifre: ");
        string password = Console.ReadLine();
        Console.WriteLine("Rol seçin (1: Admin, 2: Moderator, 3: User): ");
        int roleChoice;
        if (!int.TryParse(Console.ReadLine(), out roleChoice) || roleChoice < 1 || roleChoice > 3)
        {
            Console.WriteLine("Yalnis rol seçimi!");
            return;
        }
        Role role = (Role)(roleChoice - 1);

        UserDatabase.RegisterUser(username, password, role);
        Console.WriteLine("Qeydiyyat Ugurludur");
    }


    static void Login()
    {
        Console.WriteLine("Kullanıcı adı: ");
        string username = Console.ReadLine();
        Console.WriteLine("Şifre: ");
        string password = Console.ReadLine();

        var user = UserDatabase.LoginUser(username, password);
        if (user == null)
        {
            Console.WriteLine("Giriş olmadi. Istifadeci adı veya şifre yanlış.");
            return;
        }

        Console.WriteLine($"Xoş geldiniz, {user.Username}!");

        switch (user.Role)
        {
            case Role.Admin:
                AdminMenu();
                break;
            case Role.Moderator:
                ModeratorMenu();
                break;
            case Role.User:
                UserMenu();
                break;
            default:
                Console.WriteLine("Yalnis rol seçimi!");
                break;
        }
    }

    static void AdminMenu()
    {
        while (true)
        {
            Console.WriteLine("Admin paneline xoş geldiniz.");
            Console.WriteLine("Istediyiniz prosesin reqemini secin:");
            Console.WriteLine("1. Mehsul elave et");
            Console.WriteLine("2. Mehsulu yenile");
            Console.WriteLine("3. Mehsulu sil");
            Console.WriteLine("4. Çıxış");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Yanlis seçim!");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Mehsul adı: ");
                    string productName = Console.ReadLine();
                    zoomarket.AddProduct(productName);
                    Console.WriteLine("Mehsul elave olundu.");
                    break;
                case 2:
                    Console.WriteLine("Yenilenecek mehsulun adı: ");
                    string oldProductName = Console.ReadLine();
                    Console.WriteLine("Yeni mehsul adı: ");
                    string newProductName = Console.ReadLine();
                    zoomarket.UpdateProduct(oldProductName, newProductName);
                    Console.WriteLine("Mehsul Yenilendi.");
                    break;
                case 3:
                    Console.WriteLine("Silinecek Mehsul adı: ");
                    string deletedProductName = Console.ReadLine();
                    zoomarket.DeleteProduct(deletedProductName);
                    Console.WriteLine("Mehsul silindi.");
                    break;
                case 4:
                    Console.WriteLine("Çıxış edilir...");
                    return;
                default:
                    Console.WriteLine("Yanlis secim");
                    break;
            }
        }
    }

    static void ModeratorMenu()
    {
        while (true)
        {
            Console.WriteLine("Moderatör paneline xoş geldiniz.");
            Console.WriteLine("Istediyiniz prosesin reqemini secin:");
            Console.WriteLine("1. Mehsul elave et");
            Console.WriteLine("2. Mehsulu Yenile");
            Console.WriteLine("3. Çıxış");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Yanlis secim");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Mehsul adı: ");
                    string productName = Console.ReadLine();
                    zoomarket.AddProduct(productName);
                    Console.WriteLine("Mehsul elave olundu.");
                    break;
                case 2:
                    Console.WriteLine("Yenilenecek mehsul adı: ");
                    string oldProductName = Console.ReadLine();
                    Console.WriteLine("Yeni mehsul adı: ");
                    string newProductName = Console.ReadLine();
                    zoomarket.UpdateProduct(oldProductName, newProductName);
                    Console.WriteLine("mehsul yenilendi.");
                    break;
                case 3:
                    Console.WriteLine("Çıxış edilir...");
                    return;
                default:
                    Console.WriteLine("yalnis seçim!");
                    break;
            }
        }
    }

    static void UserMenu()
    {
        while (true)
        {
            Console.WriteLine("Istifadeci paneline xoş geldiniz.");
            Console.WriteLine("Istediyiniz prosesin reqemini secin:");
            Console.WriteLine("1. Alışveriş ele");
            Console.WriteLine("2. Çıxış");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Yalnis seçim!");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Alışveriş edilir...");
                    // Alışveriş işlemleri burada gerçekleştirilir
                    Console.WriteLine("Alışveriş tamamlandı.");
                    break;
                case 2:
                    Console.WriteLine("Çıxış olunur...");
                    return;
                default:
                    Console.WriteLine("Yalnis secim!");
                    break;
            }
        }
    }
}

