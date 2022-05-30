using ITworks.Brom;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Logic.IntegrationLogic
{
    public static class Authorization1CController
    {
        public static dynamic Auth(string Login,string Password)
        {
            БромКлиент client = new БромКлиент($@"
	            Публикация	= http://192.168.1.50:8080/test;
	            Пользователь	= {Login};
	            Пароль		= {Password}
            ");
            return client;
        }
    }
}
