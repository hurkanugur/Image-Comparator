using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comparator
{
    public partial class Screen : Form
    {
        private OpenFileDialog Selector;
        private List<string> Addresses;
        private List<string> SavedList;
        private int i, j, index;
        private int Comparison_Width;
        private int Comparison_Height;
        private Bitmap Picture1;
        private Bitmap Picture2;
        private Bitmap Picture_Comparison;
        public Screen()
        {
            InitializeComponent();
            Selector = new OpenFileDialog();
            Selector.Filter = "Picture(jpg)|*.jpg|Picture(jpeg)|*.jpeg|Picture(png)|*.png";
            Selector.RestoreDirectory = true;
            Selector.Title = "Please select the images";
            Selector.Multiselect = true;
            Clock_Tower.Enabled = false;
            Addresses = new List<string>();
            SavedList = new List<string>();
            Comparison_ProgressBar.ForeColor = Color.Aqua;
            PictureBox_1.ImageLocation = PictureBox_2.ImageLocation = Comparison_PictureBox.ImageLocation = "Comparator_Settings\\Comparator.png";
            Icon = new Icon("Comparator_Settings\\Comparator.ico");
        }
        private void Select_Button(object sender, EventArgs e)
        {
            Clock_Tower.Enabled = false;
            index = 0;
            Addresses.Clear();
            SavedList.Clear();
            if (Selector.ShowDialog() == DialogResult.OK)
            {
                foreach (string getPath in Selector.FileNames)
                {
                    Addresses.Add(Path.GetFullPath(getPath));
                }
                //COMPARISON DIRECTORIES ARE CREATED
                if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Picture Comparison") == false)
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Picture Comparison");
                else
                {
                    Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Picture Comparison", true);
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Picture Comparison");
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Picture Comparison\\Differences");
                }

                //IMAGES LOADED ON THE SCREEN
                PictureBox_1.ImageLocation = Addresses.ElementAt(index);
                Comparison_PictureBox.ImageLocation = Addresses.ElementAt(index);
                try { PictureBox_2.ImageLocation = Addresses.ElementAt(index + 1); } catch (Exception) { PictureBox_2.ImageLocation = Addresses.ElementAt(index); }
                label1.Text = Path.GetFileName(PictureBox_1.ImageLocation);
                label2.Text = Path.GetFileName(PictureBox_2.ImageLocation);
                label3.Text = label1.Text + " vs " + label2.Text;
                Clock_Tower.Enabled = true;
            }
        }

        private void Clock_Tower_Tick(object sender, EventArgs e)
        {
            if (index < Addresses.Count - 1)
            {
                //IMAGES LOADED ON THE SCREEN
                PictureBox_1.ImageLocation = Addresses.ElementAt(index);
                try { PictureBox_2.ImageLocation = Addresses.ElementAt(index + 1); } catch (Exception) { PictureBox_2.ImageLocation = Addresses.ElementAt(index); }
                Picture1 = new Bitmap(PictureBox_1.ImageLocation);
                Picture2 = new Bitmap(PictureBox_2.ImageLocation);
                Picture_Comparison = new Bitmap(PictureBox_1.ImageLocation);
                Comparison_PictureBox.Image = Picture_Comparison;

                label1.Text = Path.GetFileName(PictureBox_1.ImageLocation);
                label2.Text = Path.GetFileName(PictureBox_2.ImageLocation);
                label3.Text = label1.Text + " vs " + label2.Text;

                //SIZE COMPARISON
                if (Picture1.Width < Picture2.Width)
                    Comparison_Width = Picture1.Width;
                else
                    Comparison_Width = Picture2.Width;

                if (Picture1.Height < Picture2.Height)
                    Comparison_Height = Picture1.Height;
                else
                    Comparison_Height = Picture2.Height;

                //IMAGE COMPARISON
                long Different_Pixels = 0;
                for (i = 0; i < Comparison_Width; i++)
                {
                    for (j = 0; j < Comparison_Height; j++)
                    {
                        if (Picture1.GetPixel(i, j) != Picture2.GetPixel(i, j))
                        {
                            Picture_Comparison.SetPixel(i, j, Color.Red);
                            Different_Pixels++;
                        }
                    }
                    //MODE: OBSERVE DIFFERENCES
                    if (Observe_CheckBox.CheckState == CheckState.Checked)
                        Refresh();
                }

                //CALCULATING DIFFERENCE RATE (IF THE NUMBER OF DIFFERENT PIXELS > 30, THAT MEANS IMAGES ARE DIFFERENT)
                bool Pictures_Are_Different = false;
                Different_Pixels = ((Different_Pixels * 100) / (Comparison_Height * Comparison_Width));
                if (Different_Pixels > 30)
                    Pictures_Are_Different = true;
                Similarity_Rate_Label.Text = "Similarity Rate " + (100 - Different_Pixels) + "%";

                //SAVING IMAGES
                try
                {
                    //CHECKING WHETHER IMAGE IS ALREADY SAVED OR NOT
                    bool PictureBox1_Exists = false;
                    bool PictureBox2_Exists = false;
                    foreach (string search in SavedList)
                    {
                        if (search == PictureBox_1.ImageLocation)
                            PictureBox1_Exists = true;
                        if (search == PictureBox_2.ImageLocation)
                            PictureBox1_Exists = true;
                    }
                    //MODE: SAVE DIFFERENT ONES
                    //CASE: IMAGES ARE DIFFERENT !!!
                    if (Pictures_Are_Different == true && (Save_CheckBox.CheckState == CheckState.Checked))
                    {
                        //IF IMAGE IS NOT SAVED BEFORE, SAVE IT NOW
                        if (PictureBox1_Exists == false)
                        {
                            Picture1.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                                + "\\Picture Comparison\\" + Path.GetFileName(PictureBox_1.ImageLocation));
                            SavedList.Add(PictureBox_1.ImageLocation);
                        }
                        //IF IMAGE IS NOT SAVED BEFORE, SAVE IT NOW
                        if (PictureBox2_Exists == false)
                        {
                            Picture2.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                           + "\\Picture Comparison\\" + Path.GetFileName(PictureBox_2.ImageLocation));
                            SavedList.Add(PictureBox_2.ImageLocation);
                        }
                    }
                    //CASE: IMAGES ARE SAME !!!
                    else if (Pictures_Are_Different == false && (Save_CheckBox.CheckState == CheckState.Checked))
                    {
                        //IF FIRST IMAGE IS SAVED BEFORE, MARK THE SECOND IMAGE AS SAVED TOO (BUT NOT SAVE IT AGAIN)
                        if (PictureBox1_Exists == true && PictureBox2_Exists == false)
                        {
                            SavedList.Add(PictureBox_2.ImageLocation);
                        }
                        else if(PictureBox1_Exists == false && PictureBox2_Exists == false)
                        {
                            Picture1.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                                + "\\Picture Comparison\\" + Path.GetFileName(PictureBox_1.ImageLocation));

                            SavedList.Add(PictureBox_1.ImageLocation);
                            SavedList.Add(PictureBox_2.ImageLocation);
                        }
                    }

                    //SAVE DIFFERENCES BETWEEN IMAGES
                    Picture_Comparison.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                        + "\\Picture Comparison\\Differences\\" + Path.GetFileName(PictureBox_1.ImageLocation)
                        + " & " + Path.GetFileName(PictureBox_2.ImageLocation));
                }
                catch (Exception) { }

                //PROGRESSBAR SETTINGS
                try { Comparison_ProgressBar.Value = (index * 100) / (Addresses.Count - 2); }
                catch (Exception) { Comparison_ProgressBar.Value = 100; }
                Percentage_Label.Text = Comparison_ProgressBar.Value + "%";

                //CLOSING SETTINGS
                index++;
                Refresh();
                Picture1.Dispose();
                Picture2.Dispose();
                Picture_Comparison.Dispose();
            }
            else
            {
                Clock_Tower.Enabled = false;
                MessageBox.Show("Image Comparison Is Done !");
            }
        }
    }
}