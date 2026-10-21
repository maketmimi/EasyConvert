using EasyConvert.Core;
using EasyConvert.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EasyConvert
{
    public partial class FrmMain : Form
    {
        private string _SaveFolderPath = null;
        private string SaveFolderPath
        {
            set
            {
                _SaveFolderPath = value;
                TxtResultSavePath.Text = _SaveFolderPath;
            }

            get
            {
                return _SaveFolderPath;
            }
        }

        private string _ImageToConvertPath = null;
        private string ImageToConvertPath
        {
            set
            {
                // reset the image
                if (value == null)
                {
                    ResetImage();
                    return;
                }

                try
                {
                    ImageToConvert = Image.FromFile(value);
                    _ImageToConvertPath = value;
                    TxtSourceImageName.Text = _ImageToConvertPath;
                    TxtResultImageName.Text = 
                        Path.GetFileNameWithoutExtension(_ImageToConvertPath);
                    SaveFolderPath = Path.GetDirectoryName(_ImageToConvertPath);
                }
                catch
                {
                    MessageBox.Show("Failed To Load Image", "Invaild Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            get
            {
                return _ImageToConvertPath;
            }
        }

        private Image _ImageToConvert = null;
        private Image ImageToConvert
        {
            set
            {
                _ImageToConvert?.Dispose();
                _ImageToConvert = value;
                PbSourceImagePreview.Image = _ImageToConvert;

                if (value == null)
                    ResetStauts();
                else
                    SetStatusToReady();
            }

            get
            {
                return _ImageToConvert;
            }
        }

        private string FullResultImagePath
        {
            get
            {
                return
                    Path.Combine(SaveFolderPath, TxtResultImageName.Text + CbTargetImageFormat.SelectedItem.ToString());
            }
        }

        public FrmMain()
        {
            InitializeComponent();
            InitializeCbTargetFormat();
            InitializeResultSaveFolder();
            InitializeFbdSaveFolder();
            InitializeOfdBrowseImage();
        }

        private void ResetImage()
        {
            ImageToConvert = null;
            _ImageToConvertPath = null;
            TxtSourceImageName.Text = "Please select an image to convert";
            TxtResultImageName.Clear();
            BtnConvert.Enabled = false;
        }

        private void ResetStauts()
        {
            LbConvertStatus.Text = String.Empty;
        }

        private void SetStatusToReady()
        {
            LbConvertStatus.Text = "Ready";
            LbConvertStatus.ForeColor = Color.Green;
            BtnConvert.Enabled = true;
        }

        private void InitializeCbTargetFormat()
        {
            CbTargetImageFormat.Items.AddRange(ImageFormats.GetSupportedExtentions());
            
            CbTargetImageFormat.SelectedIndex = 0;
        }

        private void InitializeResultSaveFolder()
        {
            SaveFolderPath =
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void BtnShowResultImage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(SaveFolderPath);
        }
 
        private void InitializeFbdSaveFolder()
        {
            FbdSaveFolder.SelectedPath =
                SaveFolderPath;
        }

        private void BtnBrowseResultSaveFolder_Click(object sender, EventArgs e)
        {
            if (FbdSaveFolder.ShowDialog() == DialogResult.OK)
            {
                SaveFolderPath = FbdSaveFolder.SelectedPath;
            }
        }

        private void TxtResultImageName_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidResultName())
            {
                e.Cancel = true;
                ErrMain.SetError(TxtResultImageName, "Invalid image name!");
            }
            else
            {
                e.Cancel = false;
                ErrMain.SetError(TxtResultImageName, null);
            }
        }
    
        private void InitializeOfdBrowseImage()
        {
            OfdBrowseImage.Filter = "All Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp;*.tiff;*.tif;*.webp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp;*.tiff;*.tif;*.webp;*.ico|" +
                                    "PNG Portable Network Graphics (*.png)|*.png|" +
                                    "JPEG Image (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                                    "GIF Graphics Interchange Format (*.gif)|*.gif|" +
                                    "BMP Windows Bitmap (*.bmp)|*.bmp|" +
                                    "TIFF Tagged Image File Format (*.tiff;*.tif)|*.tiff;*.tif|" +
                                    "WebP Image (*.webp)|*.webp|" +
                                    "Icon Files (*.ico)|*.ico";

            OfdBrowseImage.InitialDirectory =
                Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }
    
        private bool IsValidResultName()
        {
            return
                !(
                String.IsNullOrWhiteSpace(TxtResultImageName.Text) ||
                TxtResultImageName.Text.IndexOfAny(Path.GetInvalidFileNameChars()) != -1 ||
                TxtResultImageName.Text.Contains('.') ||
                File.Exists(FullResultImagePath)
                );
        }

        private void BtnBrowseSourceImage_Click(object sender, EventArgs e)
        {
            if (OfdBrowseImage.ShowDialog() == DialogResult.OK)
            {
                ImageToConvertPath = OfdBrowseImage.FileName;
            }
        }

        private void SetStatusToProcessing()
        {
            LbConvertStatus.Text = "Processing...";
            LbConvertStatus.ForeColor = Color.Black;
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            SetStatusToProcessing();

            try
            {
                if (ImageToConvert == null)
                {
                    MessageBox.Show("Cannot Convert Image!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsValidResultName())
                {
                    this.ValidateChildren();
                    MessageBox.Show("Cannot convert, Invalid Image Name!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Core.ImageConvertor.EnConvertResult ConvertResult =
                    Core.ImageConvertor.ConvertImage(ImageToConvert,
                    ImageFormats.GetFormatFromExtension(CbTargetImageFormat.SelectedItem.ToString()),
                    FullResultImagePath);

                switch (ConvertResult)
                {
                    case ImageConvertor.EnConvertResult.Successful:
                        MessageBox.Show("Image converted successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case ImageConvertor.EnConvertResult.Failed_FileAlreadyExists:
                        MessageBox.Show("Cannot convert image because the name already exists.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case ImageConvertor.EnConvertResult.Failed_InvalidPath:
                        MessageBox.Show("Cannot convert image because the saving folder path is Invalid", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show("Cannot Convert Image!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            finally
            {
                this.Enabled = true;
                if (ImageToConvert != null)
                    SetStatusToReady();
                else
                    ResetStauts();
            }
        }

        private void LibMalekGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Resources.MalekAltamimiPortfolioLink);
            LibMalekGithub.LinkVisited = true;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageToConvertPath = null;
        }
    }
}
