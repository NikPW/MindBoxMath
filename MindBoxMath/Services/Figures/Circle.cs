// Davlatov "NikPW" Farrukh

using System;
using System.Numerics;

namespace MindBoxMath.Services.Figures {
	public class Circle : Figure {
		
		#region Properties
		
		public override double Area => System.Math.Pow(Rad, 2)  * System.Math.PI;
		public override double Perimeter => 2 * Rad * System.Math.PI ;
		public override FigureTypes Type { get; }
		public Vector2 Center { get; }
		public double Rad { get; }

		#endregion
		#region Constructors 

		public Circle(Vector2 center, double rad) {
			Center = center;
			Rad = rad;
			Type = FigureTypes.Circle;
		}
		public Circle(Vector2 center, Vector2 outerPoint) 
			: this(center, SegmentLength(center, outerPoint)) {}

		#endregion
	}
}
