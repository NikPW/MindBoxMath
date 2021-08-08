// Davlatov "NikPW" Farrukh

using System;
using System.Numerics;

namespace MindBoxMath.Services.Figures {
	public class Triangle : Figure {

		#region Fields

		public Vector2[] Tops { get; }
		public double[] Sides { get; }

		#endregion
		#region Properties

		public override double Area {
			get {
				double area = 0;
				
				if (Tops != null && Sides == null) {
					area = 0.5 * System.Math.Abs((Tops[1].X - Tops[0].X) *
					                             (Tops[2].Y - Tops[0].Y) -
					                             (Tops[2].X - Tops[0].X) *
					                             (Tops[1].Y - Tops[0].Y));
				}
				else {
					double p = (Sides[0] + Sides[1] + Sides[2]) / 2;

					area = System.Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
				}

				return area;
			}
		}

		public override double Perimeter {
			get {
				double perimeter = 0;
				
				if (Tops != null && Sides == null) {
					perimeter = SegmentLength(Tops[0], Tops[1]) +
					            SegmentLength(Tops[1], Tops[2]) +
					            SegmentLength(Tops[2], Tops[0]);
				}
				else {
					perimeter = Sides[0] + Sides[1] + Sides[2];
				}

				return perimeter;
			}
		}
		public override FigureTypes Type { get; }

		public bool IsRightTriangle {
			get {
				bool result = false;
				double a = 1;
				double b = 1;
				double c = 1;
				
				if (Tops != null && Sides == null) {
					a = System.Math.Pow(SegmentLength(Tops[0], Tops[1]), 2);
					b = System.Math.Pow(SegmentLength(Tops[1], Tops[2]), 2);
					c = System.Math.Pow(SegmentLength(Tops[2], Tops[3]), 2);
				}
				else {
					a = System.Math.Pow(Sides[0], 2);
					b = System.Math.Pow(Sides[1], 2);
					c = System.Math.Pow(Sides[2], 2);
				}
				
				/*
				if ((a >= b + c - 0.0001 && a <= b + c + 0.0001) ||
				    (b >= a + c - 0.0001 && b <= a + c + 0.0001) ||
				    (c >= b + a - 0.0001 && c <= b + a + 0.0001)) {
					result = true;
				}
				*/

				if (a == b + c || b == a + c || c == a + b) result = true;
				
				return result;
			}
		}

		#endregion
		#region Constructors

		// Constructor for tops
		public Triangle(Vector2 a, Vector2 b, Vector2 c) {
			Tops = new Vector2[] { a, b, c };
			Type = FigureTypes.Rectangle;
		}
		// Constructor for tops
		public Triangle(Vector2[] tops) {
			Tops = tops;
			Type = FigureTypes.Rectangle;
		}
		
		// Constructor for sides without tops
		public Triangle(double a, double b, double c) {
			Sides = new double[] { a, b, c };
			Type = FigureTypes.Rectangle;
		}
		// Constructor for sides without tops
		public Triangle(double[] sides) {
			Sides = sides;
			Type = FigureTypes.Rectangle;
		}

		#endregion
	}
}
