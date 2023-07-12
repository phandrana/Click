using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public static int LINE = 5;
    public static int COLUMN = 12;

    public static float WIDTH;
    public static float HEIGHT;

    public static GameObject CELL;
    public static float CELL_WIDTH;
    public static float CELL_HEIGHT;

    void CreateCell(float fX, float fY, float fWidth, float fHeight)
    {
        //TODO 1
        //========================================
        //Créer une CELL en instantiant le prefab dans Setup, et en positionnant l'objet au coordonnée fX, fY et de taille fWidth, fHeight
        //========================================
    }

    void Start()
    {
        //Taille de l'ecran
        HEIGHT = Camera.main.orthographicSize * 2f;
        WIDTH = HEIGHT * Camera.main.aspect;

        //Prefab CELL
        CELL = (GameObject)Resources.Load("Cell");

        //TODO 2
        //========================================
        //Remplir l'ecran de CELL les unes à côté des autres
        //Utilisez les variables LINE et COLUMN pour renseigner le nombre de CELL
        //Utilisez les variables WIDTH et HEIGHT pour calculer la taille d'une CELL
        //Utilisez la fonction CreateCell
        //========================================
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Debug.Log("Clicked");
            //TODO 3
            //========================================
            //Afficher les coordonnées i,j de la case sur laquelle on a cliqué
            //Le coin haut gauche correspond à 0,0
            //========================================
        }
    }
}