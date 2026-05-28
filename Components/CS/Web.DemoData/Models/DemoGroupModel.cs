#region Copyright (c) 2000-2026 Developer Express Inc.
/*
{*******************************************************************}
{                                                                   }
{       Developer Express .NET Component Library                    }
{                                                                   }
{                                                                   }
{       Copyright (c) 2000-2026 Developer Express Inc.              }
{       ALL RIGHTS RESERVED                                         }
{                                                                   }
{   The entire contents of this file is protected by U.S. and       }
{   International Copyright Laws. Unauthorized reproduction,        }
{   reverse-engineering, and distribution of all or any portion of  }
{   the code contained in this file is strictly prohibited and may  }
{   result in severe civil and criminal penalties and will be       }
{   prosecuted to the maximum extent possible under the law.        }
{                                                                   }
{   RESTRICTIONS                                                    }
{                                                                   }
{   THIS SOURCE CODE AND ALL RESULTING INTERMEDIATE FILES           }
{   ARE CONFIDENTIAL AND PROPRIETARY TRADE                          }
{   SECRETS OF DEVELOPER EXPRESS INC. THE REGISTERED DEVELOPER IS   }
{   LICENSED TO DISTRIBUTE THE PRODUCT AND ALL ACCOMPANYING .NET    }
{   CONTROLS AS PART OF AN EXECUTABLE PROGRAM ONLY.                 }
{                                                                   }
{   THE SOURCE CODE CONTAINED WITHIN THIS FILE AND ALL RELATED      }
{   FILES OR ANY PORTION OF ITS CONTENTS SHALL AT NO TIME BE        }
{   COPIED, TRANSFERRED, SOLD, DISTRIBUTED, OR OTHERWISE MADE       }
{   AVAILABLE TO OTHER INDIVIDUALS WITHOUT EXPRESS WRITTEN CONSENT  }
{   AND PERMISSION FROM DEVELOPER EXPRESS INC.                      }
{                                                                   }
{   CONSULT THE END USER LICENSE AGREEMENT FOR INFORMATION ON       }
{   ADDITIONAL RESTRICTIONS.                                        }
{                                                                   }
{*******************************************************************}
*/
#endregion Copyright (c) 2000-2026 Developer Express Inc.

using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
namespace DevExpress.Web.Demos {
	public class DemoGroupModel : DemoModelBase {
		string virtualGroupKey;
		List<DemoPageModel> _demos = new List<DemoPageModel>();
		[XmlAttribute]
		public string VirtualGroupKey {
			get {
				if (virtualGroupKey == null)
					return "";
				return virtualGroupKey;
			}
			set {
				virtualGroupKey = value;
			}
		}
		[XmlElement(Type = typeof(DemoPageModel), ElementName = "Demo")]
		public List<DemoPageModel> Demos {
			get { return _demos; }
		}
		public List<DemoPageModel> GetVisibleDemos() {
			return Demos.Where(d => !d.HideNavItem).ToList();
		}
		public List<DemoPageModel> GetAllDemos(bool onlyVisible) {
			List<DemoPageModel> result = new List<DemoPageModel>();
			if (onlyVisible)
				result.AddRange(GetVisibleDemos());
			else
				result.AddRange(Demos);
			return result;
		}
		[XmlIgnore]
		public DemoProductModel Product { get; set; }
	}
}
