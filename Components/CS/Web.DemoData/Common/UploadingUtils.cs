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

using System;
using System.IO;
using System.Web;
using System.Web.Caching;
using System.Web.Configuration;
namespace DevExpress.Web.Demos {
	public static class UploadingUtils {
		const string RemoveTaskKeyPrefix = "DXRemoveTask_";
		public static void RemoveFileWithDelay(string key, string fullPath, int delay) {
			RemoveFileWithDelayInternal(key, fullPath, delay, FileSystemRemoveAction);
		}
		static void FileSystemRemoveAction(string key, object value, CacheItemRemovedReason reason) {
			string fileFullPath = value.ToString();
			if(File.Exists(fileFullPath))
				File.Delete(fileFullPath);
		}
		static void RemoveFileWithDelayInternal(string fileKey, object fileData, int delay, CacheItemRemovedCallback removeAction) {
			string key = RemoveTaskKeyPrefix + fileKey;
			if(HttpRuntime.Cache[key] == null) {
				DateTime absoluteExpiration = DateTime.UtcNow.Add(new TimeSpan(0, delay, 0));
				HttpRuntime.Cache.Insert(key, fileData, null, absoluteExpiration,
					Cache.NoSlidingExpiration, CacheItemPriority.NotRemovable, removeAction);
			}
		}
	}
}
