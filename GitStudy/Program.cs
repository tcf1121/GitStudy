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
            Console.Write("이름을 입력해주세요 : ");
            string input = Console.ReadLine();

            Console.WriteLine("입력하신 이름은 {0} 입니다.", input);
        }
    }
}
