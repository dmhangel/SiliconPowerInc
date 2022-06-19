using System;
using System.Web.Http;
using SiliconPowerInc.Models;
using SiliconPowerInc.Services;

namespace SiliconPowerInc.Controllers
{
    public class ActivityListController : ApiController
    {
        /*
         * Datos de Entrada:
         *  - Longitud y latitud para ordenar lista en funcion de la distancia
         *  - Lista de ID de las categorias de actividades por las que se filtran
         * 
         * Datos de Salida:
         *  - Array de objetos Activity a mostrar que satisfacen las categorias requeridas
         */
        public Activity[] Get_ActivityList(decimal longitude, decimal latitude, int[] class_list_id)
        {
            try
            {
                int long_list = 0; //Numero de registros retornados

                //Realizar peticion a BD para extraer lista de actividades para mostrar

                Activity[] activity_list = new Activity[long_list];

                //Montar objeto activity_list

                return activity_list;
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Excepción Encontrada.", ex);
                return null;
            }
        }
    }
}