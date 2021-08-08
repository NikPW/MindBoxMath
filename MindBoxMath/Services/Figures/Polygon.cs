// Davlatov "NikPW" Farrukh

using System.Numerics;
using System.Linq;

namespace MindBoxMath.Services.Figures {
	public class Polygon : Figure {

		#region Properties

		public override double Area {
			get {
				double a = 0;
				double c = 0;

				for (int i = 0; i < Tops.Length - 1; ++i) {
					a += Tops[i].X * Tops[i + 1].Y;
					c += Tops[i + 1].X * Tops[i].Y;
				}
				double b = Tops[Tops.Length - 1].X * Tops[0].Y;
				double d = Tops[0].X * Tops[Tops.Length - 1].Y;

				return 0.5 * System.Math.Abs(a + b - c - d);
			}
		}

		public override double Perimeter {
			get {
				double result = 0;
				for (int i = 0; i < Tops.Length - 1; i += 2) {
					result += SegmentLength(Tops[i], Tops[i + 1]);
				}

				return result;
			}
		}
		public override FigureTypes Type { get; }
		public Vector2[] Tops { get; }

		#endregion
		#region Constructors

		public Polygon(params Vector2[] tops) {
			Tops = tops;
			Type = FigureTypes.Polygon;
		}

		#endregion
	}
}
