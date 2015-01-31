
using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace FirstDemo_IOS
{
	public class TableSourceCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("TableSourceCell");

		public TableSourceCell () : base (UITableViewCellStyle.Value1, Key)
		{
			// TODO: add subviews to the ContentView, set various colors, etc.
			TextLabel.Text = "TextLabel";
		}
	}
}

