using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genera_CURP.Clases
{
    public class Funciones
    {
        public static string ParseEstados(string edo)
        {
            switch (edo)
            {
                case "Aguascalientes":
                    return "AS";
                    break;
                case "Baja California":
                    return "BC";
                    break;
                case "Baja California Sur":
                    return "BS";
                    break;
                case "Campeche":
                    return "CC";
                    break;
                case "Coahuila":
                    return "CL";
                    break;
                case "Colima":
                    return "CM";
                    break;
                case "Chiapas":
                    return "CS";
                    break;
                case "Chiuahua":
                    return "CH";
                    break;
                case "Distrito Federal":
                    return "DF";
                    break;
                case "Durango":
                    return "DG";
                    break;
                case "Guanajuato":
                    return "GT";
                    break;
                case "Guerrero":
                    return "GR";
                    break;
                case "Hidalgo":
                    return "HG";
                    break;
                case "Jalisco":
                    return "JC";
                    break;
                case "Edo. de México":
                    return "MC";
                    break;
                case "Michoacan":
                    return "MN";
                    break;
                case "Morelos":
                    return "MS";
                    break;
                case "Nayarit":
                    return "NT";
                    break;
                case "Nuevo León":
                    return "NL";
                    break;
                case "Oaxaca":
                    return "OC";
                    break;
                case "Puebla":
                    return "PL";
                    break;
                case "Querétaro":
                    return "QT";
                    break;
                case "Quintana Roo":
                    return "QR";
                    break;
                case "San Luis Potosí":
                    return "SP";
                    break;
                case "Sinaloa":
                    return "SL";
                    break;
                case "Sonora":
                    return "SR";
                    break;
                case "Tabasco":
                    return "TC";
                    break;
                case "Tamaulipas":
                    return "TS";
                    break;
                case "Tlaxcala":
                    return "TL";
                    break;
                case "Veracruz":
                    return "VZ";
                    break;
                case "Yucatán":
                    return "YN";
                    break;
                case "Zacatecas":
                    return "ZA";
                    break;
                default:
                    return "NA";
                    break;

            }
        }
    }
}
