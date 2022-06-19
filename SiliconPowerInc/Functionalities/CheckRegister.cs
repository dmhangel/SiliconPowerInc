using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using SiliconPowerInc.Models;

namespace SiliconPowerInc.Functionalities
{
    public class CheckRegister
    {
        public CheckRegister()
        {
        }
        /*
        * Datos de Entrada:
        *  - Objeto Usuario del registro
        * 
        * Datos de Salida:
        *  - bool que detecta si es valido o no
        */
        public bool Check(User user)
        {
            bool result = true;

            if (user.Mail != null)
            {
                result = Regex.IsMatch(user.Mail, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            }
            else
            {
                result = false;
            }
            
            if(result && user.Pswrd != null)
            {
                result = Regex.IsMatch(user.Pswrd, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");
            }
            else
            {
                result = false;
            }

            if (result && user.Name != null)
                result = Regex.IsMatch(user.Name, @"^[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]+(\s*[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]+$");

            if (result && user.SurName != null)
                result = Regex.IsMatch(user.SurName, @"^[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]+(\s*[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]+$");
            
            if (result && user.Phone != null)
                result = Regex.IsMatch(user.Phone, @"(^[0-9]{9}$)|(^\+[0-9]{2}[0-9]{9}$)");

            if (result && user.Address != null)
                result = Regex.IsMatch(user.Address, @"^[a-zA-Z0-9À-ÿ\u00f1\u00d1\u00e7\u00c7\u00ba\u00aa\s,.\\/]{0,255}$");

            if (result && user.Town != null)
                result = Regex.IsMatch(user.Town, @"^[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]+(\s*[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]+$");

            if (result && user.CP != null)
                result = Regex.IsMatch(user.CP, @"^[0-9]{5}$");

            if (result && user.Country != null)
                result = Regex.IsMatch(user.Country, @"^[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]+(\s*[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]+$");

            return result;
        }
    }
}