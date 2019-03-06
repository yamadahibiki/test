using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterdata : MonoBehaviour
{
    public static GameObject[] enemy = new GameObject[10];
    
    public static int[] enemy_Lv = new int[10];
    public static int[,] enemy_H = new int[10, 4];
    public static int[,] enemy_M = new int[10, 4];
    public static int[,] enemy_A = new int[10, 4];
    public static int[,] enemy_D = new int[10, 4];
    public static int[,] enemy_S = new int[10, 4];
    public static int[,] enemy_G = new int[10,4];
    public static int[,] enemy_Ex = new int[10,4];
    // Use this for initialization
    void Start()
    {
        enemy[0] = GameObject.Find("スライム");
        enemy[1] = GameObject.Find("おおがらす");
        enemy[2] = GameObject.Find("ikkakuusagi");
        enemy[3] = GameObject.Find("ooarikui");
        enemy[4] = GameObject.Find("zinmentyou");
        enemy[5] = GameObject.Find("froger");
        enemy[6] = GameObject.Find("bubbleslime");
        enemy[7] = GameObject.Find("mahoutukai");
        enemy[8] = GameObject.Find("sasoribati");
        enemy[9] = GameObject.Find("hoimislime");
        for (int i = 0; i < 4; i++)
        {
            //スライム
            enemy_Lv[0] = 1;
            enemy_H[0, i] = 8;
            enemy_M[0, i] = 0;
            enemy_A[0, i] = 9;
            enemy_D[0, i] = 5;
            enemy_S[0, i] = 1000000;
            enemy_G[0,i] = 2;
            enemy_Ex[0,i] = 4;
            //おおがらす
            enemy_Lv[1] = 1;
            enemy_H[1, i] = 8;
            enemy_M[1, i] = 0;
            enemy_A[1, i] = 9;
            enemy_D[1, i] = 10;
            enemy_S[1, i] = 4;
            enemy_G[1,i] = 2;
            enemy_Ex[1,i] = 5;
        }



    }

    // Update is called once per frame
    void Update()
    {

    }





}
