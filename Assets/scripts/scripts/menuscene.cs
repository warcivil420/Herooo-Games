
using UnityEngine;
using UnityEngine.SceneManagement;
public class menuscene : MonoBehaviour
{
    public static int f;
    public void lvl1()
    {
        f = 1;
        Time.timeScale = 1f;
        SceneManager.LoadScene(f);


    }
    public void lvl2()
    {
        f = 2;
        Time.timeScale = 1f;
        SceneManager.LoadScene(f);
    }

    public void lvl3()
    {
        f = 3;
        Time.timeScale = 1f;
        SceneManager.LoadScene(f);
    }

    public void lvl4()
    {
        f = 4;
        Time.timeScale = 1f;
        SceneManager.LoadScene(f);
    }
    public void lvl5()
    {
        f = 5;
        Time.timeScale = 1f;
        SceneManager.LoadScene(f);
    }


      public void lvl6()
    {
        f = 6;
        Time.timeScale = 1f;
        SceneManager.LoadScene(f);
    }


        public void lvl7()
    {
        f = 7;
        Time.timeScale = 1f;
        SceneManager.LoadScene(f);
    }


     public void lvl8()
    {
        f = 8;
        Time.timeScale = 1f;
        SceneManager.LoadScene(f);
    }


     public void lvl9()
    {
        f = 9;
        Time.timeScale = 1f;
        SceneManager.LoadScene(f);
    }


    public void lvl0()
    {
        SceneManager.LoadScene(0);
    }
}
