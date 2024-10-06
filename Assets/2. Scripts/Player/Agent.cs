using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 플레이어랑 적이 공통으로 쓰는 클래스 (공통 사용만 쓰는거)
// 나는 적이 이동방향이 하나밖에 없어서 복잡하지 않을거같음
public class Agent : MonoBehaviour
{
    // 플레이어랑 적이 동시에 쓸 만한 변수 만들기
    protected Rigidbody2D _rb;
}
