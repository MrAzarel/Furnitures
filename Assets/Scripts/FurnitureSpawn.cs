using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class FurnitureSpawn : MonoBehaviour
{
    //этот лист тебе не нужен. Потом передай сюда свой.
    public List<IPolygon> furnitures = new List<IPolygon>();
    public List<Furniture> polygons = new List<Furniture>();
    public GameObject[] gameObjects;

    void Start()
    {
        
    }

    public void PolygonToFurniture()
    {
        polygons.Clear();
        Furniture furniture;
        for (int i = 0; i < furnitures.Count; i++)
        {
            //Тут мне нужно вручить каждому объекту мебели его модельку
            furniture = (Furniture)furnitures[i];
            if (furniture.ID == 0)
            {
                furniture.sprite = GameObject.Find("Bed");
            }
            else if (furniture.ID == 1)
            {
                furniture.sprite = GameObject.Find("Table");
            }
            polygons.Add(furniture);
        }
    }

    public void GenerateFurnitureBtn()
    {
        PolygonToFurniture();
        Spawner(polygons);
    }

    public void Spawner(List<Furniture> polygons)
    {
        gameObjects = new GameObject[polygons.Count];
        //тут размещаем все зоны.
        for (int i = 0; i < polygons.Count; i++)
        {
            gameObjects[i] = Instantiate(polygons[i].sprite);
            gameObjects[i].transform.position = new Vector3((float)polygons[i].Center[0], 0.5f, (float)polygons[i].Center[1]);
        }
    }
}
