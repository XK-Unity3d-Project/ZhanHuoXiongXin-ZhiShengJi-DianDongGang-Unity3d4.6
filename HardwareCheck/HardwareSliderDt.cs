using UnityEngine;

public class HardwareSliderDt : MonoBehaviour
{
    public int ZhouYunXingCmd;
    public enum SliderEnum
    {
        YunXingShuLiang1,
        YunXingShuLiang2,
        YunXingShuLiang3,
        YunXingShuLiang4,
        YunXingSuDu1,
        YunXingSuDu2,
        YunXingSuDu3,
        YunXingSuDu4,
    }
    public SliderEnum SliderState;
}