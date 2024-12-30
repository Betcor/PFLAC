using System;
using System.Windows.Forms;

namespace PFLAC
{
    public static class Messages
    {
        /*
        * @public
        *
        * @params {string message}
        */
        public static void Error(string message)
        {
          MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        /*
        * @public
        *
        * @params {string message}
        */
        public static void Info(string message)
        {
          MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        /*
        * @public
        *
        * @params {string message}
        */
        public static void Success(string message)
        {
          MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
