// using System.Collections.Generic;
// using UnityEngine.Assertions;
//
// // TODO: Add stack to Dialogs
// namespace Airion.UI {
//     public static class UIStack {
//         
//         static Stack<UIScreenController> _uiStack = new Stack<UIScreenController>();
//
//         public static int Count => _uiStack.Count;
//
//         public static void Push(UIScreenController panel) {
//             Assert.IsNotNull(panel, "UIStack.Push: panel is null");
//
//             // hide top
//             if (Count > 0) {
//                 UIScreenController curPanel = Peek();
//             }
//
//             // push new
//             _uiStack.Push(panel);
//             panel.IsActive = true;
//         }
//
//         public static UIScreenController Pop() {
//             // pop top
//             UIScreenController poppedPanel = _uiStack.Pop();
//             Assert.IsNotNull(poppedPanel, "UIStack.Pop: Top panel is null");
//             poppedPanel.IsActive = false;
//
//             // show prev
//             if (Count > 0) {
//                 UIScreenController newTop = Peek();
//                 Assert.IsNotNull(poppedPanel, "UIStack.Pop: New top panel is null");
//                 newTop.IsActive = true;
//             }
//
//             return poppedPanel;
//         }
//
//         public static void Clear() {
//             _uiStack.Clear();
//         }
//
//         public static UIScreenController Peek() {
//             Assert.IsTrue(Count > 0, "UIStack.Peek: The stack is empty");
//             return _uiStack.Peek();
//         }
//
//         public static bool Contains(UIScreenController panel) {
//             return _uiStack.Contains(panel);
//         }
//     }
// }