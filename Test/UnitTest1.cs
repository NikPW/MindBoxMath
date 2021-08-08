// Davlatov "NikPW" Farrukh

using System.Numerics;
using MindBoxMath.Services.Figures;
using NUnit.Framework;

namespace Test {
	public class Tests {
		
		[SetUp]
		public void Setup() {}
		[Test]
		public void Polygon_T1() {

			Vector2 a = new Vector2(20, 40);
			Vector2 b = new Vector2(38, 20);
			Vector2 c = new Vector2(10, 10);
			Vector2 d = new Vector2(5, 15);

			Polygon p = new Polygon(a, b, c, d);

			Assert.AreEqual(470, p.Area);
		}
		[Test]
		public void Polygon_T2() {

			Vector2 a = new Vector2(1, 5);
			Vector2 b = new Vector2(97, 10);
			Vector2 c = new Vector2(42, 57);
			Vector2 d = new Vector2(54, 14);
			Vector2 e = new Vector2(32, 75);
			Vector2 f = new Vector2(95, 25);
			Vector2 g = new Vector2(13, 221);
			Vector2 h = new Vector2(114, 100);
			Vector2 i = new Vector2(14, 3);
			Vector2 j = new Vector2(1, 75);

			Polygon p = new Polygon(a, b, c, d, e, f, g, h, i, j);

			Assert.AreEqual(1942, p.Area);
		}
		[Test]
		public void Polygon_T3() {

			Vector2 a = new Vector2(14, 52);
			Vector2 b = new Vector2(87, 31);
			Vector2 c = new Vector2(1, 25);

			Polygon p = new Polygon(a, b, c);

			Assert.AreEqual(1122, p.Area);
		}
		[Test]
		public void Polygon_T4() {

			Vector2 a = new Vector2(14, 12);
			Vector2 b = new Vector2(35, 57);
			Vector2 c = new Vector2(59, 52);
			Vector2 d = new Vector2(14, 27);
			Vector2 e = new Vector2(100, 211);
			Vector2 f = new Vector2(322, 477);
			Vector2 g = new Vector2(865, 92);

			Polygon p = new Polygon(a, b, c, d, e, f, g);

			Assert.AreEqual(197088.5, p.Area);
		}
		[Test]
		public void Triangle_IsRight() {
			
			Triangle t = new Triangle(3, 4, 5);
			
			Assert.AreEqual(true, t.IsRightTriangle);
		}
	}
}