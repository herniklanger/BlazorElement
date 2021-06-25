using EksterneElements.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EksterneElements.Information.Images
{
    public partial class RolingImages: IDisposable
    {
        bool animaton = true;
        [Inject]
        NavigationManager navigationManager { get; set; }
        int index = 0;
        Timer timer;
        [Parameter]
        public RenderFragment<ImageContainer> TopLeft { get; set; }
        [Parameter]
        public RenderFragment<ImageContainer> TopRight { get; set; }
        [Parameter]
        public RenderFragment<ImageContainer> BottomLeft { get; set; }
        [Parameter]
        public RenderFragment<ImageContainer> BottomRight { get; set; }
        [Parameter]
        public RenderFragment<ImageContainer> Center { get; set; }
        [Parameter]
        public List<ImageContainer> Images { get; set; }
        [Parameter]
        public string Height { get; set; } = "50vh";
        [Parameter]
        public string Width { get; set; } = "100%";

        public void Dispose()
        {
            timer.Dispose();
        }

        protected override void OnInitialized()
        {
            index = Images.Count()-1;
            timer = new Timer(x => { index = (index+1)% Images.Count; StateHasChanged(); animaton = true; }, null, new TimeSpan(0, 0, 30), new TimeSpan(0, 0, 30));
            base.OnInitialized();
        }
        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
        }

    }
}
