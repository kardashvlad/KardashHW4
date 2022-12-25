using System;
using System.Collections.Generic;
using System.Text;
using Task4.Interfaces;

namespace Task4.Classes
{
    abstract internal class GeoObject : GeoObjectInterface
    {
        double x;
        double y;
        string title = "Default title";
        string description;
        public virtual string GetInfo()
        {
            return title;
        }
    }
}
