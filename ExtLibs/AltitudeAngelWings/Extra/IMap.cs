using System;
using System.Reactive;
using GMap.NET;

namespace AltitudeAngel.IsolatedPlugin.Common.Maps
{
    public interface IMap
    {
        PointLatLng GetCenter();
        RectLatLng GetViewArea();
        void AddOverlay(string name);
        void DeleteOverlay(string name);
        IOverlay GetOverlay(string name, bool createIfNotExists = false);
        IObservable<Unit> MapChanged { get; }
    }
}
