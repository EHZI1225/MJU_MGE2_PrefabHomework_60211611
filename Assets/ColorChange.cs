using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public GameObject targetObject;

    // 빨간색으로 변경
    public void ChangeToRed()
    {
        targetObject.GetComponent<Renderer>().material.color = Color.red;
        Debug.Log("빨강으로 변해라 얍 !");
    }

    // 파란색으로 변경
    public void ChangeToBlue()
    {
        targetObject.GetComponent<Renderer>().material.color = Color.blue;
        Debug.Log("파랑으로 변해라 얍 !");
    }
}
