using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPromptResponse : MonoBehaviour, ISelectionResponse
{
    [SerializeField] private GameObject buttonImage;
    public void OnDeselect(Transform selection)
    {
        buttonImage.SetActive(false);
    }

    public void OnSelect(Transform selection)
    {
        buttonImage.SetActive(true);
        buttonImage.transform.position = new Vector3(selection.position.x, selection.position.y + 2, selection.position.z);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
