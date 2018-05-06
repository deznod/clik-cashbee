using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
 *Данный класс реализует логику спавна новых монстров , логику получения награды(золота).
 */
public class GameHelper : MonoBehaviour
{
    public Transform StartPosition;// поле содержущие кординаты появления нового монстра

    public Text PlayerGoldUI;// Поле содержущие текст

    public GameObject[] MonstorsPrefabs;//Поле содержущие массив монстров(врагов)

    public GameObject GoldPrefab;//Поле содержуще объект

    public int PlayerGold;//Поле содержущие кол-во награды игрока.

    /*
     * Метод запускается при старте игры и отвечает за спавн первого монстра.
     */
    void Start()
    {
        SpawnMonsters();
    }

    // Метод обновляется каждый кадр и отвечает за обновление текста с колличеством золотом игрока. 
    void Update()
    {

        PlayerGoldUI.text = PlayerGold.ToString();


    }
    /*
     *Метод  отвечающий за реализацию получение награды
     * @param gold
     */
    public void TakeGold(int gold)
    {
        PlayerGold += gold;// 0+кол-во золота за убийство монстра(в данный момент это 100)
        GameObject GoldObj = Instantiate(GoldPrefab).gameObject;//Клон объекта Золото
        Destroy(GoldObj, 2);//Уничтожить объект золото через 2 секунды
        SpawnMonsters();//произвести спавн монстора
    }
    /*
     * Метод отвечающий за спавн новых монстров 
     */
    public void SpawnMonsters()
    {
        int index = 0;//Номер объетка который содержится в массиве
        GameObject MonstersObj = Instantiate(MonstorsPrefabs[index]).gameObject;//клон объекта монстор
        MonstersObj.transform.position = StartPosition.position;//позиция для появления новых монстров
    }
}
