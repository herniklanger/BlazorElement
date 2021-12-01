using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksterneElements.DragAndDrop
{
    public class DragAndDropService
    {
        public object Data { get; set; }
        public string Zone { get; set; }
        public void StartDrag(object data, string zone)
        {
            Data = data;
            Zone = zone;
        }
        public bool Accepts(string zone)
        {
            return Zone == zone;
        }
    }
}
