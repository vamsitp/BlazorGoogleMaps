﻿using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace GoogleMapsComponents.Maps;

/// <summary>
/// 2023-09
/// Notice: Available only in the v=beta channel.
/// </summary>
public class AdvancedMarkerElement : ListableEntityBase<AdvancedMarkerElementOptions>
{
    // https://developers.google.com/maps/documentation/javascript/reference/3.55/advanced-markers
    public const string GoogleMapAdvancedMarkerName = "google.maps.marker.AdvancedMarkerElement";

    public static async Task<AdvancedMarkerElement> CreateAsync(IJSRuntime jsRuntime, AdvancedMarkerElementOptions? opts = null)
    {
        var jsObjectRef = await JsObjectRef.CreateAsync(jsRuntime, GoogleMapAdvancedMarkerName, opts);
        var obj = new AdvancedMarkerElement(jsObjectRef);
        return obj;
    }

    internal AdvancedMarkerElement(JsObjectRef jsObjectRef)
        : base(jsObjectRef)
    {
    }

    public Task<int> GetZIndex()
    {
        return _jsObjectRef.InvokeAsync<int>("getZIndex");
    }
}

[Obsolete("Use AdvancedMarkerElement")]
public class AdvancedMarkerView : ListableEntityBase<AdvancedMarkerViewOptions>
{
    // https://developers.google.com/maps/documentation/javascript/reference/3.55/advanced-markers
    public const string GoogleMapAdvancedMarkerName = "google.maps.marker.AdvancedMarkerElement";

    public static async Task<Marker> CreateAsync(IJSRuntime jsRuntime, AdvancedMarkerViewOptions? opts = null)
    {
        var jsObjectRef = await JsObjectRef.CreateAsync(jsRuntime, GoogleMapAdvancedMarkerName, opts);
        var obj = new Marker(jsObjectRef);
        return obj;
    }

    internal AdvancedMarkerView(JsObjectRef jsObjectRef)
        : base(jsObjectRef)
    {
    }

    public Task<int> GetZIndex()
    {
        return _jsObjectRef.InvokeAsync<int>("getZIndex");
    }
}