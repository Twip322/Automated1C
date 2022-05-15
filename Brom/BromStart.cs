using ITworks.Brom;
using System;

namespace Brom
{
    public class BromStart
    {
        dynamic клиент = new БромКлиент(@"
	Публикация	= http://domainname.ru/publication_name;
	Пользователь	= username;
	Пароль		= userpassword
    ");
        public void E()
        {
            клиент.ЗагрузитьМетаданные("*");
            dynamic инфо = клиент.ПолучитьИнформациюОСистеме();
            Console.WriteLine("Конфигурация: {0}", инфо.Синоним);
            Console.WriteLine("Версия конфигурации: {0}", инфо.Версия);
            Console.WriteLine("Версия Бром: {0}", инфо.РасширениеБром.Версия);
        }
    }

}
