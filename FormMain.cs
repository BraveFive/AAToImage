using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAToImage
{
	public partial class FormMain : Form
	{
		private readonly (string Display, string Value) MEMBER = ("Display", typeof(FileType).Name);
		private readonly Dictionary<bool, (string Category, CommonDialog Dialog)> openTypes;

		private TextToImage textToImage = new TextToImage();
		private CommonDialog openDialog;

		public FormMain()
		{
			InitializeComponent();

			openTypes = new Dictionary<bool, (string, CommonDialog)>
			{
				{ false, ("元ファイル", openFileDialogSource) },
				{ true, ("元フォルダ", folderBrowserDialogSource) },
			};
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			var table = new DataTable() { Columns =
				{
					{ MEMBER.Display, typeof(string) },
					{ MEMBER.Value, typeof(FileType) },
				} };
			foreach (var type in TextToImage.FileTypes)
			{
				table.Rows.Add($"{type.Format} (.{type.Ext})", type);
			}
			comboBoxImage.DataSource = table;
			comboBoxImage.DisplayMember = MEMBER.Display;
			comboBoxImage.ValueMember = MEMBER.Value;
			comboBoxImage.SelectedIndex = 0;

			textBoxName.Text = textToImage.FileName;
			SetOpenDialog(checkBoxAll);
			SetFileType(comboBoxImage);
		}

		private void ButtonSource_Click(object sender, EventArgs e)
		{
			if (openDialog.ShowDialog() == DialogResult.OK)
			{
				switch (openDialog)
				{
					case OpenFileDialog fileDialog:
						textBoxSource.Text = fileDialog.FileName;
						break;
					case FolderBrowserDialog folderDialog:
						textBoxSource.Text = folderDialog.SelectedPath;
						break;
					default:
						break;
				}
			}
		}

		private void CheckBoxAll_CheckedChanged(object sender, EventArgs e)
		{
			SetOpenDialog(sender as CheckBox);
		}

		private void ButtonDest_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialogDest.ShowDialog() == DialogResult.OK)
			{
				textBoxDest.Text = folderBrowserDialogDest.SelectedPath;
			}
		}

		private void CheckBoxStartNum_CheckedChanged(object sender, EventArgs e)
		{
			textToImage.StartNumber = (sender as CheckBox).Checked ? 0 : 1;
			labelNumber.Text = textToImage.StartNumberString;
		}

		private void ComboBoxImage_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (sender is ComboBox cb)
			{
				SetFileType(cb);
			}
		}

		private void ButtonSave_Click(object sender, EventArgs e)
		{
			textToImage.Source = textBoxSource.Text;
			textToImage.ConvertAll = checkBoxAll.Checked;
			textToImage.Dest = textBoxDest.Text;
			textToImage.FileName = textBoxName.Text;
			textToImage.UseOriginName = checkBoxOriginName.Checked;

			textToImage.Save();
		}

		private void SetOpenDialog(CheckBox cb)
		{
			if (cb != null)
			{
				var openType = openTypes[cb.Checked];
				labelSource.Text = openType.Category;
				openDialog = openType.Dialog;
			}
		}

		private void SetFileType(ComboBox cb)
		{
			if (cb.SelectedValue is FileType type)
			{
				labelExt.Text = type.Ext;
				textToImage.Type = type;
			}
		}

		private void CheckBoxOriginName_CheckedChanged(object sender, EventArgs e)
		{
			textBoxName.Enabled = !(sender as CheckBox).Checked;
		}

		private void FormMain_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetData(DataFormats.FileDrop, false) is string[] files)
			{
				if (files.Length > 0)
				{
					if (Directory.Exists(files[0]))
					{
						textBoxSource.Text = files[0];
						checkBoxAll.Checked = true;
					}
					else if (File.Exists(files[0]))
					{
						textBoxSource.Text = files[0];
						checkBoxAll.Checked = false;
					}
				}
			}
		}

		private void FormMain_DragEnter(object sender, DragEventArgs e)
			=> e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
	}
}
