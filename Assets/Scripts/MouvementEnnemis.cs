using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementEnnemis : MonoBehaviour
{

    public Transform groupeEnnemis;
    public Transform limiteEnnemisBas;
    public Transform limiteEnnemisDroite;
    public Transform limiteEnnemisGauche;
    //public Transform limiteEnnemisHaut;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        groupeEnnemis.position += new Vector3(0, -0.00001f, 0); 

        if(groupeEnnemis.position.y < limiteEnnemisBas.position.y)
        {
            groupeEnnemis.position += new Vector3(0.00001f, 0.00001f, 0); 
        }

        //if(groupeEnnemis.position.x > limiteEnnemisDroite.position.x)
        //{
            //groupeEnnemis.position = new Vector3(limiteEnnemisGauche.position.x, groupeEnnemis.position.y, groupeEnnemis.position.z);
        //}

        //if (groupeEnnemis.position.x < limiteEnnemisDroite.position.x)
        //{
            //groupeEnnemis.position = new Vector3(limiteEnnemisDroite.position.x, groupeEnnemis.position.y, groupeEnnemis.position.z);
        //}


    }
}
