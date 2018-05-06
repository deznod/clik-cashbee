using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Данный класс отвечает за клик мыши, включениее анимации по клику мыши на врага,а так же за нанисение урона.
 */
public class HitHelper : MonoBehaviour {

    /**
     *Метод обрабатывающий нажатие на клавишу мышы.
     */
     void OnMouseDown()
    {
        Debug.Log("OnMouseDown()");// Требуется для отлаживания
        GetComponent<Animator>().SetTrigger("Hit");// Включает анимацию по нажатию кнопки мыши по объекту 
        GetComponent<HealthHelper>().GetHit(10);// наносит урон в 10
    }


}
