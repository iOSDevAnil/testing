
using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace FirstDemo_IOS
{
	public class TableSourceSource : UITableViewSource
	{
		string[] tableItems;
		string cellIdentifier = "Cell";
		public TableSourceSource (string[] items)
		{
			tableItems = items;
		}
		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return tableItems.Length;
		}

//		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
//		{
//			new UIAlertView("Row Selected", tableItems[indexPath.Row], null, "OK", null).Show();
//			tableView.DeselectRow (indexPath, true); // normal iOS behaviour is to remove the blue highlight
//		}
//		public override string TitleForHeader (UITableView tableView, int section)
//		{
//			return "Header";
//		}
//
//		public override string TitleForFooter (UITableView tableView, int section)
//		{
//			return "Footer";
//		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
			if (cell == null)
				cell = new UITableViewCell (UITableViewCellStyle.Default, cellIdentifier);
			cell.TextLabel.Text = tableItems[indexPath.Row];
			return cell;
		}
	
	}
}

