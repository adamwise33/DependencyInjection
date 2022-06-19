using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DependencyInjection
{
    public class Service : IService
    {
        
        /// <summary>
        ///  The method used to do the service.
        /// </summary>
void IService.MethodToBeUsed()
        {
            MessageBox.Show("Methotd to be used in the service class that does stuff.");
        }
    }
}
