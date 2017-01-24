using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Deployment.WindowsInstaller;
using System.Windows.Forms;

namespace CustomActionNew
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult CustomAction1(Session session)
        {
            session.Log("Begin CustomAction1");
            MessageBox.Show("Hey!");

            return ActionResult.Success;
        }
    }
}
