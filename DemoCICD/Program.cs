using System;

namespace DemoCICD
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Không thể chia cho 0");
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("🚀 ỨNG DỤNG DEMO CI/CD - .NET");
            Console.WriteLine("===================================");
            Console.WriteLine();

            Calculator calculator = new Calculator();

            // Hiển thị menu
            Console.WriteLine("Menu tính toán:");
            Console.WriteLine("1. Cộng hai số");
            Console.WriteLine("2. Trừ hai số");
            Console.WriteLine("3. Nhân hai số");
            Console.WriteLine("4. Chia hai số");
            Console.WriteLine("5. Chạy tất cả test");
            Console.WriteLine();

            // Demo tính toán
            Console.WriteLine("📊 Demo tính toán tự động:");
            Console.WriteLine($"   5 + 3 = {calculator.Add(5, 3)}");
            Console.WriteLine($"   10 - 4 = {calculator.Subtract(10, 4)}");
            Console.WriteLine($"   6 * 7 = {calculator.Multiply(6, 7)}");

            try
            {
                Console.WriteLine($"   20 / 5 = {calculator.Divide(20, 5)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"   Lỗi: {ex.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("✅ Ứng dụng chạy thành công!");
            Console.WriteLine("📅 Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            Console.WriteLine("===================================");

            // Giữ cho cửa sổ console không đóng ngay
            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}