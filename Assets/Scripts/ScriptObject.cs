using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScriptObject : MonoBehaviour, IPointerDownHandler
{
	// При нажатии уничтожает объект
	public void OnPointerDown(PointerEventData eventData)
	{
		Destroy(this.gameObject);

		//Поиск счётчика
		GameObject.FindGameObjectWithTag("Counter").GetComponent<Counter>().addCount();
	}
}
