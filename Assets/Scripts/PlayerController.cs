using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Finish"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
