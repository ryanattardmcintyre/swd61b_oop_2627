using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance.Example4
{
    public class TextDigitalFile: DigitalFile
    {
        public string Text { get; set; }

        public override void Load() // <= dynamic polymorphism
        {
            base.Load();
            Text = System.IO.File.ReadAllText(Filename);
        }

        /// <summary>
        /// This method will overwrite the existent content
        /// </summary>
        public override void Save()// <= dynamic polymorphism aka overriding
        {
           System.IO.File.WriteAllText(Filename, Text);
        }
        public void Save(bool append, string newText) //<= static polymorphism aka overloading
        {  
            if (append)
            {
                System.IO.File.AppendAllText(Filename, newText);
            }
            else
            {
                Text = newText; 
                Save();
            }
        }

        public void Save(bool append, char newCharacter)
        {
            if (append)
            {
                System.IO.File.AppendAllText(Filename, newCharacter.ToString());
            }
            else
            {
                Text = newCharacter.ToString();
                Save();
            }
        }

        public void Save(bool append, string newText, string filename)
        {
            if ((append))
            {
                string absolutePath = System.IO.Path.GetFullPath(Filename) +
                                    filename;
                System.IO.File.AppendAllText(absolutePath, Text + newText);
            }
            else
            {
                int indexOfLastSlash = Filename.LastIndexOf('/');
                string absolutePath = Filename.Substring(0, indexOfLastSlash+1 ) +
                                    filename;
                System.IO.File.AppendAllText(absolutePath, newText);
            }
        }
    }
}
