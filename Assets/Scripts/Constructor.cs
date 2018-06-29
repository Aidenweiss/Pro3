using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Constructor : MonoBehaviour
{

    public ZombieE zombieInfo;
    public HeroeE heroeInfo;
    public CiudadanoE ciudInfo;
    // Use this for initialization
    void Start ()
    {
        ciudInfo.nombres = new string[]
        {
            "Abraham","Juan","Alejo","William","Cote",
            "Tatiana","Carolina","Vanesa","Juliana","Cristina",
            "Elkin","Sebastian","Roberto","Omar","Diego",
            "Sara","Andrea","Jennifer","Laura","Karla"
        };

        Heroe z = new Heroe();
        int i = Random.Range(9, 20);

        for (int j = 0; j <= i; j++)
        {
            int k = Random.Range(0, 2);
            if (k == 0)
            {
                
                int p = Random.Range(0, 3);

                if (p == 0)
                {
                    zombieInfo.color = Color.cyan;
                }
                else if (p == 1)
                {
                    zombieInfo.color = Color.magenta;
                }
                else if (p == 2)
                {
                    zombieInfo.color = Color.green;
                }
                Zombie s = new Zombie(); 
            }
            else
            {
                ciudInfo.edad = Random.Range(15, 101);
                int o = Random.Range(0, 20);
                Citizen g = new Citizen(ciudInfo.edad, ciudInfo.nombres[o]);
            }
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public class Heroe
    {
        GameObject hero;

        public Heroe()
        {
            hero = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            Vector3 pos1 = new Vector3();
            pos1.x = Random.Range(-10, 10);
            pos1.y = 1f;
            pos1.z = Random.Range(-10, 10);
            hero.transform.position = pos1;
            
            
            Camera.main.transform.SetParent(hero.transform, false);
            Camera.main.transform.localPosition = new Vector3(0f, 1f, 0.5f);
            hero.AddComponent(typeof(FPSmove));
            Camera.main.gameObject.AddComponent<FPSAim>();

            
        }
    } 

    public class Zombie
    {
        public ZombieE zombieInfo;
        GameObject zombi;

        public Zombie()
        {
            
            zombi = GameObject.CreatePrimitive(PrimitiveType.Cube);
            zombi.GetComponent<Renderer>().material.color = zombieInfo.color;

            Vector3 pos2 = new Vector3();
            pos2.x = Random.Range(-10, 10);
            pos2.y = 0.5f;
            pos2.z = Random.Range(-10, 10);
            zombi.transform.position = pos2;

            
        }
    }

    public class Citizen
    {
        public string names;
        GameObject ciudad;

        public Citizen(int edad, string k)
        {
            names = k;
            ciudad = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

            Debug.Log("Hola, mi nombre es " +k +" y tengo " +edad +" años");

            Vector3 pos3 = new Vector3();
            pos3.x = Random.Range(-10, 10);
            pos3.y = 1f;
            pos3.z = Random.Range(-10, 10);
            ciudad.transform.position = pos3;

            
        }
    }

   
   
}*/

