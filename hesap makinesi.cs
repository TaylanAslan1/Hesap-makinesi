using System;

class Hesap Makinesi
{
    static void Main()
    {
        double num1, num2, result = 0;
        char operation;

        Console.WriteLine("Hesap Makinesi");
        Console.WriteLine("****************");

        Console.Write("İlk sayıyı girin: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İşlemi seçin (+, -, *, /): ");
        operation = Convert.ToChar(Console.ReadLine());

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                    Console.WriteLine("Sıfıra bölme hatası!");
                break;
            default:
                Console.WriteLine("Geçersiz işlem!");
                break;
        }

        Console.WriteLine("Sonuç: " + result);

        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
