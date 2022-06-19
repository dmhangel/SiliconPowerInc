using System;
using System.Collections.Generic;
using System.Web.Http;
using SiliconPowerInc.Models;
using SiliconPowerInc.Services;
using SiliconPowerInc.Functionalities;

namespace SiliconPowerInc.Controllers
{
    public class RegisterController : ApiController
    {
        private BDRegistro BdRegistro = new BDRegistro();
        private CheckRegister CheckReg = new CheckRegister();

        /*
         * Datos de Entrada:
         *  - String con el mail que se intenta registrar
         * 
         * Datos de Salida:
         *  - boleano que indica si el mail existe en base de datos o no
         */
        public bool Get_MailVerification(string mail)
        {
            try
            {
                return BdRegistro.CheckMail(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Excepción Encontrada.", ex);
                return true;
            }
        }

        /*
         * Datos de Entrada:
         *  - Objeto User del formulario de registro
         * 
         * Datos de Salida:
         *  - boleano que indica si se ha creado correctamente el usuario en BD
         */
        public bool Post_Register(User user)
        {
            try
            {
                if (CheckReg.Check(user))
                {
                    BD_GenericDataStorageDM data = new BD_GenericDataStorageDM();
                    List<Tuple<string, string>> tupleList = new List<Tuple<string, string>>();

                    Tuple<string, string> TP = new Tuple<string, string>("@Mail", user.Mail);
                    tupleList.Add(TP);
                    TP = new Tuple<string, string>("@Pswrd", user.Pswrd);
                    tupleList.Add(TP);
                    TP = new Tuple<string, string>("@Name", user.Name);
                    tupleList.Add(TP);
                    TP = new Tuple<string, string>("@SurName", user.SurName);
                    tupleList.Add(TP);
                    TP = new Tuple<string, string>("@Phone", user.Phone);
                    tupleList.Add(TP);
                    TP = new Tuple<string, string>("@Address", user.Address);
                    tupleList.Add(TP);
                    TP = new Tuple<string, string>("@Town", user.Town);
                    tupleList.Add(TP);
                    TP = new Tuple<string, string>("@CP", user.CP);
                    tupleList.Add(TP);
                    TP = new Tuple<string, string>("@Country", user.Country);
                    tupleList.Add(TP);

                    data.Strings = tupleList;

                    BdRegistro.RegisterUser(data);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("{0} Excepción Encontrada.", ex);
                return false;
            }
        }
    }
}
