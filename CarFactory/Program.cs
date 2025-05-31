using System;
using System.Collections.Generic;

namespace CarFactory
{
    public class Program
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();

            while (true)
            {
                Console.WriteLine("Araba üretmek ister misiniz? (e/h)");
                try
                {
                    char answer = Convert.ToChar(Console.ReadLine().ToLower());
                    if (answer == 'e')
                    {
                        Console.WriteLine("Araç üretimi başlıyor...\n");
                        break;
                    }
                    else if (answer == 'h')
                    {
                        Console.WriteLine("Program sonlandırıldı.");
                        return;
                    }
                    else
                        Console.WriteLine("Geçersiz bir harf girdiniz.'e' veya 'h' giriniz.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Geçersiz yanıt verdiniz.\n");
                }
            }
        createCar:
            Console.WriteLine("Arabanın seri numarasını giriniz.");
            string productSerialNumber = Console.ReadLine();

            Console.WriteLine("Arabanın markasını giriniz.");
            string productBrand = Console.ReadLine();

            Console.WriteLine("Arabanın modelini giriniz.");
            string productModel = Console.ReadLine();

            Console.WriteLine("Arabanın rengini giriniz.");
            string productColor = Console.ReadLine();


        getDoorNumber:

            Console.WriteLine("Araban kapı sayısını giriniz.");

            int productDoorNumber;

            try
            {
                productDoorNumber = Convert.ToInt16(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Sayısal olmayan bir değer girildi.");
                goto getDoorNumber;
            }

            Car producedCar = new Car(productSerialNumber, productBrand, productModel, productColor, productDoorNumber);
            cars.Add(producedCar);

            while (true)
            {
                Console.WriteLine("Başka bir araba oluşturmak ister misiniz?(e/h)");

                try
                {
                    char answer = Convert.ToChar(Console.ReadLine().ToLower());
                    if (answer == 'e')
                    {
                        goto createCar;

                    }
                    else if (answer == 'h')
                    {
                        foreach (Car item in cars)
                        {
                            Console.WriteLine($"Araba  seri numarası: {item.SerialNumber} ve araba markası: {item.Brand}");
                            Console.WriteLine("\nProgram sonlandırıldı");
                        }
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz harf girdiniz.\n");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Geçersiz yanıt verdiniz.\n");
                }
            }
        }
    }
}

