using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Component_1_Assignment.Components;

namespace Component_1_Assignment.BasicCommands
{
    internal class Filled : Icommands
    {
        private string status;
        public Filled(string status) 
        {
            this.status = status;

            execute();
        }

        public void execute()
        {
           if (status == "on") 
            {
                GlobalConfiguration.isFillOn = true;
                MessageBox.Show(" Filled Enabled a successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            if (status == "off")
            {
                GlobalConfiguration.isFillOn = false;
                MessageBox.Show(" Filled Disabled a successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
    }
}
