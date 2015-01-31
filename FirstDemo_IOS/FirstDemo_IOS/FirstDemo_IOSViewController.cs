using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace FirstDemo_IOS
{
	public partial class FirstDemo_IOSViewController : UIViewController
	{
		//UITableView table;
		string[] tableItems;
		static string selectedItem;
		public FirstDemo_IOSViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			//tableView = new UITableView(View.Bounds); // defaults to Plain style
			tableItems = new string[] {"Vegetables","Fruits","Flower Buds","Legumes","Bulbs","Tubers"};
			tableView.Source = new TableSourceSource(tableItems);
			//Add(tableView);
		}

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

			public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
			{
				FirstDemo_IOSViewController.selectedItem = tableItems[indexPath.Row];
				new UIAlertView("Row Selected", tableItems[indexPath.Row], null, "OK", null).Show();
				tableView.DeselectRow (indexPath, true); // normal iOS behaviour is to remove the blue highlight
			}

			public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
			{
				UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
				if (cell == null)
					cell = new UITableViewCell (UITableViewCellStyle.Default, cellIdentifier);
				cell.TextLabel.Text = tableItems[indexPath.Row];
				return cell;
			}

		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue (segue, sender);
			Detail d = segue.DestinationViewController as Detail;
			//Detail d = new Detail();
			if (d != null) {
				Console.WriteLine ("aaaaa");
				d.fruit = selectedItem;
			}
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion


	}

}

