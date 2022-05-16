using Eclipse.Core;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace Eclipse.Web.Components.Ships
{
    public class ShipRenderer : ComponentBase
    {
        [Parameter]
        public Core.Ship Ship { get; set; }

        [Parameter]
        public EventCallback<Ship> OnShipClicked { get; set; }

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
            builder.AddAttribute(index++, "Color", GetColor());
            builder.AddAttribute(index++, "Ship", Ship);
            builder.AddAttribute(index++, "OnShipClicked", OnShipClicked);
            builder.CloseComponent();
        }

        public string GetColor()
        {
            if (Ship.Color == SpecieColor.Yellow) return "bg-yellow-200 border-yellow-500";
            if (Ship.Color == SpecieColor.Green) return "bg-green-500 border-green-700 text-green-700";
            if (Ship.Color == SpecieColor.Blue) return "bg-blue-200 border-blue-500";
            if (Ship.Color == SpecieColor.Black) return "bg-gray-600 border-gray-900 text-gray-200";
            if (Ship.Color == SpecieColor.Red) return "bg-red-300 border-red-500";
            if (Ship.Color == SpecieColor.White) return "bg-gray-50 border-gray-200";
            if (Ship.Color == SpecieColor.Gray) return "bg-gray-300 border-gray-500";
            return "bg-blue-100";
        }
    }
}
