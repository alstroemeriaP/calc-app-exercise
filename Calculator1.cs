using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;

namespace CalculatorApp {  
    
    class Program {  
        static void Main(string[] args) { 
            
            Console.WriteLine("= Menu =\n");  
            Console.WriteLine("Input 1 untuk Pertambahan");  
            Console.WriteLine("Input 2 untuk Pengurangan");  
            Console.WriteLine("Input 3 untuk Perkalian");  
            Console.WriteLine("Input 4 untuk Pembagian \n\n");  
            int action = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Masukkan angka 1");  
            int input_1 = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Masukkan angka 2");  
            int input_2 = Convert.ToInt32(Console.ReadLine());  
            int result = 0;  
            
            switch (action) {  
                
                case 1: {
                    result = Addition(input_1, input_2);  
                    break;  
                }  
                case 2: {  
                    result = Subtraction(input_1, input_2);  
                    break;  
                }  
                case 3: {  
                    result = Multiplication(input_1, input_2);  
                    break;  
                }  
                case 4: {  
                    result = Division(input_1, input_2);  
                    break;  
                }  
                default:  
                    Console.WriteLine("Pilihan tidak ada, coba lagi");  
                    break;  
            }  
            Console.WriteLine("Hasilnya adalah {0}", result);  
            Console.ReadKey();  
        }  
        //Addition  
        public static int Addition(int input_1, int input_2) {  
            int result = input_1 + input_2;  
            return result;  
        }  
        //Substraction  
        public static int Subtraction(int input_1, int input_2) {  
            int result = input_1 + input_2;  
            return result;  
        }  
        //Multiplication  
        public static int Multiplication(int input_1, int input_2) {  
            int result = input_1 + input_2;  
            return result;  
        }  
        //Division  
        public static int Division(int input_1, int input_2) {  
            int result = input_1 + input_2;  
            return result;  
        }  
    }  
}