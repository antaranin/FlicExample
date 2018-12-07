// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace FlicExample
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UILabel ClickCountLbl { get; set; }

		[Outlet]
		UIKit.UIButton ConnectFlicBtn { get; set; }

		[Outlet]
		UIKit.UILabel StatusLbl { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ConnectFlicBtn != null) {
				ConnectFlicBtn.Dispose ();
				ConnectFlicBtn = null;
			}

			if (ClickCountLbl != null) {
				ClickCountLbl.Dispose ();
				ClickCountLbl = null;
			}

			if (StatusLbl != null) {
				StatusLbl.Dispose ();
				StatusLbl = null;
			}
		}
	}
}
