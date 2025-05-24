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

        public static Figura CrearRomboide(float baseLength, float height)
        {
            float midBase = baseLength / 2;
            float midAltura = height / 2;
            float offset = 2;

            return new Figura(new PointF[]
            {
                new PointF(-midBase + offset, -midAltura),
                new PointF(midBase + offset, -midAltura),
                new PointF(midBase - offset, midAltura),
                new PointF(-midBase - offset, midAltura)
            });
        }

        public static Figura CrearTrapecioIsoceles(float baseMayor, float baseMenor, float altura)
        {
            float midBaseMayor = baseMayor / 2;
            float midBaseMenor = baseMenor / 2;
            float midAltura = altura / 2;

            return new Figura(new PointF[]
            {
                new PointF(-midBaseMayor, midAltura),
                new PointF(-midBaseMenor, -midAltura),
                new PointF(midBaseMenor, -midAltura),
                new PointF(midBaseMayor, midAltura)
            });
        }

        public static Figura CrearPentagono(float radio, int numLados)
        {
            PointF[] vertices = new PointF[numLados];

            for (int i = 0; i < numLados; i++)
            {
                float angulo = (float)(-Math.PI / 2 + i * 2 * Math.PI / numLados); // empieza apuntando hacia arriba
                float x = radio * (float)Math.Cos(angulo);
                float y = radio * (float)Math.Sin(angulo);
                vertices[i] = new PointF(x, y);
            }

            return new Figura(vertices);
        }
    }
}
