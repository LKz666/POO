﻿namespace TrianguloPOO
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area() 
        { 
            return Largura * Altura; 
        }

        public double Perimetro() 
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal() 
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }

        public override string ToString() 
        { 
            return "Área: " + Area() + " Perímetro: " + Perimetro() + " Diagonal: " + Diagonal();
        }
    }
}
