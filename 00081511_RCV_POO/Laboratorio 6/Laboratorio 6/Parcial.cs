namespace Laboratorio_6
{
    public class Parcial : IEvaluacion
    {
        private int cantPregunta;

        public Parcial(int cantPregunta, string nombre, int porcentaje )
        {
            this.cantPregunta = cantPregunta;
            Porcentaje = porcentaje;
            Nombre = nombre;
        }

        public int Porcentaje { get; set; }
        public string Nombre { get; set; }
        public void evaluacion(int num, string tet)
        {
            
        }
    }
}