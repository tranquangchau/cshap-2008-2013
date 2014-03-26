/*
    MediaException class for C#
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

namespace Org.Mentalis.Multimedia {
	/// <summary>
	/// The exception that is thrown when an error occurs while opening, playing or modifying a media file.
	/// </summary>
	public class MediaException : Exception {
		/// <summary>Constructs a new MediaException object.</summary>
		/// <param name="Message">Specifies the error message.</param>
		public MediaException(string Message) : base(Message) {}
		/// <summary>Constructs a new MediaException object.</summary>
		/// <remarks>The message will be set to <em>'An error occured while accessing the media file.'</em></remarks>
		public MediaException() : base("An error occured while accessing the media file.") {}
		/// <summary>Returns a string representation of this object.</summary>	
		/// <returns>A string representation of this MediaException.</returns>
		public override string ToString() {
			return "MediaException: " + Message + " " + StackTrace;
		}
	}
}