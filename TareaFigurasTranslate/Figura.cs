using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaFigurasTranslate
{
    internal class Figura
    {
        public PointF[] Vertices { get; private set; }

        public Figura(PointF[] vertices)
        {
            Vertices = vertices;
        }

        public static Figura CrearCuadrado(float lado)
        {
            float m = lado / 2;
            return new Figura(new PointF[]
            {
            new PointF(-m, -m),
            new PointF(m, -m),
            new PointF(m, m),
            new PointF(-m, m)
            });
        }

        public static Figura CrearTriangulo(float lado)
        {
            float h = (float)(Math.Sqrt(3) / 2 * lado);
            return new Figura(new PointF[]
            {
            new PointF(0, -h / 2),
            new PointF(-lado / 2, h / 2),
            new PointF(lado / 2, h / 2)
            });
        }

        public static Figura CrearRombo(float diagMayor, float diagMenor)
        {
            float midMayor = diagMayor / 2;
            float midMenor = diagMenor / 2;
            return new Figura(new PointF[]
            {
                new PointF(-midMenor,0),
                new PointF(0,-midMayor),
                new PointF(midMenor,0),
                new PointF(0,midMayor)
            });
        }
    }
}
