using System;
using System.Web.Http;
using SiliconPowerInc.Models;
using SiliconPowerInc.Services;

namespace SiliconPowerInc.Controllers
{
    public class UserBookingController : ApiController
    {
        /*
        * Datos de Entrada:
        *  - Id del usuario
        * 
        * Datos de Salida:
        *  - Array de objetos Booking realizadas por el usuario
        */
        public Booking[] Get_BookingList(int user_id)
        {
            try
            {
                int long_list = 0; //Numero de registros retornados

                //Realizar peticion a BD para extraer lista de comentarios del usuario para mostrar

                Booking[] booking_list = new Booking[long_list];

                //Montar objeto booking_list

                return booking_list;
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Excepción Encontrada.", ex);
                return null;
            }
        }

        /*
         * Datos de Entrada:
         *  - Objeto Booking del usuario
         * 
         * Datos de Salida:
         *  - boleano que idica si se ha insertado correctamente la reserva en BD
         */
        public bool Post_Booking(Comment user_comment)
        {
            try
            {
                //Realizar peticion a BD para insertar reserva de usuario

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