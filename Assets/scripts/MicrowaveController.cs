using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class MicrowaveController : MonoBehaviour
{
    public GameObject currentFood;  // 当前放入的食物
    public TMP_Text infoText; // （可选）显示状态提示，比如“Cooking...”
    public bool result = false;

    // 检测有物体进入微波炉触发区
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food")) // 判断是否为食物
        {
            currentFood = other.gameObject; // 保存当前食物对象
            Debug.Log("Food placed: " + currentFood.name);

            if (infoText != null)
                infoText.text = "Food ready to cook!";
        }
    }

    // 点击 Start 按钮时调用
        public void StartCooking()
        {
            if (currentFood == null)
            {
                Debug.Log("No food inside!");
                if (infoText != null)
                    infoText.text = "Please put food inside first!";
                return; // 没有食物就不执行下面的逻辑
            }

            Debug.Log("Cooking...");

            if (infoText != null)
                infoText.text = "Cooking...";

        // 判断安全性
        if (currentFood.gameObject.name == "egg")
        {
            result = false;
        }
        else
        {
            result = true;
        }

        if (result)
        {
            Debug.Log("Cooking done! safe food.");
        }
        else
        {
            Debug.Log("Cooking failed! Unsafe food.");
        }
        // ...
        ResultController.resultString = result ? "safe" : "unsafe";
        // 跳转到结果场景
        SceneManager.LoadScene("02result");
            
        }

} 
