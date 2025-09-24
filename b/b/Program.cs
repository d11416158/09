using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Read();
            // 輸入身高（公分）
            Console.Write("請輸入您的身高（公分）：");
            string heightInput = Console.ReadLine();
            double heightCm = Convert.ToDouble(heightInput);

            // 輸入體重（公斤）
            Console.Write("請輸入您的體重（公斤）：");
            string weightInput = Console.ReadLine();
            double weight = Convert.ToDouble(weightInput);

            // 將身高從公分轉成公尺
            double heightM = heightCm / 100;

            // 計算BMI = 體重 / (身高(公尺) * 身高(公尺))
            double bmi = weight / (heightM * heightM);

            // 顯示BMI，保留兩位小數
            Console.WriteLine("您的BMI值為：" + bmi.ToString("0.00"));
        }
    }
}


