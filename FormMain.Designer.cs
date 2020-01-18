namespace AAToImage
{
	partial class FormMain
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxSource = new System.Windows.Forms.TextBox();
			this.labelSource = new System.Windows.Forms.Label();
			this.buttonSource = new System.Windows.Forms.Button();
			this.labelDest = new System.Windows.Forms.Label();
			this.textBoxDest = new System.Windows.Forms.TextBox();
			this.buttonDest = new System.Windows.Forms.Button();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.labelNumber = new System.Windows.Forms.Label();
			this.checkBoxStartNum = new System.Windows.Forms.CheckBox();
			this.comboBoxImage = new System.Windows.Forms.ComboBox();
			this.labelExt = new System.Windows.Forms.Label();
			this.labelImage = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.checkBoxAll = new System.Windows.Forms.CheckBox();
			this.openFileDialogSource = new System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialogSource = new System.Windows.Forms.FolderBrowserDialog();
			this.folderBrowserDialogDest = new System.Windows.Forms.FolderBrowserDialog();
			this.checkBoxOriginName = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// textBoxSource
			// 
			this.textBoxSource.Location = new System.Drawing.Point(92, 12);
			this.textBoxSource.Name = "textBoxSource";
			this.textBoxSource.Size = new System.Drawing.Size(606, 19);
			this.textBoxSource.TabIndex = 2;
			// 
			// labelSource
			// 
			this.labelSource.AutoSize = true;
			this.labelSource.Location = new System.Drawing.Point(11, 15);
			this.labelSource.Name = "labelSource";
			this.labelSource.Size = new System.Drawing.Size(51, 12);
			this.labelSource.TabIndex = 3;
			this.labelSource.Text = "元ファイル";
			// 
			// buttonSource
			// 
			this.buttonSource.AutoSize = true;
			this.buttonSource.Location = new System.Drawing.Point(704, 12);
			this.buttonSource.Name = "buttonSource";
			this.buttonSource.Size = new System.Drawing.Size(67, 22);
			this.buttonSource.TabIndex = 4;
			this.buttonSource.Text = "指定";
			this.buttonSource.UseVisualStyleBackColor = true;
			this.buttonSource.Click += new System.EventHandler(this.ButtonSource_Click);
			// 
			// labelDest
			// 
			this.labelDest.AutoSize = true;
			this.labelDest.Location = new System.Drawing.Point(11, 62);
			this.labelDest.Name = "labelDest";
			this.labelDest.Size = new System.Drawing.Size(64, 12);
			this.labelDest.TabIndex = 5;
			this.labelDest.Text = "出力フォルダ";
			// 
			// textBoxDest
			// 
			this.textBoxDest.Location = new System.Drawing.Point(92, 59);
			this.textBoxDest.Name = "textBoxDest";
			this.textBoxDest.Size = new System.Drawing.Size(606, 19);
			this.textBoxDest.TabIndex = 6;
			// 
			// buttonDest
			// 
			this.buttonDest.Location = new System.Drawing.Point(704, 57);
			this.buttonDest.Name = "buttonDest";
			this.buttonDest.Size = new System.Drawing.Size(67, 23);
			this.buttonDest.TabIndex = 7;
			this.buttonDest.Text = "指定";
			this.buttonDest.UseVisualStyleBackColor = true;
			this.buttonDest.Click += new System.EventHandler(this.ButtonDest_Click);
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(92, 86);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(230, 19);
			this.textBoxName.TabIndex = 9;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(11, 89);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(75, 12);
			this.labelName.TabIndex = 8;
			this.labelName.Text = "出力ファイル名";
			// 
			// labelNumber
			// 
			this.labelNumber.AutoSize = true;
			this.labelNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelNumber.Location = new System.Drawing.Point(328, 89);
			this.labelNumber.Name = "labelNumber";
			this.labelNumber.Size = new System.Drawing.Size(35, 14);
			this.labelNumber.TabIndex = 11;
			this.labelNumber.Text = "_0000";
			// 
			// checkBoxStartNum
			// 
			this.checkBoxStartNum.AutoSize = true;
			this.checkBoxStartNum.Checked = true;
			this.checkBoxStartNum.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxStartNum.Location = new System.Drawing.Point(92, 113);
			this.checkBoxStartNum.Name = "checkBoxStartNum";
			this.checkBoxStartNum.Size = new System.Drawing.Size(82, 16);
			this.checkBoxStartNum.TabIndex = 12;
			this.checkBoxStartNum.Text = "連番 0開始";
			this.checkBoxStartNum.UseVisualStyleBackColor = true;
			this.checkBoxStartNum.CheckedChanged += new System.EventHandler(this.CheckBoxStartNum_CheckedChanged);
			// 
			// comboBoxImage
			// 
			this.comboBoxImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxImage.FormattingEnabled = true;
			this.comboBoxImage.Location = new System.Drawing.Point(308, 113);
			this.comboBoxImage.Name = "comboBoxImage";
			this.comboBoxImage.Size = new System.Drawing.Size(83, 20);
			this.comboBoxImage.TabIndex = 13;
			this.comboBoxImage.SelectedIndexChanged += new System.EventHandler(this.ComboBoxImage_SelectedIndexChanged);
			// 
			// labelExt
			// 
			this.labelExt.AutoSize = true;
			this.labelExt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelExt.Location = new System.Drawing.Point(367, 89);
			this.labelExt.Name = "labelExt";
			this.labelExt.Size = new System.Drawing.Size(24, 14);
			this.labelExt.TabIndex = 14;
			this.labelExt.Text = ".jpg";
			// 
			// labelImage
			// 
			this.labelImage.AutoSize = true;
			this.labelImage.Location = new System.Drawing.Point(273, 117);
			this.labelImage.Name = "labelImage";
			this.labelImage.Size = new System.Drawing.Size(29, 12);
			this.labelImage.TabIndex = 15;
			this.labelImage.Text = "形式";
			// 
			// buttonSave
			// 
			this.buttonSave.AutoSize = true;
			this.buttonSave.Location = new System.Drawing.Point(704, 86);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(67, 42);
			this.buttonSave.TabIndex = 16;
			this.buttonSave.Text = "保存";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
			// 
			// checkBoxAll
			// 
			this.checkBoxAll.AutoSize = true;
			this.checkBoxAll.Location = new System.Drawing.Point(92, 37);
			this.checkBoxAll.Name = "checkBoxAll";
			this.checkBoxAll.Size = new System.Drawing.Size(119, 16);
			this.checkBoxAll.TabIndex = 17;
			this.checkBoxAll.Text = "フォルダ内一括変換";
			this.checkBoxAll.UseVisualStyleBackColor = true;
			this.checkBoxAll.CheckedChanged += new System.EventHandler(this.CheckBoxAll_CheckedChanged);
			// 
			// checkBoxOriginName
			// 
			this.checkBoxOriginName.AutoSize = true;
			this.checkBoxOriginName.Location = new System.Drawing.Point(397, 88);
			this.checkBoxOriginName.Name = "checkBoxOriginName";
			this.checkBoxOriginName.Size = new System.Drawing.Size(134, 16);
			this.checkBoxOriginName.TabIndex = 18;
			this.checkBoxOriginName.Text = "元ファイル名を使用する";
			this.checkBoxOriginName.UseVisualStyleBackColor = true;
			this.checkBoxOriginName.CheckedChanged += new System.EventHandler(this.CheckBoxOriginName_CheckedChanged);
			// 
			// FormMain
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 141);
			this.Controls.Add(this.checkBoxOriginName);
			this.Controls.Add(this.checkBoxAll);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.labelImage);
			this.Controls.Add(this.labelExt);
			this.Controls.Add(this.comboBoxImage);
			this.Controls.Add(this.checkBoxStartNum);
			this.Controls.Add(this.labelNumber);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.buttonDest);
			this.Controls.Add(this.textBoxDest);
			this.Controls.Add(this.labelDest);
			this.Controls.Add(this.buttonSource);
			this.Controls.Add(this.labelSource);
			this.Controls.Add(this.textBoxSource);
			this.MaximizeBox = false;
			this.Name = "FormMain";
			this.Text = "AA to Image";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textBoxSource;
		private System.Windows.Forms.Label labelSource;
		private System.Windows.Forms.Button buttonSource;
		private System.Windows.Forms.Label labelDest;
		private System.Windows.Forms.TextBox textBoxDest;
		private System.Windows.Forms.Button buttonDest;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelNumber;
		private System.Windows.Forms.CheckBox checkBoxStartNum;
		private System.Windows.Forms.ComboBox comboBoxImage;
		private System.Windows.Forms.Label labelExt;
		private System.Windows.Forms.Label labelImage;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.CheckBox checkBoxAll;
		private System.Windows.Forms.OpenFileDialog openFileDialogSource;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSource;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDest;
		private System.Windows.Forms.CheckBox checkBoxOriginName;
	}
}

