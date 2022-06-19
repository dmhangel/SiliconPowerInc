using System;
using System.Web.Http;
using SiliconPowerInc.Models;
using SiliconPowerInc.Services;

namespace SiliconPowerInc.Controllers
{
    public class UserCommentsController : ApiController
    {
        /*
         * Datos de Entrada:
         *  - Id del usuario
         * 
         * Datos de Salida:
         *  - Array de objetos Comment a mostrar que satisfacen las categorias requeridas
         */
        public Comment[] Get_CommentsList(int user_id)
        {
            try
            {
                int long_list = 0; //Numero de registros retornados

                //Realizar peticion a BD para extraer lista de comentarios del usuario para mostrar

                Comment[] comments_list = new Comment[long_list];

                //Montar objeto comments_list

                return comments_list;
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Excepción Encontrada.", ex);
                return null;
            }
        }

        /*
         * Datos de Entrada:
         *  - Objeto Comment del usuario
         * 
         * Datos de Salida:
         *  - boleano que idica si se ha insertado correctamente el comentario en BD
         */
        public bool Post_Comment(Comment user_comment)
        {
            try
            {
                //Realizar peticion a BD para insertar comentario de usuario

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