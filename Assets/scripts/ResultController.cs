using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;  // 如果使用 TextMeshPro

public class ResultController : MonoBehaviour
{
    // 绑定场景中的显示文本
    public TMP_Text resultText;

    // 接收 MicrowaveController 传来的结果
    public static string resultString;

    void Start()
    {
        // 显示结果
        if (resultText != null)
        {
            resultText.text = resultString;
        }
        else
        {
            Debug.LogWarning("Result Text UI not assigned!");
        }
    }

//     // 返回菜单按钮调用的方法
//     public void ReturnToMenu()
//     {
//         SceneManager.LoadScene("MenuScene"); // 改成你的菜单场景名字
//     }
}
