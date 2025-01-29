using UnityEngine;
using UnityEngine.UI;

public class AttackCharge : MonoBehaviour
{
    public Slider Slider;
    public Image fill;
    public Gradient gradient;

    public void SetCharge (int charge)
    {
        Slider.value = charge;
        fill.color = gradient.Evaluate(Slider.normalizedValue);
    }
        
        public void InitializeCharge(int minCharge, int maxCharge)
        {
            Slider.minValue = minCharge;
            Slider.maxValue = maxCharge;
            Slider.value = minCharge; 
            
            fill.color = gradient.Evaluate(Slider.normalizedValue);
        }

      
}
