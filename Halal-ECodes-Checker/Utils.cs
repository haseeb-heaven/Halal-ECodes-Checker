using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halal_ECodes_Checker
{
    class Utils
    {
        //Private method for showing error.
        internal static void ShowError(string err_msg, string arg = "")
        {
            var db = new DialogBox();
            db.Title.Text = "ERROR";
            db.message.Text = err_msg;
            db.ShowDialog();
        }

        //Private method for showing warning.
        internal static void ShowWarning(string warning_msg, string arg = "")
        {
            DialogBox db = new DialogBox();
            db.Title.Text = "WARNING";
            db.message.Text = warning_msg;
            db.ShowDialog();
        }


        //Private method for showing information.
        internal static void ShowInfo(string info_msg, string arg = "")
        {
            var db = new DialogBox();
            db.Title.Text = "INFORMATION";
            db.message.Text = info_msg;
            db.ShowDialog();
        }
    }
}
