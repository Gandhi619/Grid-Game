using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassExampleStuff : MonoBehaviour
{
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}

    //private int CheckColumn(GameObject currentCell, int col, int row)
    //{
        
    //    List<GameObject> matches = new List<GameObject>();
    //    for(int tempRow = row+1; tempRow < HEIGHT; ++row)
    //    {
    //        Debug.Log("checking cell:" + col + "," + tempRow);
    //        GameObject tempCell = tokens[col, tempRow];
    //        if(tempCell.color == currentCell.color)
    //        {
    //            matches.Add(tempCell);
    //            Debug.Log("found a match");
    //        }
    //        else
    //        {
    //            Debug.Log("didn't find a match, going to next column");
    //            break;
    //        }
    //    }
    //    if(matches.Count > 3)
    //    {
    //        //do matching stuff;
    //    }
    //}
    //public void CheckForMatches()
    //{
    //    GameObject currentCell;
    //    List<GameObject> gemsToDestroy = new List<GameObject>;
    //    for (int col = 0; col < WIDTH; ++col)
    //    {
    //        for (int row = 0; row < HEIGHT; ++row)
    //        {
    //            currentCell = tokens[col, row];
              
    //            tempList = CheckColumn(currentCell, col, row);
    //            foreach(GameObject go in tempList)
    //            {
    //                gemsToDestroy.Add(go);
    //            }
    //        }
    //    } //to do same thing for row, just switch rows and columns. 
    //}
    //public void MakeGemsFall()
    //{
    //    for (int col = HEIGHT-1; col >= 0; col--)
    //    {
    //        for (int row = WIDTH - 1; row >= 0; row--)
    //        {
    //            GameObject currentToken = tokens[col, row];
    //            int distance = 0;

    //            do
    //            {
    //                distance++;
    //                destination = tokens[col, row + distance];
    //            }
    //            while (destination == null);
    //            tokens[col, row] = null;
    //            tokens[col, row + distance] = currentToken;
                
    //        }
    //    }
    //}

}
