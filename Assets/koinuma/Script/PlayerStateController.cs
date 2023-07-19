using UnityEngine;

[RequireComponent (typeof(Camera))]
public class PlayerStateController : MonoBehaviour
{
    [SerializeField] Sprite _smallSprite;
    [SerializeField] Sprite _normalSprite;
    [SerializeField] Sprite _fireSprote;
    Vector2 _smallSize = new Vector2(1, 1);
    Vector2 _nomalSize = new Vector2(1, 2);
    State _playerState = State.Small;
    SpriteRenderer _sprite;
    CapsuleCollider2D _collider;

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
            _sprite.color = new Color(1, 0.5f, 0); // �X�v���C�g�ݒ肵�������
        }
        _playerState = State.Fire;
    }

    /// <summary>�_���[�W���󂯂��Ƃ�</summary>
    public void GiveDamage()
    {
        if (_playerState == State.Small) // ���т̂Ƃ�
        {
            // ���񂾂Ƃ��̃��\�b�h���Ăяo��
        }
        else if (_playerState == State.Normal) // �ʏ�̂Ƃ�
        {
            _playerState = State.Small;
            _sprite.sprite = _smallSprite;
            _collider.size = _smallSize;
        }
        else // �\�͏�Ԃ̂Ƃ�
        {
            _playerState = State.Normal;
            _sprite.sprite = _normalSprite;
        }
    }

    enum State
    {
        Small,
        Normal,
        Fire,
    }
}
