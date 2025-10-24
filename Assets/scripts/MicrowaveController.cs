using UnityEngine;
using UnityEngine.SceneManagement;

public class MicrowaveController : MonoBehaviour
{
    //     public GameObject currentFood;  // 当前放入的食物
    //     public UnityEngine.UI.Text infoText; // （可选）显示状态提示，比如“Cooking...”

    //     // 检测有物体进入微波炉触发区
    //     private void OnTriggerEnter(Collider other)
    //     {
    //         if (other.CompareTag("Food")) // 判断是否为食物
    //         {
    //             currentFood = other.gameObject; // 保存当前食物对象
    //             Debug.Log("Food placed: " + currentFood.name);

    //             if (infoText != null)
    //                 infoText.text = "Food ready to cook!";
    //         }
    //     }

    //     // 点击 Start 按钮时调用
    //     public void StartCooking()
    //     {
    //         if (currentFood == null)
    //         {
    //             Debug.Log("No food inside!");
    //             if (infoText != null)
    //                 infoText.text = "Please put food inside first!";
    //             return; // 没有食物就不执行下面的逻辑
    //         }

    //         Debug.Log("Cooking...");

    //         if (infoText != null)
    //             infoText.text = "Cooking...";

    //         // 获取食物信息
    //         Food food = currentFood.GetComponent<Food>();
    //         string result = "";

    //         // 判断安全性
    //         if (food.foodName == "Egg")
    //         {
    //             result = "Danger";
    //         }
    //         else
    //         {
    //             result = "Safe";
    //         }

    //         // 把结果传给 ResultController
    //         ResultController.resultString = result;

    //         // 跳转到结果场景
    //         SceneManager.LoadScene("02result");
    //     }


        public void StartCooking()
        {
            // 直接跳转到结果场景
            Debug.Log("Cooking...");
        }
} 
