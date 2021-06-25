using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EksterneElements.PopUpElements
{
    public partial class PupupMenu
    {
        [Parameter]
        public string Class { get; set; } 
        [Inject]
        PopupMenuDataBase Data { get; set; }
        RenderFragment Fragment { get; set; }

        protected override void OnInitialized()
        {
            Fragment = CreatCompunent();
            Data.Refres = StateHasChanged;
        }
        private RenderFragment CreatCompunent() => builder => Data.RenderFreagment(builder);
    }
}
