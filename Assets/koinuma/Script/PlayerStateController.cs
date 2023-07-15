using UnityEngine;

public class PlayerStateController : MonoBehaviour
{
    [SerializeField] Sprite _smallSprite;
    [SerializeField] Sprite _normalSprite;
    [SerializeField] Sprite _fireSprote;
    State _playerState = State.Small;
    SpriteRenderer _sprite;
    CapsuleCollider2D _collider;

    private void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _collider = GetComponent<CapsuleCollider2D>();
    }

    public void GetMashroom()
    {
        Vector2 colliderSize = new Vector2(1, 2);
        _collider.size = colliderSize;
        if (_playerState == State.Small)
        {
            _sprite.sprite = _normalSprite;
        }
        _playerState = State.Normal;
    }

    public void GetFireFlower()
    {
        Vector2 colliderSize = new Vector2(1, 2);
        _collider.size = colliderSize;
        if (_playerState != State.Fire)
        {
            _sprite.sprite = _fireSprote;
            _sprite.color = new Color(1, 0.5f, 0); // スプライト設定したら消す
        }
        _playerState = State.Fire;
    }

    enum State
    {
        Small,
        Normal,
        Fire,
    }
}
