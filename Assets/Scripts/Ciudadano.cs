using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NPC
{
    namespace Ally
    {

        public class Ciudadano : MonoBehaviour
        {
            public CiudadanoE citizen;

            void Start()
            {
                citizen.nombres = (Nombres)Random.Range(0, 20); //Randomizador para eleccion de nombre de ciudadano cuando se instancia uno.
                citizen.edad = Random.Range(15, 101); //Randomizador de edad de los ciudadanos cuando se instancia uno.
            }
        }
    }
}
