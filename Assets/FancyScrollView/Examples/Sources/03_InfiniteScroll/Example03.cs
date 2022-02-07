/*
 * FancyScrollView (https://github.com/setchi/FancyScrollView)
 * Copyright (c) 2020 setchi
 * Licensed under MIT (https://github.com/setchi/FancyScrollView/blob/master/LICENSE)
 */

using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using UnityEngine;

namespace FancyScrollView.Example03
{
    class Example03 : MonoBehaviour
    {
        [SerializeField] ScrollView scrollView = default;

        private IList<ItemData> items = new List<ItemData>();
        private int nodeCount =1;

        void Start()
        {
            // var items = Enumerable.Range(0, 20)
            //     .Select(i => new ItemData($"Cell {i}"))
            //     .ToArray();

            for (int i = 0; i < nodeCount; i++)
            {
                ItemData tmp = new ItemData($"{i}番目のCellです");
              items.Add(tmp);
            }
            scrollView.UpdateData(items);
            scrollView.SelectCell(0);
        }

        public void NodeCountAdd()
        {
            this.nodeCount += 1;
            Debug.Log($"今現在の{nodeCount}はいくつです");
            

        }
    }
}
