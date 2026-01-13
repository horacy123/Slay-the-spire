using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestSystem : MonoBehaviour
{
    [SerializeField] private HandView handView;

    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            CardView cardView = CardViewCreator.Instance.CreateCardView(transform.position, quaternion.identity);
            StartCoroutine(handView.AddCard(cardView));
        }
    }
}
