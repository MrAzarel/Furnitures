using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine.UI;
using UnityEngine;

public class SpawnFloor : MonoBehaviour
{
    [SerializeField] public GameObject _floor;
    [SerializeField] public Text _hight;
    [SerializeField] public Text _width;
    //этот лист тебе не нужен. Потом передай сюда свой.
    public List<Floor> tiles = new List<Floor>();
    public GameObject[] gameObjects;

    public int hight = 10;
    public int width = 10;

    void Start()
    {

    }

    public void GenerateBtn()
    {
        tiles.Clear();
        for (int i = 0; i < gameObjects.Length; i++)
        {
            Destroy(gameObjects[i]);
        }

        hight = int.Parse(_hight.text);
        width = int.Parse(_width.text);

        for (int i = 0; i < hight; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Floor temp = new Floor();
                temp.center[0] = -width / 2 + j;
                temp.center[1] = hight / 2 - i;
                temp.sprite = _floor;
                tiles.Add(temp);
            }
        }

        Spawner(tiles);
    }

    public void Spawner(List<Floor> tiles)
    {
        gameObjects = new GameObject[tiles.Count];
        //тут размещаем все зоны.
        for (int i = 0; i < tiles.Count; i++)
        {          
            gameObjects[i] = Instantiate(tiles[i].sprite);
            gameObjects[i].transform.position = new Vector3((float)tiles[i].center[0], 0.5f, (float)tiles[i].center[1]);
        }
    }
}
