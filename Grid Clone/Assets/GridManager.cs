using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GridManager : MonoBehaviour
{
    public GameObject _gem1;
    public GameObject _gem2;
    public GameObject _gem3;
    public GameObject _gem4;
    public GameObject _gem5;
    const int COLS = 5;
    const int ROWS = 3;
    int[,] _gems = new int[COLS, ROWS];
    public GameObject _gemPrefab;
    // Start is called before the first frame update
    void Start()
    {
       

       
        for (int x = 0; x < COLS; x++)
        {
            for (int y = 0; y < ROWS; y++)
            {
                int color = Random.Range(0, 9);
                _gems[x, y] = color;
            }
        }



        InstantiateGems();
       

    }

    void InstantiateGems()
    {
        for (int x = 0; x < COLS; x++)
        {
            for (int y = 0; y < ROWS; y++)
            {
                Debug.Log("Gem" + x + "," + y + ":" + _gems[x, y]);
                GameObject gem = GameObject.Instantiate(_gemPrefab);
                gem.transform.position = new Vector3(x, y, 0);
             //    gem.GetComponent<GemScript>().SetColor(_gems[x, y]); //need to make own GemScript and SetColor void for this to work 
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
