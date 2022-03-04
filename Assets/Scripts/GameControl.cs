
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameControl : MonoBehaviour
{
    public GameObject PausePanel ,muzzleflash;
    public Transform BulletPrefab;
    public Camera maincam;

   // Rigidbody Bullet;
    public Transform Spawner;
    bool Ispaused = true;
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            PausePanel.SetActive(Ispaused);
            if (Ispaused)
            {
                CursorUNlock();
                PauseScene();
            }
            else 
            {
                Cursorlock();
                PlayScene();
            }
            Ispaused = !Ispaused;
        }
        if (Input.GetMouseButtonDown(0) && Time.timeScale != 0f)
        {
            //Spawner.GetComponent<AudioSource>().Play();
            Shoot();
        }
    }

    public void MuteAndUnmute()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }

    
    public void Shoot()
    {
        /*RaycastHit hit;
        if (Physics.Raycast(maincam.transform.position,maincam.transform.forward,out hit))
        {
            if (hit.transform.CompareTag("Enemy"))
            {
                hit.transform.GetComponent<Animator>().SetBool("Dead", true);
                hit.transform.GetComponent<BoxCollider>().enabled = false;
            }
        }*/
        //Spawner.transform.LookAt(hit.transform.transform);
        Instantiate(BulletPrefab, Spawner.position, Spawner.rotation);
        Instantiate(muzzleflash, Spawner.position, Spawner.rotation);

    }


    public void PauseScene()
    {
        Time.timeScale = 0f;
    }
    public void PlayScene()
    {
        Time.timeScale = 1f;
    }
    public void ChangeScene(int indx)
    {
        SceneManager.LoadScene(indx);
        Time.timeScale = 1f;
    }
    public void ExitGame()
    {
        Application.Quit();
    }


    public void Cursorlock()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void CursorUNlock()
    {
        Cursor.lockState = CursorLockMode.None;
    }




}
