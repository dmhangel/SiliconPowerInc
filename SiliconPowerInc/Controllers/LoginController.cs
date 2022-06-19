using System;
using System.Web.Http;
using SiliconPowerInc.Services;

namespace SiliconPowerInc.Controllers
{
    public class LoginController : ApiController
    {
        /*
         * Datos de Entrada:
         *  - Usuario y contraseña
         * 
         * Datos de Salida:
         *  - boleano que indica si es correcto el login o no
         */
        public bool Do_login(string user, string pasword)
        {
            try
            {
                //Realiza petición a BD para comprobar usuario

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Excepción Encontrada.", ex);
                return false;
            }
        }
    }
}