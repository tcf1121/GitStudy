using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("이름을 입력해주세요 : ");
            string input = Console.ReadLine();
            Console.WriteLine("나이를 입력해주세요 : ");
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("입력하신 이름은 {0} 나이는 {1} 입니다.", input, age);
        }
    }
}
