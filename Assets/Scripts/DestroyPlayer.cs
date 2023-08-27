using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    private MeshRenderer objectRenderer;
    private SphereCollider objectCollider;
    private Rigidbody objectRigidbody;
    [SerializeField] private GameObject childObject;

    private void Start() 
    {
        objectRenderer = gameObject.GetComponent<MeshRenderer>();
        objectCollider = gameObject.GetComponent<SphereCollider>();
        objectRigidbody = gameObject.GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Destroy"))
        {
            objectRenderer.enabled = false;
            objectCollider.enabled = false;
            objectRigidbody.isKinematic = true;
            childObject.SetActive(true);
        }
    }
}
