using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Данный класс обрабатывает получение урона по врагу и выдачи награды за убийство.
 */
public class HealthHelper : MonoBehaviour {
    public int MaxHealth= 100;// Поле содержущие максимальное кол-во здоровья
    public int Health= 100;// Поле содержущие текущие здоровье
    public int Gold = 100;// поле содержущие сколько очков получит игрок за убийство врага.

    GameHelper gameHelper;
    /*
     * Метод запускается при старте игры и отвечает за поиск объекта  GameHelper
     */
    void Start () {
        gameHelper = GameObject.FindObjectOfType<GameHelper>();

    }
	
    /*
     * Данный метод отвечает за получение урона , уничтожение объекта , выдачу награды за убийство.
     * @param damage
     */
   public void GetHit(int damage)
    {
        int health = Health - damage;//Подсчет здоровья после нажатия
        /*
         * Если здоровье врага меньше или равно нулю, то дать нараду и уничтожить текущий объект 
         */
        if (health<=0)
        {
            gameHelper.TakeGold(Gold);
            Destroy(gameObject);
        }
        Health = health;//количество жизней если враг не умер.
        Debug.Log("Health - " + Health);//требуется для отладки
    }
}
