using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SiliconPowerInc.Models;
using SiliconPowerInc.Services;

namespace SiliconPowerInc.Services
{
    public class BDRegistro
    {
        public BDRegistro()
        {
        }
        public void RegisterUser(BD_GenericDataStorageDM data)
        {
            try
            {
                BDConection BD = new BDConection();
                List<Tuple<string, string>> tupleList = new List<Tuple<string, string>>();
                if (data.Strings != null)
                {
                    foreach (var item in data.Strings)
                    {
                        tupleList.Add(item);
                    }
                }
                BD.BdInsert("RegistrarUsuario", data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool CheckMail(string Mail)
        {
            try
            {
                BDConection BD = new BDConection();
                BD_GenericDataStorageDM data = new BD_GenericDataStorageDM();
                List<Tuple<string, string>> tupleList = new List<Tuple<string, string>>();

                Tuple<string, string> TP = new Tuple<string, string>("@Mail", Mail);
                tupleList.Add(TP);
                data.Strings = tupleList;

                var result = BD.BdGet("ComprobarMail", data);
                int resultado = Int32.Parse(result.Rows[0][0].ToString());

                if (Int32.Parse(result.Rows[0][0].ToString()) != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}