using UnityEngine;

public class Draggable : MonoBehaviour
{
    private Vector3 offset;   // 鼠标与物体中心的偏移
    private bool dragging = false;

    // 鼠标按下时触发
    void OnMouseDown()
    {
        offset = transform.position - GetMouseWorldPos();
        dragging = true;
    }

    // 鼠标松开时触发
    void OnMouseUp()
    {
        dragging = false;
    }

    // 每帧更新物体位置
    void Update()
    {
        if (dragging)
            transform.position = GetMouseWorldPos() + offset;
    }

    // 将鼠标屏幕坐标转换为世界坐标
    Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = 5f; // 离摄像机的距离（根据场景调整）
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
}


