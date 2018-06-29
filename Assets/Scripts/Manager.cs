using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NPC.Ally;
using NPC.Enemy;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{

    HeroeE hero; //Estructura del heroe.
    ZombieE zombi; //Estructura del zombie.
    CiudadanoE ciudad; //Estructura del ciudadano.
    public const int max = 25; //Maximo de objetos a instanciar.
    public int NZ; //Variable que cuenta el numero de zombies.
    public int NC; //Variable que cuenta el numero de ciudadanos.
    public Text nz; //Variable de texto del canvas para los zombies.
    public Text nc; //Variable de texto del canvas para los ciudadanos.
    public GameObject[] npcs; //Matriz que guarda los gameobjects diferentes del heroe. 
 
    // Use this for initialization
	public void Start ()
    {
        Minima m = new Minima(Random.Range(0,16)); //Randomizador para cantidad minima de objetos a ser instanciados.

        zombi.color = new Color[] //Matriz de colores para los zombies.
        {
            Color.cyan, Color.green, Color.magenta
        };

        GameObject heroe = GameObject.CreatePrimitive(PrimitiveType.Capsule); //Instanciacion del heroe.

        //Asignacion de una posicion al azar al heroe.
        Vector3 pos1 = new Vector3(); 
        pos1.x = Random.Range(-10, 10);
        pos1.y = 1f;
        pos1.z = Random.Range(-10, 10);
        heroe.transform.position = pos1;

        //Asignacion de scripts de camara y movimiento.
        Camera.main.transform.SetParent(heroe.transform, false);
        Camera.main.transform.localPosition = new Vector3(0f, 1f, 0.5f);
        heroe.AddComponent(typeof(FPSmove));
        Camera.main.gameObject.AddComponent<FPSAim>();

        //Asignacion del script y el tag "heroe" y el rigidbody asi como limitar la rotacion(capsula).
        heroe.AddComponent<Heroe>();
        Rigidbody rgbdy1 = heroe.AddComponent<Rigidbody>();
        rgbdy1.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        heroe.tag = "Heroe";

        int i = Random.Range(m.min, max); //Randomizador para el numero de objetos a instanciarse.
        npcs = new GameObject[i+1]; //Asignacion del tamaño a la matriz de gameobjects.

        //Constructor de ciudadanos y zombies.
        for (int j = 0; j <= i; j++)
        {
            int k = Random.Range(0, 2); //Randomizador para construccion de zombie o ciudadano.
            if (k == 0)
            {
                //Bloque de codigo de instanciacion de zombies.
                GameObject zombie = GameObject.CreatePrimitive(PrimitiveType.Cube);
                int col = Random.Range(0, 3);
                 
                switch (col) //Switch para asignacion de color.
                {
                    case 0:
                        col = 0;
                        
                        break;
                    case 1:
                        col = 1;
                        
                        break;
                    case 2:
                        col = 2;
                        
                        break;

                }
                zombie.GetComponent<Renderer>().material.color = zombi.color [col];

                //Asignacion de una posicion al azar para el zombie.
                Vector3 pos2 = new Vector3();
                pos2.x = Random.Range(-10, 10);
                pos2.y = 0.5f;
                pos2.z = Random.Range(-10, 10);
                zombie.transform.position = pos2;

                zombie.tag = "Zombie"; //Asignacion de tag para el zombie.
              
                //Asignacion de scripts para disparar mensajes en colisiones.
                zombie.AddComponent<Heroe>();
                zombie.AddComponent<Rigidbody>();
                zombie.AddComponent<Zombie>();

                npcs[j] = zombie; //Colocacion del gameobject en la matriz.
            }
            else
            { 
                //Bloque de codigo para la instanciacion de los ciudadanos.
                ciudad.edad = Random.Range(15, 101); //Randomizador para la edad del ciudadano.
                GameObject ciudada = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

                //Asignacion de una posicion al azar para el ciudadano.
                Vector3 pos3 = new Vector3();
                pos3.x = Random.Range(-10, 10);
                pos3.y = 1f;
                pos3.z = Random.Range(-10, 10);
                ciudada.transform.position = pos3;

                //Asignacion del tag y el script "ciudadano", y asignacion y congelamiento del rigidbody. 
                Rigidbody rgbdy2 = ciudada.AddComponent<Rigidbody>();
                rgbdy2.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
                ciudada.tag =  "Ciudadano";
                ciudada.AddComponent<Ciudadano>();

                npcs[j] = ciudada; //Colocacion del gameobject en la matriz.
            }        
        }
       
        foreach(GameObject prim in npcs) //Loop para el conteo de ciudadanos y zombies en la escena.
        {
            if(prim.tag == "Zombie")
            {
                NZ++; //zombies.
            }
            else if(prim.tag == "Ciudadano")
            {
                NC++; //ciudadanos.
            }
        }

    }

	void Update ()
    {
        //Modificacion del canvas dependiendo del numero de ciudadanos y zombies.
        nz.text = NZ.ToString(); 
        nc.text = NC.ToString();
	}
    public class Minima //Clase para el minimo solo de lectura de gameobjects.
    {
        public readonly int min;

        public Minima(int m)
        {
            min = m;
        }
    }
}
