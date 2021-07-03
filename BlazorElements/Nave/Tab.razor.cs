using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EksterneElements.Nave
{
    public partial class Tab
    {
        [Parameter]
        public string Name { get; set; }
        [Parameter]
        public TabControler perrent { get; set; }
        [Parameter]
        public RenderFragment ChildContent { get; set; }
        [Parameter]
        public bool Default { get; set; } = false;
        private bool aktive
        {
            get
            {
                if (perrent?.TabVisulize == null)
                {
                    return false;
                }
                return perrent.TabVisulize == ChildContent;
            }
        }
        protected override void OnInitialized()
        {
            if(perrent.TabVisulize == null && Default)
            {
                perrent.TabVisulize = ChildContent;
            }
        }
    }
}
