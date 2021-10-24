using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:

            метод void setStart(int x) - устанавливает начальное значение
            метод int getNext() - возвращает следующее число ряда
            метод void reset() - выполняет сброс к начальному значению

            Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries.
            В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.*/

            int firstMember, nextMember, step;
            ArithProgression arithProgression = new ArithProgression();
            arithProgression.setStart(out firstMember, out step);
            nextMember = firstMember;
            arithProgression.getNext(ref nextMember, step);
            arithProgression.getNext(ref nextMember, step);
            arithProgression.getNext(ref nextMember, step);
            arithProgression.getNext(ref nextMember, step);
            arithProgression.reset(firstMember, out nextMember);
            arithProgression.getNext(ref nextMember, step);
            arithProgression.getNext(ref nextMember, step);
            GeomProgression geom = new GeomProgression();
            geom.setStart(out firstMember, out step);
            nextMember = firstMember;
            geom.getNext(ref nextMember, step);
            geom.getNext(ref nextMember, step);
            geom.getNext(ref nextMember, step);
            geom.getNext(ref nextMember, step);
            geom.reset(firstMember, out nextMember);
            geom.getNext(ref nextMember, step);
            geom.getNext(ref nextMember, step);
            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart(out int firstMember, out int step);
        int getNext(ref int nextMember, int step);
        int reset(int firstMember, out int nextMember);
    }
    public class ArithProgression : ISeries
    {
        public void setStart(out int firstMember, out int step)
        {
            Console.WriteLine("Установите начальное значение прогрессии");
            firstMember = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг прогрессии");
            step = Convert.ToInt32(Console.ReadLine());
        }

        public int getNext(ref int nextMember, int step)
        {
            nextMember = nextMember + step;
            Console.WriteLine("Следующее число ряда равно {0}", nextMember);
            return nextMember;
        }

        public int reset(int firstMember, out int nextMember)
        {
            nextMember = firstMember;
            return nextMember;
        }

    }
    public class GeomProgression : ISeries
    {
                public void setStart(out int firstMember, out int step)
        {
            Console.WriteLine("Установите начальное значение прогрессии");
            firstMember = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг прогрессии");
            step = Convert.ToInt32(Console.ReadLine());
        }

        public int getNext(ref int nextMember, int step)
        {
            nextMember = nextMember * step;
            Console.WriteLine("Следующее число ряда равно {0}", nextMember);
            return nextMember;
        }

        public int reset(int firstMember, out int nextMember)
        {
            nextMember = firstMember;
            return nextMember;
        }

    }
}
