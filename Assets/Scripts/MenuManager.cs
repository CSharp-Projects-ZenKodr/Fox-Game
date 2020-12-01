using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void StartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }        

    public void QuitGame() 
    {
        Debug.Log("QUITED THE GAME");
        Application.Quit();
    }

    public void JumpToFirstLvl() 
    {
        SceneManager.LoadScene(2); 
    } 

    public void JumpToSecondLvl() 
    {
        SceneManager.LoadScene(3); 
    } 

    public void JumpToThirdLvl() 
    {
        SceneManager.LoadScene(4); 
    } 

    public void JumpToForthLvl() 
    {
        SceneManager.LoadScene(5); 
    } 

    public void Retroceder()
    {
        SceneManager.LoadScene(0);
    }
}
