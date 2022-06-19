using System;
using System.Web.Http;
using SiliconPowerInc.Models;
using SiliconPowerInc.Services;

namespace SiliconPowerInc.Controllers
{
    public class ActivityFullController : ApiController
    {
        /*
         * Datos de Entrada:
         *  - ID de la actividad que se quiere visualizar con comentarios, disponibilidad, imagenes y localización
         * 
         * Datos de Salida:
         *  - Objetos Activity_Full a mostrar
         */
        public Activity_Full Get_FullActivity(int activity_id)
        {
            try
            {
                Activity_Full activity_full = new Activity_Full();

                //Realizar peticion a BD para extraer lista de actividades para mostrar

                //Montar objeto activity_full

                return activity_full;
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Excepción Encontrada.", ex);
                return null;
            }

        }
    }
}
