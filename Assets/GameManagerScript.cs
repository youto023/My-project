using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    // int[] map = { 0, 2, 0, 2, 0, 0, 0, 1, 0, 0, 2, 0, 2, 0, 0 };

    //追加
    public GameObject playerPrefab;
    public GameObject otharPrefab;
    int[,] map;//変更。二次元配列で宣言   //レベルデザイン用の配列
    GameObject[,] field;//ゲーム管理用の配列

    GameObject obj;
    obj.tag
    // Start is called before the first frame update
    private Vector2Int GetPlayerIndex()
    {
        for (int i = 0; i < field.Length; i++)
        {
            return 1;
        }
    }
    return new Vector2Int(-1,-1);
    void Start()
    {



        map = new int[,] {//変更分かりやすく３ｘ５サイズ
        { 0 ,0 ,0 ,0 ,0},
       { 0 ,0 , 1 ,0 , 0 } ,
        { 0, 0 ,0 ,0 ,0 }
        };
        field = new GameObject[
            map.GetLength(0),
            map.GetLength(1)
            ];



        string debugText = "";
        //変更。二次元for文で二次元配列の情報を出力
        for (int y = 0; y < field.GetLength(0); y++)
        {
            for (int x = 0; x < field.GetLength(1); x++)
            {

                if (map[y, x] == 1)
                {
                    //  GameObject instace = //書き換え
                    field[y, x] = Instantiate(playerPrefab,
            new Vector3(x, map.GetLength(0) - 1 - y, 0),
            Quaternion.identity);
                }
                else
                {
                    field[y, x] = Instantiate(otharPrefab,
           new Vector3(x, map.GetLength(0) - 1 - y, 0),
           Quaternion.identity);
                }
                debugText += map[y, x].ToString() + ",";
            }
            debugText += "\n";//改行
        }
        Debug.Log(debugText);


    }
        // PrintArray();
    

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        // {
       int GetPlayerIndex() { }

        for (int i = 0; i < map.Length; i++)
        //  {
            if (map[i] == 1)
             {
        /        playerIndex = i;
                break;
             }
         }

        //  MoveNomber(1, playerIndex, playerIndex + 1);

        //  PrintArray();
        /// }

        //  if (Input.GetKeyDown(KeyCode.LeftArrow))
        // {
        //    int playerIndex = -1;

        //    for (int i = 0; i < map.Length; i++)
        //   {
        //      if (map[i] == 1)
        //      {
        //          playerIndex = i;
        //          break;
        //      }
        //    }

        //   MoveNomber(1, playerIndex, playerIndex - 1);

        //      PrintArray();
        // }


    }
    void PrintArray()
    {
        //   string debugText = "";
        // for (int i = 0; i < map.Length; i++)
        // {
        //       debugText += map[i].ToString() + ",";

        //    }
        //    Debug.Log(debugText);
    }

        //bool MoveNomber(int number, int moveFrom, int moveTo)
        // {
        // if (moveTo < 0 || moveTo >= map.Length) { return false; }

        //  if (map[moveTo] == 2)
        //  {
        //    int velocity = moveTo - moveFrom;
        //    bool success = MoveNomber(2, moveTo, moveTo + velocity);

        //     if (!success) { return false; }
        //     }

        //   map[moveTo] = number;
        //   map[moveFrom] = 0;
        //    return true;
        // }
  
}