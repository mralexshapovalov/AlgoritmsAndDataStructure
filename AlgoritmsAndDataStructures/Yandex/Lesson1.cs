using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsYandex
{
    public static class Lesson1
    {
        //Чего хотят на алгоритмическом собеседовании?
        //
        //-Умение писать работающий код
        //-Умение тестировать свой код
        //-Умение писать эффективный код

        //Что такое сложность?

        //-Сложность алгоритма - порядок количества действий,
        //которые выполняет алгоритм

        //Например, в программе два вложенных цикла, каждый от 1 до N,
        //тогда сложность составляет O(N2)
        //100*N = O(N), 2*N = O(N).
        //Здесь 100 и 2 - константы,
        //на зависящие от размера входных данных.Константы не так
        //сильно влияют на скорость работы алгоритма при больших
        //параметрах
        //Еще бывает «пространственная сложность» - количество
        //использованной памяти

        //Задача
        //Дана строка(в кодировке UTF-8)
        //Найти самый часто встречающийся в ней символ.
        //Если несколько символов встречаются одинаково
        //часто, то можно вывести любой.

        public static char SymbolSearch(string s)
        {
            /* Переберем все позиции и для каждой позиции в строке еще раз
               переберем все позиции и в случае совпадения прибавим к счетчику
               единицу.Найдем максимальное значение счетчика Время O(N2) Память O(N) */

            char ans = ' ';
            int anscnt = 0;
            int nowcnt = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        nowcnt++;
                    }
                }
                if (nowcnt > anscnt)
                {
                    ans = s[i];
                    anscnt = nowcnt;
                }
            }
            return ans;

        }
        public static char SymbolSearchImproved(string s)
        {
            /*Переберем все символы, встречающиеся в строке, а затем переберем
              все позиции и в случае совпадения прибавим к счетчику единицу.
               Найдем максимальное значение счетчика Время O(NK) Память O(N+K) = O(N) */


            char ans = ' ';
            int anscnt = 0;
            int nowcnt = 0;
            foreach (char now in s)
            {

                for (int j = 0; j < s.Length; j++)
                {
                    if (now == s[j])
                    {
                        nowcnt++;
                    }
                }
                if (nowcnt > anscnt)
                {
                    ans = now;
                    anscnt = nowcnt;
                }
            }
            return ans;
            /*Заведем словарь, где ключом является символ, а значением -сколько
              раз он встретился.Если символ встретился впервые -создаем
              элемент словаря с ключом, совпадающим с этим символом
              и значением ноль. Прибавляем к элементу словаря с ключом,
              совпадающем с этим символом, единицу*/
        }
        public static char SymbolSearchImprovedDictionary(string s)
        {
            /*Заведем словарь, где ключом является символ, а значением -сколько
              раз он встретился.Если символ встретился впервые -создаем
              элемент словаря с ключом, совпадающим с этим символом
              и значением ноль. Прибавляем к элементу словаря с ключом,
              совпадающем с этим символом, единицу Время O(N) Память O(K)  */

            char ans = ' ';
            int anscnt = 0;
            Dictionary<char, int> symcnt = new Dictionary<char, int>();
            foreach (char now in s)
            {
                if (now != symcnt.Count)
                {
                    symcnt[now] = 0;
                }
                symcnt[now] += 1;

                if (symcnt[now] > anscnt)
                {
                    ans = now;
                    anscnt = symcnt[now];
                }
            }
            return ans;

        }

        public static int SumSequence() //Сумма последовательностей
        {
            string[] seq = Console.ReadLine().Split();
            int seqSum;
            if (seq.Length == 0)
            {
                return 0;
            }
            seqSum = Convert.ToInt32(seq[0]);

            for (int i = 0; i < seq.Length; i++)
            {
                seqSum += Convert.ToInt32(seq[i]);
            }
            return seqSum;

        }
        public static int MaxSequence() //Максимум последовательности
        {
            string[] seq = Console.ReadLine().Split();
            int seqMax;
            if (seq.Length == 0)
            {
                return 0;
            }
            seqMax = Convert.ToInt32(seq[0]);

            for (int i = 0; i < seq.Length; i++)
            {
                if (Convert.ToInt32(seq[i]) > seqMax)
                {
                    seqMax = Convert.ToInt32(seq[i]);
                }
            }
            return seqMax;

        }

        //Что нужно протестировать?
        //-Тесты из условия(если есть)
        //-Общие случаи
        //-Особые случаи
        /*Советы по составлению тестов
        > Если есть примеры - реши их руками и сверь ответ. Если не совпадает,
          то либо правильных ответов может быть несколько, либо ты неправильно
          понял задачу
        > Сначала составь несколько примеров и реши задачу руками, чтобы лучше
          понять условие и чтобы потом было с чем сравнить
          Проверь последовательность из одного элемента и пустую
          последовательность
        > «Краевые эффекты» - проверь, что программа работает корректно в начале
          и конце последовательности, сделай тесты, чтобы ответ находился на первом
          и на последнем месте в последовательности
         > Составь покрытие всех ветвлений, так чтобы был тест, который входит
          в каждый if и else
         > Подбери тесты чтобы не было ни одного входа в цикл
         > Один тест - одна возможная ошибка*/

        public static void QuadraticEquation(int a,int b,int c)
        {
            
            double d = Math.Pow(b, 2) - 4 * a * c;
            double x1, x2;
            if (d == 0)
            {
                x1 = -b/ (2 * a);
                Console.WriteLine(x1);
            }
            else if(d > 0)
            {
                x1 = (-b - Math.Sqrt(d)) / (2 * a);
                x2 = (-b + Math.Sqrt(d)) / (2 * a);

                Console.WriteLine(x1 + " " + x2);
            }

            
        }
    }
}
