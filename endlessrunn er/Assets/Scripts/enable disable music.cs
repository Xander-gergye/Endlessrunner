using UnityEngine;

public class DisableOnEnable : MonoBehaviour
{
    [SerializeField] private GameObject objectToDisable;  // The GameObject to disable

    private void OnEnable()
    {
        if (objectToDisable != null)
        {
            objectToDisable.SetActive(false);  // Disable the target GameObject
        }
    }
}
