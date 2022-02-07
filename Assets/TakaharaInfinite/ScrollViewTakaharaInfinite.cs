// using System.Collections;
// using System.Collections.Generic;
// using System.Net.Mime;
// using UnityEngine;
// using EasingCore;
// using  FancyScrollView.Takahara;
//
// namespace FancyScrollView.Takahara
// {
//     public class ScrollViewTakaharaInfinite : FancyScrollView<MyCellData, Context>
//     {
//         [SerializeField] Scroller scroller = default;
//         [SerializeField] GameObject cellPrefab = default;
//
//
//         protected override GameObject CellPrefab => cellPrefab;
//
//
//         protected override void Initialize()
//         {
//             base.Initialize();
//             Context.OnCellClicked = SelectCell;
//             scroller.OnValueChanged(UpdatePosition);
//             scroller.OnSelectionChanged(UpdateSelection);
//         }
//
//         void UpdateSelection(int index)
//         {
//             if (Context.SelectedIndex == index)
//             {
//                 return;
//             }
//
//             Context.SelectedIndex = index;
//             Refresh();
//         }
//
//         public void UpdateData(IList<MyCellData> items)
//         {
//             UpdateContents(items);
//             
//             scroller.SetTotalCount(items.Count);
//             
//             
//         }
//
//         public void SelectCell(int index)
//         {
//
//             if (index < 0 || index >= ItemsSource.Count || index == Context.SelectedIndex)
//             {
//                 return;
//             }
//             
//             UpdateSelection(index); 
//             scroller.ScrollTo(index, 0.35f, Ease.OutCirc);
//         }
//         
//         
//         
//     }
//
//
//
//
// }