using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScriptObject : MonoBehaviour, IPointerDownHandler
{
	// ��� ������� ���������� ������
	public void OnPointerDown(PointerEventData eventData)
	{
		Destroy(this.gameObject);

		//����� ��������
		GameObject.FindGameObjectWithTag("Counter").GetComponent<Counter>().addCount();
	}
}
