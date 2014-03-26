/*
    MediaFile class for C#
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
using System.Windows.Forms;
using System.Runtime.InteropServices;

// <summary>Defines a set of classes that can be used to play media files in any .NET language.</summary>
namespace Org.Mentalis.Multimedia {
	/// <summary>
	/// Defines the different states a media file can be in.
	/// </summary>
	public enum StatusInfo {
		/// <summary>The media file is playing.</summary>
		Playing,
		/// <summary>The media file is paused.</summary>
		Paused,
		/// <summary>The media file is stopped.</summary>
		Stopped,
		/// <summary>The media file status is unknown.</summary>
		Unknown
	}
	/// <summary>
	/// An abstract base class that defines methods that should be available for any MCI file type.
	/// </summary>
	public abstract class MediaFile : IDisposable {
		/// <summary>
		/// The mciSendString function sends a command string to an MCI device. The device that the command is sent to is specified in the command string.
		/// </summary>
		/// <param name="lpstrCommand">Address of a null-terminated string that specifies an MCI command string.</param>
		/// <param name="lpstrReturnString">Address of a buffer that receives return information. If no return information is needed, this parameter can be null (Nothing in VB.NET).</param>
		/// <param name="uReturnLength">Size, in characters, of the return buffer specified by the lpszReturnString parameter.</param>
		/// <param name="hwndCallback">Handle of a callback window if the notify flag was specified in the command string.</param>
		/// <returns>Returns zero if successful or an error otherwise. The low-order word of the returned doubleword value contains the error return value. If the error is device-specific, the high-order word of the return value is the driver identifier; otherwise, the high-order word is zero.<br>To retrieve a text description of mciSendString return values, pass the return value to the mciGetErrorString function.</br></returns>
		[ DllImport( "winmm.dll", EntryPoint="mciSendStringA", CharSet=CharSet.Ansi )]
		protected static extern int mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, IntPtr hwndCallback);
		/// <summary>
		/// The mciGetErrorString function retrieves a string that describes the specified MCI error code.
		/// </summary>
		/// <param name="dwError">Error code returned by the mciSendCommand or mciSendString function.</param>
		/// <param name="lpstrBuffer">Address of a buffer that receives a null-terminated string describing the specified error.</param>
		/// <param name="uLength">Length of the buffer, in characters, pointed to by the lpszErrorText parameter.</param>
		/// <returns>Returns TRUE if successful or FALSE if the error code is not known.</returns>
		[ DllImport( "winmm.dll", EntryPoint="mciGetErrorStringA", CharSet=CharSet.Ansi )]
		protected static extern int mciGetErrorString(int dwError, StringBuilder lpstrBuffer, int uLength);
		/// <summary>
		/// The GetShortPathName function obtains the short path form of a specified input path.
		/// </summary>
		/// <param name="lpszLongPath">Pointer to a null-terminated path string. The function obtains the short form of this path.</param>
		/// <param name="lpszShortPath">Pointer to a buffer to receive the null-terminated short form of the path specified by lpszLongPath.</param>
		/// <param name="cchBuffer">Specifies the size, in characters, of the buffer pointed to by lpszShortPath.</param>
		/// <returns>If the function succeeds, the return value is the length, in characters, of the string copied to lpszShortPath, not including the terminating null character.<br>If the function fails due to the lpszShortPath buffer being too small to contain the short path string, the return value is the size, in characters, of the short path string. You need to call the function with a short path buffer that is at least as large as the short path string.</br><br>If the function fails for any other reason, the return value is zero. To get extended error information, call GetLastError.</br></returns>
		[ DllImport( "kernel32.dll", EntryPoint="GetShortPathNameA", CharSet=CharSet.Ansi )]
		protected static extern int GetShortPathName(string lpszLongPath, StringBuilder lpszShortPath, int cchBuffer);
		/// <summary>
		/// Initializes a new instance of the MediaFile class.
		/// </summary>
		/// <param name="file">The media file to open.</param>
		/// <exception cref="ArgumentNullException">The file parameter is null (Nothing in VB.NET).</exception>
		/// <exception cref="FileNotFoundException">The specified file could not be found.</exception>
		/// <exception cref="MediaException">An error occured while opening the specified file.</exception>
		public MediaFile(string file) : this(file, null) {}
		/// <summary>
		/// Initializes a new instance of the MediaFile class.
		/// </summary>
		/// <param name="file">The media file to open.</param>
		/// <param name="owner">The owner of the media file.</param>
		/// <exception cref="ArgumentNullException">The file parameter is null (Nothing in VB.NET).</exception>
		/// <exception cref="FileNotFoundException">The specified file could not be found.</exception>
		/// <exception cref="MediaException">An error occured while opening the specified file.</exception>
		/// <remarks>The <c>owner</c> parameter can be set to null (Nothing in VB.NET).</remarks>
		public MediaFile(string file, IWin32Window owner) {
			if (file == null)
				throw new ArgumentNullException("Parameter 'file' cannot be null!");
			if (!System.IO.File.Exists(file))
				throw new FileNotFoundException();
			Owner = owner;
			Open(file);
		}
		/// <summary>
		/// Converts a long path into a short path.
		/// </summary>
		/// <param name="file">The long path to convert.</param>
		/// <returns>The short path -or- an empty string (="") if an error occurs.</returns>
		protected string GetShortPath(string file) {
			StringBuilder buffer = new StringBuilder(file.Length + 1);
			int ret = GetShortPathName(file, buffer, buffer.Capacity);
			if (ret == 0)		// Error
				return "";
			else				// Success
				return buffer.ToString();
		}
		/// <summary>
		/// Gets the filename of the media file.
		/// </summary>
		/// <value>A string containing the full path of the media file.</value>
		public string Filename {
			get{
				return m_File;
			}
		}
		/// <summary>
		/// Specifies the MCI string that should be used when opening the media file.
		/// </summary>
		/// <returns>An MCI string that should be used when opening the media file.</returns>
		/// <remarks>Since this string depends on the media type, this method must be overridden in subclasses.</remarks>
		protected abstract string GetOpenString();
		/// <summary>
		/// Opens the specified media file and creates an Alias for it.
		/// </summary>
		/// <param name="file">The file to open.</param>
		protected void Open(string file) {
			m_File = GetShortPath(file);
			Alias = Guid.NewGuid().ToString("N");
			int ret;
			ret = mciSendString(GetOpenString(), null, 0, IntPtr.Zero);
			if (ret != 0)
				throw new MediaException(GetMciError(ret));
		}
		/// <summary>
		/// Converts an MCI error code into a string.
		/// </summary>
		/// <param name="errorCode">The error code to convert.</param>
		/// <returns>A string representation of the specified error code -or- an empty string (="") when an error occurs.</returns>
		protected string GetMciError(int errorCode) {
			StringBuilder buffer = new StringBuilder(255);
			if (mciGetErrorString(errorCode, buffer, buffer.Capacity) == 0)
				return "";
			return buffer.ToString();
		}
		/// <summary>
		/// Disposes of the unmanaged resources (other than memory) used by the MediaFile object.
		/// </summary>
		public void Dispose() {
			if (Disposed)
				return;
			mciSendString("CLOSE " + Alias, null, 0, IntPtr.Zero);
			m_Disposed = true;
		}
		/// <summary>
		/// Specifies the MCI string that should be used when playing the media file.
		/// </summary>
		/// <param name="from">The start position from where to play (measured in milliseconds).</param>
		/// <param name="length">The length (measured in milliseconds) of the media to play.</param>
		/// <returns>An MCI string that should be used when playing the media file.</returns>
		protected string GetPlayString(int from, int length) {
			string ret = "PLAY " + Alias + " FROM " + from.ToString() + " TO " + (from + length).ToString();
			if (Repeat)
				ret += " REPEAT";
			return ret;
		}
		/// <summary>
		/// Starts playing a file.
		/// </summary>
		/// <exception cref="MediaException">An error occured when starting playing the file.</exception>
		public void Play() {
			Play(0);
		}
		/// <summary>
		/// Starts playing a file.
		/// </summary>
		/// <param name="from">The start position from where to play (measured in milliseconds).</param>
		/// <exception cref="MediaException">An error occured when starting playing the file.</exception>
		public void Play(int from) {
			Play(from, Length - from);
		}
		/// <summary>
		/// Starts playing a file.
		/// </summary>
		/// <param name="from">The start position from where to play (measured in milliseconds).</param>
		/// <param name="length">The length (measured in milliseconds) of the media to play.</param>
		/// <exception cref="MediaException">An error occured while starting playing the file.</exception>
		public void Play(int from, int length) {
			if (from < 0 || length > Length || Length < 0 || from + length > Length)
				throw new ArgumentException("Invalid parameter(s) specified.");
			int ret = mciSendString(GetPlayString(from, length), null, 0, IntPtr.Zero);
			if (ret != 0)
				throw new MediaException(GetMciError(ret));
		}
		/// <summary>
		/// Stops playing a file and rewinds.
		/// </summary>
		/// <exception cref="MediaException">An error occured while stopping the file.</exception>
		public void Stop() {
			int ret = mciSendString("STOP " + Alias, null, 0, IntPtr.Zero);
			if (ret != 0)
				throw new MediaException(GetMciError(ret));
		}
		/// <summary>
		/// Gets whether the object has been disposed or not.
		/// </summary>
		/// <value>True if the object has been disposed, false otherwise.</value>
		public bool Disposed {
			get{
				return m_Disposed;
			}
		}
		/// <summary>
		/// Gets or sets the paused state of the media file.
		/// </summary>
		/// <value>A boolean specifying whether the media file is paused or not.</value>
		/// <exception cref="MediaException">An error occured while accessing the media.</exception>
		public bool Paused {
			get {
				return Status == StatusInfo.Paused;
			}
			set {
				if (value != Paused) {
					int ret;
					if (value) {			// PAUSE
						ret = mciSendString("PAUSE " + Alias, null, 0, IntPtr.Zero);
						if (ret != 0)
							throw new MediaException(GetMciError(ret));
					} else {				// RESUME
						ret = mciSendString("RESUME " + Alias, null, 0, IntPtr.Zero);
						if (ret != 0)
							throw new MediaException(GetMciError(ret));
					}
				}
			}
		}
		/// <summary>
		/// Gets the status of the media file.
		/// </summary>
		/// <value>One of the StatusInfo values.</value>
		/// <exception cref="MediaException">An error occured while accessing the media.</exception>
		public StatusInfo Status {
			get{
				StringBuilder buffer = new StringBuilder(255);
				int ret = mciSendString("STATUS " + Alias + " MODE", buffer, buffer.Capacity, IntPtr.Zero);
				if (ret != 0) {
					return StatusInfo.Unknown;
				} else {
					switch (buffer.ToString().ToLower()) {
						case "playing":
							return StatusInfo.Playing;
						case "paused":
							return StatusInfo.Paused;
						case "stopped":
							return StatusInfo.Stopped;
						default:
							return StatusInfo.Unknown;
					}
				}
			}
		}
		/// <summary>
		/// Gets or sets the time format to use.
		/// </summary>
		/// <value>A string specifying the time format that has to be used.</value>
		/// <remarks>This value can be 'ms' for milliseconds or 'frames' for frames (however 'frames' is not supported on all media types).</remarks>
		/// <exception cref="ArgumentNullException">The specified value is null (Nothing in VB.NET).</exception>
		/// <exception cref="MediaException">An error occured while accessing the media.</exception>
		protected string TimeFormat {
			get {
				return m_TimeFormat;
			}
			set {
				if (value == null)
					throw new ArgumentNullException();
				int ret = mciSendString("SET " + Alias + " TIME FORMAT " + value, null, 0, IntPtr.Zero);
				if (ret != 0)
					throw new MediaException(GetMciError(ret));
				m_TimeFormat = value;
			}
		}
		/// <summary>
		/// Gets the length of the file.
		/// </summary>
		/// <value>An integer that holds the length of the file.</value>
		/// <remarks>The length is measured in milliseconds.</remarks>
		/// <exception cref="MediaException">An error occured while accessing the media.</exception>
		public int Length {
			get{
				StringBuilder buffer = new StringBuilder(260);
				int ret = mciSendString("STATUS " + Alias + " LENGTH", buffer, buffer.Capacity, IntPtr.Zero);
				if (ret != 0)
					throw new MediaException(GetMciError(ret));
				return int.Parse(buffer.ToString());
			}
		}
		/// <summary>
		/// Gets or sets the position in the media file.
		/// </summary>
		/// <value>An integer that specifies the position in the media file.</value>
		/// <exception cref="MediaException">An error occured while accessing the media.</exception>
		/// <remarks>The position is measured in milliseconds.</remarks>
		public int Position {
			get {
				StringBuilder buffer = new StringBuilder(260);
				int ret = mciSendString("STATUS " + Alias + " POSITION", buffer, buffer.Capacity, IntPtr.Zero);
				if (ret != 0)
					throw new MediaException(GetMciError(ret));
				return int.Parse(buffer.ToString());
			}
			set {
				bool playing = (this.Status == StatusInfo.Playing);
				int ret = mciSendString("SEEK " + Alias + " TO " + value.ToString(), null, 0, IntPtr.Zero);
				if (ret != 0)
					throw new MediaException(GetMciError(ret));
				if (playing) {
					ret = mciSendString("SEEK " + Alias + " TO " + value.ToString(), null, 0, IntPtr.Zero);
					if (ret != 0)
						throw new MediaException(GetMciError(ret));
				}
			}
		}
		/// <summary>
		/// Gets or sets the volume of the sound of the media file.
		/// </summary>
		/// <value>An integer that specifies the volume of the sound of the media file.</value>
		/// <exception cref="MediaException">An error occured while accessing the media.</exception>
		public int Volume {
			get{
				StringBuilder buffer = new StringBuilder(260);
				int ret = mciSendString("STATUS " + Alias + " VOLUME", buffer, buffer.Capacity, IntPtr.Zero);
				if (ret != 0)
					throw new MediaException(GetMciError(ret));
				return int.Parse(buffer.ToString());
			}
			set{
				int ret = mciSendString("SETAUDIO " + Alias + " VOLUME TO " + value.ToString(), null, 0, IntPtr.Zero);
				if (ret != 0)
					throw new MediaException(GetMciError(ret));
			}
		}
		/// <summary>
		/// Gets or sets the playback speed of the media file.
		/// </summary>
		/// <value>An integer that specifies the playback speed of the media file.</value>
		public int PlaybackSpeed {
			get {
				return m_PlaybackSpeed;
			}
			set{
				int ret = mciSendString("SET " + Alias + " SPEED " + value.ToString(), null, 0, IntPtr.Zero);
				if (ret != 0)
					throw new MediaException(GetMciError(ret));
				m_PlaybackSpeed = value;
			}
		}
		/// <summary>
		/// Gets or sets the alias of the media file.
		/// </summary>
		/// <value>A string that holds the alias of the media file.</value>
		protected string Alias {
			get{
				return m_Alias;
			}
			set{
				m_Alias = value;
			}
		}
		/// <summary>
		/// Gets the full path of the media file.
		/// </summary>
		/// <value>A string that holds the full path of the media file.</value>
		public string File {
			get {
				return m_File;
			}
		}
		/// <summary>
		/// Gets or sets the owner window of this media file.
		/// </summary>
		/// <value>An instance of an IWin32Window object that's the parent of the media file.</value>
		protected IWin32Window Owner {
			get {
				return m_Owner;
			}
			set {
				m_Owner = value;
			}
		}
		/// <summary>
		/// Gets or sets whether the file should be repeated when it has reached the end.
		/// </summary>
		/// <value>A boolean that specifies whether the file should be repeated when it has reached the end.</value>
		public bool Repeat {
			get {
				return m_Repeat;
			}
			set {
				m_Repeat = value;
			}
		}
		/// <summary>
		/// Destructs the MediaFile object by calling the Dispose method.
		/// </summary>
		~MediaFile() {
			Dispose();
		}
		// private variables
		/// <summary>Holds the value of the Owner property.</summary>
		private IWin32Window m_Owner;
		/// <summary>Holds the value of the File property.</summary>
		private string m_File;
		/// <summary>Holds the value of the Alias property.</summary>
		private string m_Alias;
		/// <summary>Holds the value of the Disposed property.</summary>
		private bool m_Disposed;
		/// <summary>Holds the value of the TimeFormat property.</summary>
		private string m_TimeFormat;
		/// <summary>Holds the value of the PlaybackSpeed property.</summary>
		private int m_PlaybackSpeed = 100;
		/// <summary>Holds the value of the Repeat property.</summary>
		private bool m_Repeat = false;
	}
}
