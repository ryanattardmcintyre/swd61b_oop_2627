using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance.Example4
{
    public class DigitalFile
    {
        public DigitalFile() //default constructor
        { }

        public DigitalFile(string fileName) // non-default/ overloaded constructor
        {
            Filename = fileName;
            if (File.Exists(fileName) && Path.GetExtension(fileName) == ".bin") {
                Load();
            }
            
        }

        public DigitalFile(string fileName, byte[] addedContents): this(fileName) 
        {
            byte[] tempContents = Contents;
            Contents = new byte[Contents.Length + addedContents.Length];
            tempContents.CopyTo(Contents,0);
            addedContents.CopyTo(Contents, tempContents.Length);

        }


        public string Filename { get; set; }

        public byte[] Contents { get; set; }

        public int Size { get { return Contents.Length; } }

        public virtual void Load()
        {
            Contents = System.IO.File.ReadAllBytes(Filename);
            
            //System.IO.FileStream fs = new FileStream(Filename, FileMode.Open);
            //Contents = new byte[fs.Length];
            //fs.Read(Contents, 0, Contents.Length);
        }

        public virtual void Save()
        {   //overwriting
            System.IO.File.WriteAllBytes(Filename, Contents);
        }

    }
}
