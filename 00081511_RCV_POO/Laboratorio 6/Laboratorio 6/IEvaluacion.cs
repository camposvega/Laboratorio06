using System;

namespace Laboratorio_6
{
    public interface IEvaluacion
    { 
        int Porcentaje { get; set; }
        String Nombre { get; set; }

        void evaluacion(int num, String tet);

    }
}