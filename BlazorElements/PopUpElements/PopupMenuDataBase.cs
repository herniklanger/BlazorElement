using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksternealElements.PopUpElements
{
    public class PopupMenuDataBase
    {
        public virtual bool DisableMainClass { get; set; } = false;
        public virtual string Class { get; set; }
        public virtual Action<RenderTreeBuilder> RenderFreagment { get; set; }
        public virtual Action RefreshSender { get; set; }
        public Action Refres { get; internal set; }
    }
}
