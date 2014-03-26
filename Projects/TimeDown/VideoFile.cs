/*
    VideoFile class for C#
		Version: 1.0		Date: 2002/04/09
*/
/*
    Copyright © 2002, The KPD-Team
    All rights reserved.
    http://www.mentalis.org/

  Redistribution and use in source and binary forms, with or without
  modification, are permitted provided that the following conditions
  are met:

    - Redistributions of source code must retain the above copyright
       notice, this list of conditions and the following disclaimer. 

    - Neither the name of the KPD-Team, nor the names of its contributors
       may be used to endorse or promote products derived from this
       software without specific prior written permission. 

  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
  "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
  LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS
  FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL
  THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT,
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
  (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
  SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
  HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT,
  STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED
  OF THE POSSIBILITY OF SUCH DAMAGE.
*/

using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Org.Mentalis.Multimedia {
	/// <summary>This class represents any video file type supported by MCI.</summary>
	/// <remarks>This class should be able to handle at least AVI on any system. Playing MPEG, DivX and other formats is also available on most systems.</remarks>
	public class VideoFile : MediaFile {
		/// <summary>
		/// Initializes a new VideoFile object.
		/// </summary>
		/// <param name="file">The video file to open.</param>
		/// <exception cref="ArgumentNullException">The file parameter is null (Nothing in VB.NET).</exception>
		/// <exception cref="FileNotFoundException">The specified file could not be found.</exception>
		/// <exception cref="MediaException">An error occured while opening the specified file.</exception>
		public VideoFile(string file) : this(file, null) {}
		/// <summary>
		/// Initializes a new VideoFile object.
		/// </summary>
		/// <param name="file">The video file to open.</param>
		/// <param name="owner">The window to play the movie in. This parameter can be null (Nothing in VB.NET).</param>
		/// <exception cref="ArgumentNullException">The file parameter is null (Nothing in VB.NET).</exception>
		/// <exception cref="FileNotFoundException">The specified file could not be found.</exception>
		/// <exception cref="MediaException">An error occured while opening the specified file.</exception>
		/// <remarks>If the owner is set to null (Nothing in VB.NET), MCI will create a new window and play the movie on top of that one.</remarks>
		public VideoFile(string file, IWin32Window owner) : base(file, owner) {
			TimeFormat = "ms";		// use milliseconds
		}
		/// <summary>
		/// Specifies the MCI string that should be used when opening the video file.
		/// </summary>
		/// <returns>An MCI string that should be used when opening the video file.</returns>
		protected override string GetOpenString() {
			if (Owner == null)
				return "OPEN " + File + " TYPE MPEGVideo ALIAS " + Alias;
			else
				return "OPEN " + File + " TYPE MPEGVideo ALIAS " + Alias + " PARENT " + Owner.Handle.ToInt64().ToString() + " STYLE child";
		}
		/// <summary>
		/// Gets or sets the width of the client area on the destination window.
		/// </summary>
		/// <value>An integer that specifies the width of the destination window.</value>
		/// <exception cref="MediaException">The specified value is invalid -or- there was an error querying the media file.</exception>
		public int Width {
			get {
				return OutputRect.Width;
			}
			set {
				Rectangle output = OutputRect;
				OutputRect = new Rectangle(output.X, output.Y, value, output.Height);
			}
		}
		/// <summary>
		/// Gets or sets the height of the client area on the destination window.
		/// </summary>
		/// <value>An integer that specifies the height of the destination window.</value>
		/// <exception cref="MediaException">The specified value is invalid -or- there was an error querying the media file.</exception>
		public int Height {
			get {
				return OutputRect.Height;
			}
			set {
				Rectangle output = OutputRect;
				OutputRect = new Rectangle(output.X, output.Y, output.Width, value);
			}
		}
		/// <summary>
		/// Gets or sets the left position of the client area on the destination window.
		/// </summary>
		/// <value>An integer that specifies the left position on the destination window.</value>
		/// <exception cref="MediaException">The specified value is invalid -or- there was an error querying the media file.</exception>
		public int Left {
			get {
				return OutputRect.X;
			}
			set {
				Rectangle output = OutputRect;
				OutputRect = new Rectangle(value, output.Y, output.Width, output.Height);
			}
		}
		/// <summary>
		/// Gets or sets the top position of the client area on the destination window.
		/// </summary>
		/// <value>An integer that specifies the top position of the destination window.</value>
		/// <exception cref="MediaException">The specified value is invalid -or- there was an error querying the media file.</exception>
		public int Top {
			get {
				return OutputRect.Y;
			}
			set {
				Rectangle output = OutputRect;
				OutputRect = new Rectangle(output.X, value, output.Width, output.Height);
			}
		}
		/// <summary>
		/// Gets or sets the width and the height of the client area on the destination window.
		/// </summary>
		/// <value>A Size instance that holds the width and height of the client area on the destination window.</value>
		/// <exception cref="MediaException">The specified value is invalid -or- there was an error querying the media file.</exception>
		public Size Size {
			get {
				Rectangle output = OutputRect;
				return new Size(OutputRect.Width, OutputRect.Height);
			}
			set {
				Rectangle output = OutputRect;
				OutputRect = new Rectangle(output.X, output.Y, value.Width, value.Height);
			}
		}
		/// <summary>
		/// Gets or sets the left and top position of the client area on the destination window.
		/// </summary>
		/// <value>A Point instance that holds the left and top of the client area on the destination window.</value>
		/// <exception cref="MediaException">The specified value is invalid -or- there was an error querying the media file.</exception>
		public Point Location {
			get {
				Rectangle output = OutputRect;
				return new Point(OutputRect.Left, OutputRect.Top);
			}
			set {
				Rectangle output = OutputRect;
				OutputRect = new Rectangle(value.X, value.Y, output.Width, output.Height);
			}
		}
		/// <summary>
		/// Gets or sets the left, top, width and height values of the client area on the destination window.
		/// </summary>
		/// <value>A Rectangle instance that holds the left, top, width and height values of the client area on the destination window.</value>
		/// <exception cref="MediaException">The specified value is invalid -or- there was an error querying the media file.</exception>
		public Rectangle OutputRect {
			get {
				StringBuilder buffer = new StringBuilder(255);
				int ret = mciSendString("WHERE " + Alias + " DESTINATION", buffer, buffer.Capacity, IntPtr.Zero);
				if (ret != 0)
					throw new MediaException(GetMciError(ret));
				try {
					string [] parts = buffer.ToString().Split(' ');
					return new Rectangle(int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]) - int.Parse(parts[0]), int.Parse(parts[3]) - int.Parse(parts[1]));
				} catch {
					throw new MediaException("Unrecognized MCI reply.");
				}
			}
			set {
				int ret = mciSendString("PUT " + Alias + " WINDOW AT " + value.X.ToString() + " " + value.Y.ToString() + " " + (value.Width).ToString() + " " + (value.Height).ToString(), null, 0, IntPtr.Zero);
				if (ret != 0)
					throw new MediaException(GetMciError(ret));
			}
		}
	}
}
