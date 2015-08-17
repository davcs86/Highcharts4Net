using System.Drawing;

namespace Highcharts4Net.Library.Helpers
{
    public class BackColorOrGradient
    {
        public BackColorOrGradient(string color) { Color = color; }

        public BackColorOrGradient(Gradient gradient) { Gradient = gradient; }

        public string Color { get; private set; }

        public Gradient Gradient { get; private set; }
    }

    public class Gradient
    {
        public int[] LinearGradient { get; set; }
        public RadialGradient RadialGradient { get; set; }
        public object[,] Stops { get; set; }
    }

    public class RadialGradient
    {
        public Number Cx { get; set; }
        public Number Cy { get; set; }
        public Number R { get; set; }
    }
}