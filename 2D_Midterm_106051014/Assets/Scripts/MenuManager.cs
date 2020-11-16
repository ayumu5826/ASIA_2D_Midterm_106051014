using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    //註解
    //按鈕跟程式溝通
    //私人 private
    //公開 public
    //void無類型

    public void SrartGame()
    {
        print("開始遊戲");
        SceneManager.LoadScene("關卡一");
    }

    public void QuitGame()
    {
        print("離開遊戲");
        Application.Quit();
    }
}
