using UnityEngine;

public class NPC : MonoBehaviour
{

    private void Start()
    {

    }
    
    /// <summary>
    /// npc對話
    /// </summary>
    /// <param name="talkto">對話的內容</param>
    private void talk(string talkto ="對話的內容")
    {

    }
    /// <summary>
    /// 打開商店
    /// </summary>
    /// <returns>打開商店</returns>
    private bool openstore()
    {
        return true;
    }
    /// <summary>
    /// 購買商品
    /// </summary>
    /// <param name="price">價格100</param>
    /// <returns></returns>
    private int buyitem(int itemprice = 100)
    {
        return 0;
    }
    /// <summary>
    /// 取得任務
    /// </summary>
    /// <param name="questnumber">任務編號</param>
    private void getquest(int questnumber)
    {

    }
    /// <summary>
    /// 任務更新
    /// </summary>
    /// <param name="questitem">獲得道具數量</param>
    /// <returns></returns>
    private int NEWQUEST(int questitem= 1)
    {
        return 0;
    }
    /// <summary>
    /// 這是完成任務確認
    /// </summary>
    /// <param name="questnumber">任務編號</param>
    /// <returns></returns>
    private bool finishquest(int questnumber)
    {
        return false;
    }
}
