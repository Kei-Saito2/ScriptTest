using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    //発展課題
    private int hp = 100;
    private int power = 25;
    private int mp = 53;
    private int magic = 5;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    public void Magic()
    {
        this.mp = mp - magic;
        if (this.mp >= 0)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else if (this.mp < 0)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}


public class Test : MonoBehaviour
{
    void Start()
    {
        //課題
        int[] array = { 1, 2, 3, 4, 5 };
        Debug.Log(array[0]);
        Debug.Log(array[1]);
        Debug.Log(array[2]);
        Debug.Log(array[3]);
        Debug.Log(array[4]);

        Array.Reverse(array);
        Debug.Log(array[0]);
        Debug.Log(array[1]);
        Debug.Log(array[2]);
        Debug.Log(array[3]);
        Debug.Log(array[4]);

        //発展課題
        Boss lastboss = new Boss();
        lastboss.Attack();
        lastboss.Defence(3);
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();

        Boss midboss = new Boss();
        midboss.Attack();
        midboss.Defence(5);
    }

    void Update()
    {

    }
}
