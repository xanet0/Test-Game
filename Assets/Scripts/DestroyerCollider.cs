using UnityEngine;
using TMPro;
using System.Collections;

public class DestroyerCollider : MonoBehaviour
{
    public Counter scriptCounter;

    // �������� �� ��, �������� �� ������ ���������
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        scriptCounter.loseCount();
    }
}
