namespace Task_3
{
/*3. Создать систему для учета документов. Создать класс Регистр, который будет иметь методы: 
- сохранения документа в регистре
- предоставление информации о документе
Система может работать с тремя типами документов: 
1) Контракт на поставку товаров
Содержит поля: 
- Номер документа
- Тип товаров
- Количество товаров
- Дата документа
2) Контракт с сотрудником
Содержит поля: 
- Номер документа
- Дата документа
- Дата окончания контракта
- Имя сотрудника
3) Финансовая накладная
Содержит поля: 
- Итоговая сумма за месяц
- Дата документа
- Номер документа
- Код департамента
Класс регистр должен содержать внутри себя массив и при добавлении документа в регистр этот добавляемый документ должен добавляться в массив;
    Массив для класса регистра должен быть размером 10; 
В методе предоставления информации о документе следует выводить на экран информацию о переданном входным параметром документе;*/

    internal class Program
    {
        public interface IDisplayInfo
        {
            public string DisplayDocInfo();
        }
        public class Register
        {
            IDisplayInfo[] register = new IDisplayInfo[10];
            byte flag = 0; 
            public void SetDoc(IDisplayInfo obj)
            {
                if (this.flag < 10) { register[this.flag] = obj; ++this.flag; }
                else { Console.WriteLine("The register is full!"); }
            }
            public IDisplayInfo GetDoc(byte number)
            {
               return this.register[number];
            }
            public string GetDocInfo(IDisplayInfo obj) 
            {
                return obj.DisplayDocInfo();
            }

        }

        public class Contract_goods : IDisplayInfo
        {
            public string doc_num;
            public string goods_type;
            public string goods_quantity;
            public string goods_date;
            public string DisplayDocInfo()
            {
                return ($"Document type: Goods Contract\nDocument date: {goods_date}\nDocument number: {doc_num}\nGoods type: {goods_type}\nGoods quantity: {goods_quantity}\n");
            }
        }

        public class Contracts_employees : IDisplayInfo
        {
            public string doc_num;
            public string doc_date;
            public string end_date;
            public string emplyee_full_name;
            public string DisplayDocInfo()
            {
                return ($"Document type: Employee Contract\nDocument date: {doc_date}\nDocument number: {doc_num}\nEmployee: {emplyee_full_name}\nContract ends on: {end_date}\n");
            }
        }

        public class Financial_invoice : IDisplayInfo
        {
            public string month_total;
            public string doc_num;
            public string doc_date;
            public string department_code;
            public string DisplayDocInfo()
            {
                return ($"Document type: Financial Invoice\nDocument date: {doc_date}\nDocument number: {doc_num}\nDepartment code: {department_code}\n");
            }
        }


        static void Main(string[] args)
        {
            Contract_goods cg = new Contract_goods() { doc_num = "00001", goods_type = "Common", goods_quantity = "100", goods_date = "26.12.2022" };
            Contracts_employees ce = new Contracts_employees() { doc_num = "00002", doc_date = "25.12.2022", end_date = "24.12.2023", emplyee_full_name = "Pavel Dyachuk" };
            Financial_invoice fi = new Financial_invoice() { doc_num = "00003", doc_date = "24.12.2022", department_code = "04", month_total = "9856,33" };
            Register regstr = new Register();
            regstr.SetDoc(cg);
            regstr.SetDoc(ce);
            regstr.SetDoc(fi);
            Console.WriteLine(regstr.GetDocInfo(regstr.GetDoc(0)));
            Console.WriteLine(regstr.GetDocInfo(regstr.GetDoc(1)));
            Console.WriteLine(regstr.GetDocInfo(regstr.GetDoc(2)));

        }
    }
}