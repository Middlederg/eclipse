using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace Eclipse.Web.Components.Ships
{
    public class ShipRenderer : ComponentBase
    {
        [Parameter]
        public Core.Ship Ship { get; set; }

        [Parameter]
        public string Color { get; set; }

        private static int index = 0;

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            if (Ship is Core.Interceptor)
            {
                Render<Interceptor>(builder);
                return;
            }

            if (Ship is Core.Cruiser)
            {
                Render<Cruiser>(builder);
                return;
            }

            if (Ship is Core.Dreadnought)
            {
                Render<Dreadnought>(builder);
                return;
            }

        }

        private void Render<T>(RenderTreeBuilder builder) where T : IComponent
        {
            builder.OpenComponent<T>(index++);
            builder.AddAttribute(index++, "Color", Color);
            builder.CloseComponent();
        }
    }
}
