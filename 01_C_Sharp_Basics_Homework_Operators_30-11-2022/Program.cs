namespace _01_C_Sharp_Basics_Homework_Operators_30_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating variables
            bool bool_a, bool_b, bool_rezult; // true, false
            byte byte_a, byte_b, byte_rezult; // 0 to 255
            sbyte sbyte_a, sbyte_b, sbyte_rezult; // -128 to 127
            short short_a, short_b, short_rezult; // -32768 to 32767
            ushort ushort_a, ushort_b, ushort_rezult; // 0 to 65535
            int int_a, int_b, int_rezult; // -2147483648 to 2147483647
            uint uint_a, uint_b, uint_rezult; // 0 to 4294967295
            long long_a, long_b, long_rezult; // -9223372036854775808 to 9223372036854775807
            ulong ulong_a, ulong_b, ulong_rezult; // 0 to 18446744073709551615
            double double_a, double_b, double_rezult; // +-5.0 × 10^(−324) to +-1.7 × 10^308
            float float_a, float_b, float_rezult; // +-1.5*10^(-45) to +- 3.4 * 10^38
            decimal decimal_a, decimal_b, decimal_rezult; //+-1.0 x 10^(-28) to +-7.9228 x 10^28
            char char_a, char_b, char_rezult; // U+0000 to U+FFFF

            //Assigning values
            bool_a = true;
            bool_b = false;
            byte_a = 10;
            byte_b = 20;
            sbyte_a = -10;
            sbyte_b = 30;
            short_a = -20;
            short_b = 40;
            ushort_a = 50;
            ushort_b = 100;
            int_a = 500;
            int_b = 1000;
            uint_a = 1000;
            uint_b = 2000;
            long_a = 10000;
            long_b = 500000;
            ulong_a = 1321;
            ulong_b = 987613;
            double_a = 333.333;
            double_b = 22.22;
            float_a = 54.122111F;
            float_b = -2.11F;
            decimal_a = 23.222222M;
            decimal_b = -2.233422M;
            char_a = 'a';
            char_b = 'b';


            // Operator +

            //Not applicable to bool
            //bool_rezult = bool_a + bool_b;

            //Convertation error
            //byte_rezult = byte_a + byte_b;
            //sbyte_rezult = sbyte_a + sbyte_b;
            //short_rezult = short_a + short_b;
            //ushort_rezult =ushort_a + ushort_b;
            //char_rezult = char_a + char_b;

            int_rezult = int_a + int_b;
            uint_rezult = uint_a + uint_b;
            long_rezult = long_a + long_b;
            ulong_rezult = ulong_a + ulong_b;
            double_rezult = double_a + double_b;
            float_rezult = float_a + float_b;
            decimal_rezult = decimal_a + decimal_b;


            // Operator -

            //Not applicable to bool
            //bool_rezult = bool_a - bool_b;

            //Convertation error
            //byte_rezult = byte_a - byte_b;
            //sbyte_rezult = sbyte_a - sbyte_b;
            //short_rezult = short_a - short_b;
            //ushort_rezult = ushort_a - ushort_b;
            //char_rezult = char_a - char_b;

            int_rezult = int_a - int_b;
            uint_rezult = uint_a - uint_b;
            long_rezult = long_a - long_b;
            ulong_rezult = ulong_a - ulong_b;
            double_rezult = double_a - double_b;
            float_rezult = float_a - float_b;
            decimal_rezult = decimal_a - decimal_b;


            // Operator *

            //Not applicable to bool
            //bool_rezult = bool_a * bool_b;

            //Convertation error
            //byte_rezult = byte_a * byte_b;
            //sbyte_rezult = sbyte_a * sbyte_b;
            //short_rezult = short_a * short_b;
            //ushort_rezult = ushort_a * ushort_b;
            //char_rezult = char_a * char_b;

            int_rezult = int_a * int_b;
            uint_rezult = uint_a * uint_b;
            long_rezult = long_a * long_b;
            ulong_rezult = ulong_a * ulong_b;
            double_rezult = double_a * double_b;
            float_rezult = float_a * float_b;
            decimal_rezult = decimal_a * decimal_b;


            // Operator /

            //Not applicable to bool
            //bool_rezult = bool_a / bool_b;

            //Convertation error
            //byte_rezult = byte_a / byte_b;
            //sbyte_rezult = sbyte_a / sbyte_b;
            //short_rezult = short_a / short_b;
            //ushort_rezult = ushort_a / ushort_b;
            //char_rezult = char_a / char_b;

            int_rezult = int_a / int_b;
            uint_rezult = uint_a / uint_b;
            long_rezult = long_a / long_b;
            ulong_rezult = ulong_a / ulong_b;
            double_rezult = double_a / double_b;
            float_rezult = float_a / float_b;
            decimal_rezult = decimal_a / decimal_b;


            // Operation %

            //Not applicable to bool
            //bool_rezult = bool_a % bool_b;

            //Convertation error
            //byte_rezult = byte_a % byte_b;
            //sbyte_rezult = sbyte_a % sbyte_b;
            //short_rezult = short_a % short_b;
            //ushort_rezult = ushort_a % ushort_b;
            //char_rezult = char_a % char_b;
            int_rezult = int_a % int_b;
            uint_rezult = uint_a % uint_b;
            long_rezult = long_a % long_b;
            ulong_rezult = ulong_a % ulong_b;
            double_rezult = double_a % double_b;
            float_rezult = float_a % float_b;
            decimal_rezult = decimal_a % decimal_b;


            // Increment operation ++

            //Not applicable to bool
            //bool_rezult = ++bool_a;

            byte_rezult = ++byte_a;
            sbyte_rezult = ++sbyte_a;
            short_rezult = ++short_a;
            ushort_rezult = ++ushort_a;
            char_rezult = ++char_a;
            int_rezult = ++int_a;
            uint_rezult = ++uint_a;
            long_rezult = ++long_a;
            ulong_rezult = ++ulong_a;
            double_rezult = ++double_a;
            float_rezult = ++float_a;
            decimal_rezult = ++decimal_a;


            // Decrement operator --

            //Not applicable to bool
            //bool_rezult = --bool_a;

            byte_rezult = --byte_a;
            sbyte_rezult = --sbyte_a;
            short_rezult = --short_a;
            ushort_rezult = --ushort_a;
            char_rezult = --char_a;
            int_rezult = --int_a;
            uint_rezult = --uint_a;
            long_rezult = --long_a;
            ulong_rezult = --ulong_a;
            double_rezult = --double_a;
            float_rezult = --float_a;
            decimal_rezult = --decimal_a;


            // Operator &

            //Not applicable to double, float, decimal
            //double_rezult = double_a & double_b;
            //float_rezult = float_a & float_b;
            //decimal_rezult = decimal_a & decimal_b;

            //Convertation error
            //byte_rezult = byte_a & byte_b;
            //sbyte_rezult = sbyte_a & sbyte_b;
            //short_rezult = short_a & short_b;
            //ushort_rezult = ushort_a & ushort_b;
            //char_rezult = char_a & char_b;
            bool_rezult = bool_a & bool_b;
            int_rezult = int_a & int_b;
            uint_rezult = uint_a & uint_b;
            long_rezult = long_a & long_b;
            ulong_rezult = ulong_a & ulong_b;


            // Operator |

            //Not applicable to double, float, decimal
            //double_rezult = double_a | double_b;
            //float_rezult = float_a | float_b;
            //decimal_rezult = decimal_a | decimal_b;

            //Convertation error
            //byte_rezult = byte_a | byte_b;
            //sbyte_rezult = sbyte_a | sbyte_b;
            //short_rezult = short_a | short_b;
            //ushort_rezult = ushort_a | ushort_b;
            //char_rezult = char_a | char_b;

            bool_rezult = bool_a | bool_b;
            int_rezult = int_a | int_b;
            uint_rezult = uint_a | uint_b;
            long_rezult = long_a | long_b;
            ulong_rezult = ulong_a | ulong_b;


            // Operator ^

            ////Not applicable to double, float, decimal
            //double_rezult = double_a ^ double_b;
            //float_rezult = float_a ^ float_b;
            //decimal_rezult = decimal_a ^ decimal_b;

            //Convertation error
            //byte_rezult = byte_a ^ byte_b;
            //sbyte_rezult = sbyte_a ^ sbyte_b;
            //short_rezult = short_a ^ short_b;
            //ushort_rezult = ushort_a ^ ushort_b;
            //char_rezult = char_a ^ char_b;

            bool_rezult = bool_a ^ bool_b;
            int_rezult = int_a ^ int_b;
            uint_rezult = uint_a ^ uint_b;
            long_rezult = long_a ^ long_b;
            ulong_rezult = ulong_a ^ ulong_b;


            // Operator ~
            bool_rezult = false;
            byte_rezult = 123;
            sbyte_rezult = 51;
            short_rezult = 22;
            ushort_rezult = 88;
            char_rezult = 'a';
            int_rezult = 888;
            uint_rezult = 9999;
            long_rezult = 15689745;
            ulong_rezult = 55555555555;
            double_rezult = 125.3666;
            float_rezult = 1.22225F;
            decimal_rezult = 99999;

            ////Not applicable to double, float, decimal, bool
            //decimal_rezult = ~ decimal_rezult;
            //bool_rezult = ~ bool_rezult;
            //double_rezult = ~double_rezult;
            //float_rezult = ~float_rezult;

            //Convertation error
            //byte_rezult = ~ byte_rezult;
            //sbyte_rezult = ~ sbyte_rezult;
            //short_rezult = ~ short_rezult;
            //ushort_rezult = ~ ushort_rezult;
            //char_rezult = ~ char_rezult;

            int_rezult = ~int_rezult;
            uint_rezult = ~uint_rezult;
            long_rezult = ~long_rezult;
            ulong_rezult = ~ulong_rezult;


            // Сonditional Operators !=, <, >, <=, >=, ==

            //Convertation error
            //byte_rezult = byte_a != byte_b;
            //sbyte_rezult = sbyte_a != sbyte_b;
            //short_rezult = short_a != short_b;
            //ushort_rezult = ushort_a != ushort_b;
            //char_rezult = char_a != char_b;
            //int_rezult = int_a != int_b;
            //uint_rezult = uint_a != uint_b;
            //long_rezult = long_a != long_b;
            //ulong_rezult = ulong_a != ulong_b;
            //double_rezult = double_a != double_b;
            //float_rezult = float_a != float_b;
            //decimal_rezult = decimal_a != decimal_b;

            bool_rezult = bool_a != bool_b;


            // Ternary Operator ?:

            byte_rezult = byte_a == byte_b ? (byte_a) : (byte_b);
            sbyte_rezult = sbyte_a == sbyte_b ? (sbyte_a) : (sbyte_b);
            short_rezult = short_a == short_b ? (short_a) : (short_b);
            ushort_rezult = ushort_a == ushort_b ? (ushort_a) : (ushort_b);
            char_rezult = char_a == char_b ? ('f') : ('q');
            bool_rezult = bool_a != bool_b ? (false) : (true);
            int_rezult = int_a == int_b ? (int_a + int_b) : (int_b);
            uint_rezult = uint_a == uint_b ? (uint_a++) : (uint_b);
            long_rezult = long_a == long_b ? (long_a--) : (long_b);
            ulong_rezult = ulong_a == ulong_b ? (ulong_a--) : (ulong_b);
            double_rezult = double_a != double_b ? (double_a - double_b) : (double_a + double_b);
            float_rezult = float_a != float_b ? (float_a - float_b) : (float_a + float_b);
            decimal_rezult = decimal_a != decimal_b ? (decimal_a) : (decimal_a + decimal_b);



        }
    }
}