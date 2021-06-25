using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.CompilerServices;
using Microsoft.AspNetCore.Components.Rendering;

namespace EksterneElements.RenderTreeBuilderExtensions
{
    public static class TreeBuilderEkstensions
    {
        public static void BindValue<TValue>(this RenderTreeBuilder builder, object resiver, ref int sequence, TValue value,EventCallback<TValue> eventCallback, string valueName = "Value")
        {
            builder.AddAttribute(sequence++, valueName, RuntimeHelpers.TypeCheck<TValue>(value));
            builder.AddAttribute(sequence++, valueName+"Changed", RuntimeHelpers.TypeCheck<EventCallback<TValue>>(
    EventCallback.Factory.Create<TValue>(resiver, eventCallback)));

        }
    }
}
