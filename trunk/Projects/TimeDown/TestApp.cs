using System;
using System.Drawing;
using System.Windows.Forms;
using Org.Mentalis.Multimedia;

public class TestApp {
	public static void Main() {
		TestApp test = new TestApp();
		test.Start();
	}
	public void Start() {
		WriteOptions();
		string input = Console.ReadLine();
		string si;
		while(!input.ToLower().Equals("q")) {
			Console.WriteLine();
			try {
				switch(input.ToLower()) {
					case "m":
						LoadMusicFile();
						break;
					case "v":
						LoadVideoFile(null);
						break;
					case "w":
						LoadVideoOwnerFile();
						break;
					case "c":
						mediaFile.Dispose();
						break;
					case "p":
						mediaFile.Play();
						break;
					case "s":
						mediaFile.Stop();
						break;
					case "a":
						mediaFile.Paused = !mediaFile.Paused;
						break;
					case "l":
						Console.WriteLine("Length=" + mediaFile.Length.ToString() + "ms.");
						break;
					case "d":
						Console.Write("Enter the new playback speed (a number between 0 and 2267): ");
						si = Console.ReadLine();
						mediaFile.PlaybackSpeed = int.Parse(si);
						break;
					case "u":
						Console.Write("Enter the new volume (a number between 0 and 1000): ");
						si = Console.ReadLine();
						mediaFile.Volume = int.Parse(si);
						break;
					case "o":
						Console.WriteLine("Position=" + mediaFile.Position.ToString() + "ms.");
						break;
					case "n":
						Console.WriteLine("Volume=" + mediaFile.Volume.ToString());
						break;
					case "t":
						Console.WriteLine("Status=" + mediaFile.Status.ToString());
						break;
					case "r":
						Console.WriteLine("Enter the new dimensions of the window (left, top, width, height), seperated by spaces\r\n eg:   0 0 640 480");
						si = Console.ReadLine();
						if (si != "") {
							string [] parts = si.Split();
							if (parts.Length != 4)
								throw new Exception("User Error: Intelligence Resource Level Insufficient");
							((VideoFile)mediaFile).OutputRect = new Rectangle(int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
						}
						break;
					default:
						Console.WriteLine("Command not understood :(");
						break;
				}
			} catch (Exception e) {
				Console.WriteLine("An error occured: " + e.Message);
			}
			WriteOptions();
			input = Console.ReadLine();
		}
	}
	protected void WriteOptions() {
		Console.Write("\r\n Multimedia Test Application - Options\r\n" + 
						" -------------------------------------\r\n\r\n" +
						"   m - Load a new music file\r\n" +
						"   v - Load a new video file\r\n" +
						"   w - Load a new video file in an owner window\r\n" +
						"   p - Play the media file\r\n" +
						"   s - Stop the media file\r\n" +
						"   a - Pause/unpause the media file\r\n" +
						"   d - Adjust the playback speed\r\n" +
						"   u - Adjust the volume of the media file\r\n" +
						"   r - Resize the video playback window\r\n" +
						"   l - Print the length of the media file\r\n" +
						"   o - Print the position of the media file\r\n" +
						"   t - Print the status of the media file\r\n" +
						"   n - Print the volume of the media file\r\n" +
						"   c - Close the loaded media file\r\n" +
						"   q - Quit the test application\r\n\r\n" +
						"  Choose an option: "
					  );
	}
	protected void LoadMusicFile() {
		Console.WriteLine("Please enter the filename of the music file you want to load:\r\n (this can be any music type your system supports, for instance WAVE, MIDI, MP3, ...)");
		string file = Console.ReadLine();
		if (file != null && file != "") {
			mediaFile = new SoundFile(file);
		}
	}
	protected void LoadVideoOwnerFile() {
		if (parent != null)
			parent.Dispose();
		parent = new MovieForm();
		parent.Text = "My C# form!";
		parent.Show();
		LoadVideoFile(parent);
	}
	protected void LoadVideoFile(IWin32Window owner) {
		Console.WriteLine("Please enter the filename of the video file you want to load:\r\n (this can be any video type your system supports, for instance AVI, MPEG, DivX, ...)");
		string file = Console.ReadLine();
		if (file != null && file != "") {
			mediaFile = new VideoFile(file, owner);
		}
	}
	private MovieForm parent;
	private MediaFile mediaFile;
}

public class MovieForm : Form {
	private void InitializeComponent() {
		this.ClientSize = new System.Drawing.Size(640, 480);
		this.Name = "MovieForm";
	}
}