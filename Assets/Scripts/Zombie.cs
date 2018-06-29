using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NPC
{
    namespace Enemy
    {
        public class Zombie : MonoBehaviour
        {

            public ZombieE zombis;

            int dir; //Variable para la direccion del zombie.
            int rot; //Variable para la rotacion del zombie.

            behavior estado; //Variable para el estado de l zombie.

            int idle = 0;
            int moving;

            //	coorutina
            IEnumerator MovimientoZombie() //Corrutina para el movimiento del zombie.
            {
                yield return new WaitForSeconds(3);
                estado = (behavior)Random.Range(0, 3); //Randomizador para la condicion del zombie.
                dir = Random.Range(0, 4); //Randomizador para la direccion a moverse.
                rot = Random.Range(0, 2); //randomizador para la direccion a rotar.

                Moving(); //Llamada al metodo de movimiento del zombie.
                StartCoroutine(MovimientoZombie());
            }

            // Use this for initialization
            void Start()
            {
                zombis.partes = (gusto)Random.Range(0, 5); //Randomizador para las partes de las que gusta cada zombie.
                zombis.zombiespd = Random.Range(0.5f, 1.5f); //Randomizador para la velocidad del zombie.
                StartCoroutine(MovimientoZombie());
            }

            // Update is called once per frame
            void Update()
            {
                switch (estado)
                {
                    case behavior.idle: //Estado "estatico".
                        break;

                    case behavior.moving: //Estado "en movimiento".
                        Moving();
                        break;
                    case behavior.rotate: //Estado "rotar".
                        Rotate();
                        break;
                }
            }

            public void Moving() //Metodo para el movimiento del zombie.
            {
                switch (dir) 
                {
                    case 0:
                        transform.position += transform.forward * zombis.zombiespd * Time.deltaTime;
                        break;

                    case 1:
                        transform.position -= transform.forward * zombis.zombiespd * Time.deltaTime;
                        break;

                    case 2:
                        transform.position += transform.right * zombis.zombiespd * Time.deltaTime;
                        break;

                    case 3:
                        transform.position -= transform.right * zombis.zombiespd * Time.deltaTime;
                        break;
                }
            }
            public void Rotate() //Metodo para la rotacion del zombie.
            {
                switch (rot)
                {
                    case 0:
                        transform.Rotate(0, 1 * zombis.zombiespd, 0);
                        break;
                    case 1:
                        transform.Rotate(0, -1 * zombis.zombiespd, 0);
                        break;
                }


            }
        }
    }
}