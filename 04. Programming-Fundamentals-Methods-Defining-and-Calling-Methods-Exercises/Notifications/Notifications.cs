using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRows = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            while (numRows != 0)
            {

                string result = Console.ReadLine();
                if (result == "success")
                {
                    string operMess = Console.ReadLine();
                    string succMess = Console.ReadLine();
                    sb.Append(ShowSuccess(operMess, succMess));
                }
                else if (result == "error")
                {
                    string operMess = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    sb.Append(ShowError(operMess, code));

                }
                numRows--;
            }

            Console.WriteLine(sb.ToString());
            
        }

        static string ShowSuccess(string operation, string message)
        {
            //Successfully executed {operation}.
            //==============================
            //Message: {message}.
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Successfully executed " + operation + ".");
            sb.AppendLine("==============================");
            sb.AppendLine("Message: " + message + ".");

            return sb.ToString();
        }

        static string ShowError(string operation, int code)
        {
            //Error: Failed to execute {operation}.
            //==============================
            //Error Code: {code}.
            //Reason: {reason}.

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Error: Failed to execute " + operation + ".");
            sb.AppendLine("==============================");
            sb.AppendLine("Error Code: " + code + ".");
            string reason;
            reason = code > 0 ? "Invalid Client Data" : "Internal System Failure";
            sb.AppendLine("Reason: " + reason + ".");

            return sb.ToString();
        }




    }
}
