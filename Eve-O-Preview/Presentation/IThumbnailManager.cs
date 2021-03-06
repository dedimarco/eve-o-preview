﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace EveOPreview.UI
{
	public interface IThumbnailManager
	{
		void Activate();
		void Deactivate();

		void SetThumbnailState(IntPtr thumbnailId, bool hideAlways);
		void SetThumbnailsSize(Size size);
		void SetupThumbnailFrames();

		Action<IList<IThumbnailView>> ThumbnailsAdded { get; set; }
		Action<IList<IThumbnailView>> ThumbnailsUpdated { get; set; }
		Action<IList<IThumbnailView>> ThumbnailsRemoved { get; set; }
		Action<Size> ThumbnailSizeChanged { get; set; }
	}
}