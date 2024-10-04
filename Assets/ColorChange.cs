using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public GameObject targetObject;

    // ���������� ����
    public void ChangeToRed()
    {
        targetObject.GetComponent<Renderer>().material.color = Color.red;
        Debug.Log("�������� ���ض� �� !");
    }

    // �Ķ������� ����
    public void ChangeToBlue()
    {
        targetObject.GetComponent<Renderer>().material.color = Color.blue;
        Debug.Log("�Ķ����� ���ض� �� !");
    }
}
