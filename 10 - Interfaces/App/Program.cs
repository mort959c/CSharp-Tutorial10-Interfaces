using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle buick = new Vehicle("Buick", 4, 160);

            if(buick is IDriveable)
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine("The {0} can't be driven", buick.Brand);
            }


            #region TV
            IElectronicDevice TV = TVRemote.GetDevice();

            PowerButton powerButton = new PowerButton(TV);

            powerButton.Execute();
            powerButton.Undo();
            #endregion

            Console.ReadLine();
        }
    }
}
