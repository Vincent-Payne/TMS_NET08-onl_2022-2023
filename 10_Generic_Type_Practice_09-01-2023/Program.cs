namespace _10_Generic_Type_Practise_09_01_2022
{
    internal class Program
    {
        public static void Swap<T>(ref T object1, ref T object2) where T : struct
        {
            T temp_object = object1;
            object1 = object2;
            object2 = temp_object;
        }
        static void Main(string[] args)
        {
            int object_1 = 100500;
            int object_2 = 200300;

            Console.WriteLine($"Переменные до смены мест object_1 {object_1} | object_2 {object_2}");

            Swap(ref object_1, ref object_2);

            Console.WriteLine($"Переменные помле смены мест: object_1 {object_1} | object_2 {object_2}");

        }
    }
}