using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseVeicolo
{
    internal class Veicolo
    {
        public string Targa { get; }
        public string Marca { get; }
        public string Modello { get; }

        public int Velocita { get; private set; }
        public int VelocitaMAX { get; }
        public Veicolo(string pTarga, string pMarca, string pModello, int pvMax)
        {
            Targa = pTarga;
            Marca = pMarca;
            Modello = pModello;
            Velocita = 0;
            VelocitaMAX = pvMax;
        }

        public void Accelera(int pVelocita)
        {
            Velocita += pVelocita;
            if (Velocita > VelocitaMAX)
                Velocita = VelocitaMAX;
        }
        public void Frena(int pVelocita)
        {
            Velocita -= pVelocita;
            if (Velocita < 0)
                Velocita = 0;
        }

        public string GetInfo()
        {
            return $"{Marca} {Modello} - Targa: {Targa} - Velocita: {Velocita} km/h";
        }

        public override string ToString()
        {
            return $"{Marca} {Modello} - Targa: {Targa} - Velocita: {Velocita} km/h";
        }

    }
}
