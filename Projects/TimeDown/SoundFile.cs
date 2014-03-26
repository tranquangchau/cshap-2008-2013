/*
    SoundFile class for C#
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

namespace Org.Mentalis.Multimedia {
	/// <summary>This class represents any sound file type supported by MCI.</summary>
	/// <remarks>This class should be able to handle at least WAVE and MIDI on any system. Playing MP3s and other formats is also available on most systems.</remarks>
	public class SoundFile : MediaFile {
		/// <summary>
		/// Initializes a new SoundFile object.
		/// </summary>
		/// <param name="file">The sound file to open.</param>
		/// <exception cref="ArgumentNullException">The file parameter is null (Nothing in VB.NET).</exception>
		/// <exception cref="FileNotFoundException">The specified file could not be found.</exception>
		/// <exception cref="MediaException">An error occured while opening the specified file.</exception>
		public SoundFile(string file) : base(file) {
			TimeFormat = "ms";		// use milliseconds
		}
		/// <summary>
		/// Specifies the MCI string that should be used when opening the sound file.
		/// </summary>
		/// <returns>An MCI string that should be used when opening the sound file.</returns>
		protected override string GetOpenString() {
			return "OPEN " + File + " TYPE MPEGVideo ALIAS " + Alias;
		}
	}
}
