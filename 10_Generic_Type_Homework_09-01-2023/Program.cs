using static _10_Generic_Type_Homework_09._01._2022.Program;

namespace _10_Generic_Type_Homework_09._01._2022
{
    /*Запрограммируйте универсальный класс Pair<S, T>, который объединяет два
значения типов S и T соответственно.Достаточно запрограммировать
неизменяемые пары. Не забудьте оснастить класс соответствующим
конструктором и соответствующими свойствами получения.

Запрограммируйте класс ComparablePair<T, U>, реализующий интерфейс
IComparable<ComparablePair<T, U>>.При желании вы можете создать класс
ComparablePair<T, U> поверх класса Pair<S, T> из предыдущего упражнения.

Универсальный класс ComparablePair<T, U> должен представлять пару (t, u)
значений/объектов, где t имеет тип T, а u — тип U. Универсальный класс
должен иметь соответствующий конструктор, который инициализирует обе
части пары.Кроме того, должны быть свойства, возвращающие каждую из
частей. Наконец, класс должен, конечно же, реализовать операцию
CompareTo, потому что она предписана интерфейсом
System.IComparable<ComparablePair<T, U>>.

Даны две пары p = (a, b) и q = (c, d).p считается меньшим, чем q, если a меньше
c. Если a равно c, то b и d управляют порядком. Это похоже на
лексикографическое упорядочение строк.*/
 //!!! IComparable<ComparablePair<T, U>> это встроенный интерфейс, его не нужно писать отдельно.
    internal class Program
    {
        public class Pair<S, T>
        {
            S s;
            T t;
            public Pair(S s, T t)
            {
                this.s = s;
                this.t = t;
            }

            public string PairGlue()
            {
                return s.ToString() + t.ToString();
            }

        }

        public class ComparablePair<T, U> : IComparable<ComparablePair<T, U>>
        {
            private T PairPart1 { get; set; }
            private U PairPart2 { get; set; }

            public ComparablePair(T property1, U property2)
            {
                PairPart1 = property1;
                PairPart2 = property2;
            }

            public int CompareTo(ComparablePair<T, U>? other)
            {
                if (PairPart1.ToString() == other.PairPart1.ToString())
                {
                    return string.Compare(PairPart2.ToString(), other.PairPart2.ToString());
                }
                else
                {
                    return string.Compare(PairPart1.ToString(), other.PairPart1.ToString());
                } 
            }
            public override string ToString()
            {
                return $"({PairPart1.ToString()}, {PairPart2.ToString()})";
            }

            public void GetCompareResult(ComparablePair<T, U> comp_pair, Action<string> output)
            {
                int i = CompareTo(comp_pair);
                if (i == 0) 
                { 
                    output($"{this.ToString()} == {comp_pair.ToString()}"); 
                }
                else if (i > 0) 
                { 
                    output($"{this.ToString()} > {comp_pair.ToString()}"); 
                }
                else 
                { 
                    output($"{this.ToString()} < {comp_pair.ToString()}"); 
                }

            }
        }


        static void Main(string[] args)
        {
            Pair<string, double> pair = new Pair<string, double>("Test", 1234);
            Console.WriteLine(pair.PairGlue());

            ComparablePair<int, int> pair1 = new ComparablePair<int, int>(200300, 20);
            ComparablePair<int, int> pair2 = new ComparablePair<int, int>(2, 1);
            ComparablePair<int, int> pair3 = new ComparablePair<int, int>(500600, 10);
            ComparablePair<int, int> pair4 = new ComparablePair<int, int>(200300, 10);
            ComparablePair<int, int> pair5 = new ComparablePair<int, int>(200300, 3050);
            ComparablePair<int, int> pair6 = new ComparablePair<int, int>(200300, 20);

            pair1.GetCompareResult(pair2, x => Console.WriteLine(x));
            pair1.GetCompareResult(pair3, x => Console.WriteLine(x));
            pair1.GetCompareResult(pair4, x => Console.WriteLine(x));
            pair1.GetCompareResult(pair5, x => Console.WriteLine(x));
            pair1.GetCompareResult(pair6, x => Console.WriteLine(x));
        }
    }
}