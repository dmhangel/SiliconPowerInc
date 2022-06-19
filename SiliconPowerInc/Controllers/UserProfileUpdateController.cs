using System;
using System.Web.Http;
using SiliconPowerInc.Models;
using SiliconPowerInc.Services;

namespace SiliconPowerInc.Controllers
{
    public class UserProfileUpdateController : ApiController
    {
        /*
         * Datos de Entrada:
         *  - Objeto User con los campos a actualizar
         *  - el campo de email no se debe actualizar, si no es null se ignorará.
         * 
         * Datos de Salida:
         *  - boleano que indica si se ha creado correctamente el usuario en BD
         */
        public bool Post_UserUpdate(User user)
        {
            try
            {
                //Verificar campos

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