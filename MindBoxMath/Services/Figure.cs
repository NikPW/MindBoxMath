// Davlatov "NikPW" Farrukh

using System;
using System.Numerics;

namespace MindBoxMath.Services {
	public abstract class Figure {
		
		public abstract double Area { get; }
		public abstract double Perimeter { get; }
		public abstract FigureTypes Type { get; }
		
		public static double SegmentLength(Vector2 a, Vector2 b) {
            return System.Math.Abs(System.Math.Sqrt(System.Math.Pow((b.X - a.X), 2) + System.Math.Pow((b.Y - a.Y), 2)));
        }
	}
}
