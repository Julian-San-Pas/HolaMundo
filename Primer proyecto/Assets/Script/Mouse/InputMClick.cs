
using UnityEngine;
using UnityEngine.InputSystem;


public class InputMClick : MonoBehaviour
{

    private void OnMouseDown()
    {
        print("Mouse clicked on: " + gameObject.name);
        Debug.Log("Mouse clicked on: " + gameObject.name);
    }

    /*
    private Camera mainCamera;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    public void OnClick(InputAction.CallbackContext context)
    {

        if (!context.started)
            return;

        var rayhit = Physics2D.GetRayIntersection(mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue())
       //     Mathf.Infinity,
       //   LayerMask.GetMask("Default")
        );

        if (!rayhit.collider) return;
        Debug.Log("Clicked on: " + rayhit.collider.name + );


        /*
        if(rayhit.collider != null)
        {
            Debug.Log("Clicked on: " + rayhit.collider.name);
            // You can add more logic here, like interacting with the object
        }
        else
        {
            Debug.Log("Clicked in empty space");
        }

        
        if (context.performed)
        {
            Vector2 mousePosition = Mouse.current.position.ReadValue();
            Ray ray = mainCamera.ScreenPointToRay(mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Clicked on: " + hit.collider.name);
                // You can add more logic here, like interacting with the object
            }
            else
            {
                Debug.Log("Clicked in empty space");
            }
        }
    }*/
}

  
