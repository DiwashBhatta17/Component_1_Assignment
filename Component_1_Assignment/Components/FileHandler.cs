using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Component_1_Assignment.Components
{
    internal class FileHandler
    {
        public void Save(string text) {
            var SaveFileDialog = new SaveFileDialog
            {
                FileName = "program.txt",
                Filter = @"Text File | *.txt"
            };

            if (SaveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var write = new StreamWriter(SaveFileDialog.OpenFile());
            WriteToFile(write, text);
            
        
        }

        internal void WriteToFile(StreamWriter writer,string text)
        {
            try
            {
                text.Split('\n')
                    .ToList()
                    .ForEach(writer.WriteLine);
            }
            catch (Exception ex)
            {
                throw new IOException($"An Error occour while saving the program: { ex.Message} ");
            }
            finally
            {
                writer.Dispose();
                writer.Close();
            }
        }

        public string Load()
        {
            string loadedText = null;

            var openFileDialog = new OpenFileDialog
            {
                Filter = @"Text Files|*.txt",
                Title = "Select a Text File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var reader = new StreamReader(openFileDialog.FileName))
                    {
                        loadedText = reader.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    throw new IOException($"An error occurred while loading the file: {ex.Message}");
                }
            }

            return loadedText;
        }

    }
}
