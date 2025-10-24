using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void QuitGame()
    {
        Debug.Log("The game has quit!");
        Application.Quit(); }

    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    

    }
    
