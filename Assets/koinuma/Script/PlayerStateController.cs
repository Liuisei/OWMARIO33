using UnityEngine;

[RequireComponent (typeof(SpriteRenderer))]
[RequireComponent (typeof(CapsuleCollider2D))]
public class PlayerStateController : MonoBehaviour
{
    [SerializeField] float _godModeTime = 1.5f;
    [SerializeField] Sprite _smallSprite;
    [SerializeField] Sprite _normalSprite;
    [SerializeField] Sprite _fireSprote;
    Vector2 _smallSize = new Vector2(1, 1);
    Vector2 _nomalSize = new Vector2(1, 2);
    State _playerState = State.Small;
    SpriteRenderer _sprite;
    CapsuleCollider2D _collider;
    bool _isInvincibleTime = false;

    private void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _collider = GetComponent<CapsuleCollider2D>();
        _sprite.sprite = _smallSprite;
        _collider.size = new Vector2(1, 1);

    }

    public void GetMashroom()
    {
        if (_playerState == State.Small)
        {
            _playerState = State.Normal;
            _sprite.sprite = _normalSprite;
            _collider.size = _nomalSize;
        }
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

    /// <summary>ダメージを受けたとき</summary>
    public void GiveDamage()
    {
        if (!_isInvincibleTime)
        {
            if (_playerState == State.Small) // ちびのとき
            {
                // 死んだときのメソッドを呼び出す
            }
            else if (_playerState == State.Normal) // 通常のとき
            {
                _playerState = State.Small;
                _sprite.sprite = _smallSprite;
                _collider.size = _smallSize;
            }
            else // 能力状態のとき
            {
                _playerState = State.Normal;
                _sprite.sprite = _normalSprite;
            }
            Invoke(nameof(CanDamage), _godModeTime);
            _isInvincibleTime = true;
        }
    }

    /// <summary>無敵時間のためにのメソッド</summary>
    void CanDamage()
    {
        _isInvincibleTime = false;
    }

    enum State
    {
        Small,
        Normal,
        Fire,
    }
}
