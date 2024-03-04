using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.src
{
    /// <summary>
    /// Base interface of shape for area and perimeter
    /// </summary>
    public interface IShape
    {
        public double area();
        public double perimeter();
    }
}
