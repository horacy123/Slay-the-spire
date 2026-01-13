using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;

public class CardViewCreator : Singleton<CardViewCreator>
{
    [SerializeField] private CardView CardViewPrefab;
    public CardView CreateCardView(Vector3 position, quaternion rotation)
    {
        CardView cardView = Instantiate(CardViewPrefab, position, rotation);
        cardView.transform.localScale = Vector3.zero;
        cardView.transform.DOScale(Vector3.one, 0.15f);
        return cardView;
    }

    
        
    
}
