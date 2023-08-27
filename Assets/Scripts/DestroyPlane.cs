using UnityEngine;

public class DestroyPlane : MonoBehaviour
{
    private Rigidbody[] childObjRb;
    private Animator[] childObjAnim;
    [SerializeField] private GameObject trackObj;

    private void Start() 
    { 
        childObjRb = gameObject.GetComponentsInChildren<Rigidbody>();
        childObjAnim = gameObject.GetComponentsInChildren<Animator>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        trackObj.SetActive(true);
        if(other.gameObject.tag == "Player")
        {
            foreach (var item in childObjRb)
            {
                item.isKinematic = false;
            }
            foreach (var item in childObjAnim)
            {
                item.SetTrigger("Trigger");
            }
            Destroy(gameObject, 5f);
        }
    }
}
