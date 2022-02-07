using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using EasingCore;

namespace FancyScrollView.Takahara
{
   
    public class ExampleTakahara : MonoBehaviour {

    
        [SerializeField] MyScrollView scrollView = default;

        void Start()
        {
            var items = Enumerable.Range(0, 20)
                .Select(i => new MyCellData($"Cell {i}"))
                .ToArray();

            scrollView.UpdateData(items);
            scrollView.SelectCell(0);
        }

    }
}

