using SkiaSharp;
using SkiaSharp.Views.Maui;
using SkiaSharp.Views.Maui.Controls;

namespace SkiaSharpScaling
{
    internal class CustomView : SKCanvasView
    {
        protected override void OnPaintSurface(SKPaintSurfaceEventArgs e)
        {
            base.OnPaintSurface(e);
            var canvas = e.Surface.Canvas;
            var info = e.Info;

            using var paint = new SKPaint();
            paint.Color = SKColors.Black;
            paint.StrokeWidth = 10;
            paint.StrokeCap = SKStrokeCap.Square;

            canvas.DrawLine(0, 0, info.Width, info.Height, paint);
            canvas.DrawLine(info.Width, 0, 0, info.Height, paint);
        }
    }
}
