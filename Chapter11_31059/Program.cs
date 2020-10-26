using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11_31059
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.Write("あなたの生年月日は：");
            //var line = Console.ReadLine();

            ////DateTime.parse()で入力された文字列をDateTime構造体へ変換
            ////日曜日かどうかチェック
            //if (DateTime.Parse(line).DayOfWeek == DayOfWeek.Sunday)
            //{
            //    Console.WriteLine("日曜日に生まれました。");
            //} else
            //{
            //    Console.WriteLine("日曜日生まれではありません。");
            //}
            #endregion

            #region Q2
            //Q2で定義したPersonクラスの動作を確認するコード
            //var person = new Person("犬山","サラ",Gender.Female);

            //Console.WriteLine(person.FirstName);
            //Console.WriteLine(person.LastName);
            //Console.WriteLine(person.gender);
            #endregion

            #region Q3
            var king = new Card(CardSuit.Spade, 13);
            Console.WriteLine($"Suit:{king.Suit},Number{king.Number}");
            ChangeToAce(out king);
            Console.WriteLine($"Suit:{king.Suit},Number{king.Number}");

            #endregion

        }
        //Q3で使用
        private static void ChangeToAce(out Card card)
        {
            card = new Card(CardSuit.Club, 1);
        }
    }
}
