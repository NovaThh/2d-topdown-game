using UnityEngine;

public class Slot : MonoBehaviour
{
    private Inventory inventory;
    [SerializeField] private int i;

    private void Start() {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void Update() {
        if (transform.childCount <= 0) {
            inventory.isFull[i] = false;
        }
    }

    public void DropItem() {
        foreach(Transform child in transform) {
            GameObject.Destroy(child.gameObject);
        }
    }
}
