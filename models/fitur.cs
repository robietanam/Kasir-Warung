using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PBO_Kasir.models
{ 
    public class fitur
    {
        public void countdownTimer(Label labelnya)
        {
            var t = new Timer();
            t.Interval = 3000; // it will Tick in 3 seconds
            t.Tick += (obj, args) =>
            {
                labelnya.Visible = false;
                t.Stop();
            };
            t.Start();
            labelnya.Visible = true;
        
        }


    }

    
    
   

}
