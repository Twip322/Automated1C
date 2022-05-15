using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITworks.Brom;

namespace Logic.IntegrationLogic
{
    public class AuthLogic
    {
        public dynamic AuthInto1C(string Login, string Password)
        {
            dynamic клиент = new БромКлиент($@"
	        Публикация	= http://domainname.ru/publication_name;
	        Пользователь	= {Login};
	        Пароль		= {Password}");
            return клиент;
        }
    }
}
