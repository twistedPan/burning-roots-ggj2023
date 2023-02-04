using UnityEngine;

public class DestroyIfUnderMap : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < - 10)
        {
            Destroy(this.gameObject);
        }
    }
}
