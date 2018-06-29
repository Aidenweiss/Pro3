using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct HeroeE //Estructra del Heroe.
    { 
        public float speed;
    }

    public struct ZombieE //Estructura de los zombies.
    {
        public Color[] color;
        public float zombiespd;
        public gusto partes;
    }

public enum behavior //Enumeracion del comportamiento de los zombies.
{
    idle, moving, rotate
}

public enum gusto //Enumeracion de los gustos de los zombies.
{
    cerebro, pies, manos, higado, riñones

}

public struct CiudadanoE //Estructura del ciudadano.
    {
        public Nombres nombres;
        public int edad;
    }

public enum Nombres //Enumeracion de los nombres de los ciudadanos.
{
    Abraham, Juan, Alejo, William, Cote,
    Tatiana, Carolina, Vanesa, Juliana, Cristina,
    Elkin, Sebastian, Roberto, Omar, Diego,
    Sara, Andrea, Jennifer, Laura, Karla
}

