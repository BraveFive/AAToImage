using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AAToImage
{
	class TextToImage
	{
		private static readonly FileType[] _fileTypes = new[]
		{
			new FileType(ImageFormat.Jpeg, "jpg"),
			new FileType(ImageFormat.Gif, "gif"),
			new FileType(ImageFormat.Png, "png"),
			new FileType(ImageFormat.Bmp, "bmp"),
		};
		public static readonly IReadOnlyCollection<FileType> FileTypes = new ReadOnlyCollection<FileType>(_fileTypes);
		private readonly PrivateFontCollection pfc;
		private readonly Font FONT ;

		public string Source { get; set; }
		public bool ConvertAll { get; set; }
		public string Dest { get; set; }
		public string FileName { get; set; } = "yaruo";
		public FileType Type { get; set; }
		public bool UseOriginName { get; set; }

		private int startNumber;
		public int StartNumber
		{
			get { return startNumber; }
			set { startNumber = value; StartNumberString = $"_{startNumber:0000}"; }
		}
		public string StartNumberString { get; private set; }

		private int number;

		public TextToImage()
		{
			pfc = new PrivateFontCollection();
			pfc.AddFontFile("aahub.ttf");

			FONT = new Font(pfc.Families[0], 16.0f, GraphicsUnit.Pixel);
		}

		public void Save()
		{
			if (ConvertAll)
			{
				if (Directory.Exists(Source))
				{
					foreach (var file in Directory.EnumerateFiles(Source).Where((path)=>Regex.Match(path, @".+\.(mlt|ast)").Success))
					{
						Save(file);
					}
				}
			}
			else
			{
				if (File.Exists(Source))
				{
					Save(Source);
				}
			}
		}

		private void Save(string sourcePath)
		{
			if (!Directory.Exists(Dest))
			{
				return;
			}

			var name = UseOriginName ? Path.GetFileNameWithoutExtension(sourcePath) : FileName;
			if (Regex.IsMatch(name, @"[\\\/\:\*\?\""\<\>\|]"))
			{
				return;
			}

			number = StartNumber;
			using (var read = GetReader(sourcePath))
			{
				SaveImagesFromFile(read, name);
			}
		}

		private StreamReader GetReader(string sourcePath)
			=> File.Exists(sourcePath) ? new StreamReader(sourcePath, Encoding.GetEncoding("Shift-JIS")) : null;

		private void SaveImagesFromFile(StreamReader read, string name)
		{
			var sb = new StringBuilder();
			var lineNum = 0;
			do
			{
				var line = read.ReadLine();
				if (!Regex.Match(line, @"^\[(AA|SPLIT)\]").Success)
				{
					sb.AppendLine(line);
					++lineNum;
				}
				else if (sb.Length > 0)
				{
					SaveImage(sb.ToString(), name, lineNum);

					sb.Clear();
					lineNum = 0;
					++number;
				}
				GC.Collect();
			} while (!read.EndOfStream);

			if (sb.Length > 0)
			{
				SaveImage(sb.ToString(), name, lineNum);
			}
		}

		private void SaveImage(string s, string name, int lineNum)
		{
			s = System.Net.WebUtility.HtmlDecode(s);

			using (var sf = new StringFormat(StringFormat.GenericTypographic))
			{
				var size = new SizeF(0, FONT.Height * lineNum + 2);
				using (var imgTmp = new Bitmap(5000, (int)size.Height))
				using (var gTmp = Graphics.FromImage(imgTmp))
				{
					var strs = s.Split('\n');
					foreach (var str in strs)
					{
						var w = gTmp.MeasureString(str.Trim(), FONT).Width;
						if (size.Width < w)
						{
							size.Width = w;
						}
					}
				}

				using (var image = new Bitmap((int)size.Width, (int)size.Height))
				using (var g = Graphics.FromImage(image))
				{
					g.FillRectangle(Brushes.White, 0.0f, 0.0f, image.Width, image.Height);
					g.DrawString(s, FONT, Brushes.Black, 0.0f, 0.0f, sf);
					//g.ScaleTransform(0.9f, 0.9f);

					ImageCodecInfo ici = null;
					foreach (var info in ImageCodecInfo.GetImageEncoders())
					{
						if (info.FormatID == Type.Format.Guid)
						{
							ici = info;
						}
					}
					var eparams = new EncoderParameters(1);
					eparams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L);

					image.Save($"{Dest}\\{name}_{number:0000}.{Type.Ext}", ici, eparams);
				}
			}
		}
	}

	class FileType
	{
		public readonly ImageFormat Format;
		public readonly string Ext;

		public FileType(ImageFormat format, string ext)
			=> (Format, Ext) = (format, ext);
	}
}
