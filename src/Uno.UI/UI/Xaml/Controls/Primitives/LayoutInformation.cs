﻿using Windows.Foundation;

namespace Windows.UI.Xaml.Controls.Primitives
{
	partial class LayoutInformation
	{
		public static Rect GetLayoutSlot(FrameworkElement element)
		{
			return element.LayoutSlot;
		}
	}
}
