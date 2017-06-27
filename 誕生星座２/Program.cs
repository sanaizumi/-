using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 誕生星座２
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] array1 = new string[13] { "やぎ座", "みずがめ座", "うお座", "おひつじ座", "おうし座", "ふたご座", "かに座", "しし座", "おとめ座", "てんびん座", "さそり座", "いて座", "やぎ座" };
                int[] array2 = new int[13] { 19, 18, 20, 19, 20, 21, 22, 22, 22, 23, 22, 21, 31 };

                Console.Write("あなたの誕生月はいつ？：");
                int array3 = int.Parse(Console.ReadLine());
                string month = array1[array3-1];

                Console.Write("あなたの誕生日はいつ？：");
                int array4 = int.Parse(Console.ReadLine());

                if (array4 > array2[array3 - 1])
                {
                    month = array1[array3 + 2];
                    Console.Write("あなたの星座は、" + month + "です。");
                }
                else
                {
                    Console.Write("あなたの星座は、" + month + "です。");
                }
                Console.Write("終了したい場合は、『end』と入力してください。");

                if(Console.ReadLine() == "end")
                {
                    break;
                }
            }
        }
    }
}
