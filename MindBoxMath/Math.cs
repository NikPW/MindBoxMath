// Davlatov "NikPW" Farrukh

using System;
using System.Numerics;
using MindBoxMath.Services;

namespace MindBoxMath {
	public static class Math {

		public static double Perimeter (Figure f) => f.Perimeter;
		public static double Area (Figure f) => f.Area;
		public static FigureTypes Type(Figure f) => f.Type;

	}
}
