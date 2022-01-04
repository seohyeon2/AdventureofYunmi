using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    /* 변수 선언 */
    public enum Type { Melee }; //근거리
    public int damage; //공격력
    public float rate; // 속도
    public BoxCollider meleeArea ; //범위
    public TrailRenderer trailEffect; //효과

    public void Use()
    {
        StopCoroutine("Swing");
        StartCoroutine("Swing");
    } 
    IEnumerator Swing()
    {
       //yield : 결과 전달하는 키워드 코루틴은 이거 필수
        yield return new WaitForSeconds(0.1f); // 0.1초 대기
        meleeArea.enabled = true;
        trailEffect.enabled = true;

        yield return new WaitForSeconds(0.3f); // 0.3초 대기
        meleeArea.enabled = false;

        yield return new WaitForSeconds(0.3f); // 0.3초 대기
        trailEffect.enabled = false;
    }
    
}
