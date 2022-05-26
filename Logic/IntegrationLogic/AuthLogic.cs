using ITworks.Brom;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.IntegrationLogic
{
    public class AuthLogic
    {
        public БромКлиент Auth(string Login,string Password)
        {
            dynamic client = new БромКлиент($@"
	            Публикация	= http://localhost/test;
	            Пользователь	= {Login};
	            Пароль		= {Password}
            ");
            dynamic инфо = client.ПолучитьИнформациюОСистеме();
            return client;
        }
    }
}
