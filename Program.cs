using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musikal
{
    class Program
    {
        static string MusicNotes = "CDEFGAB";
        static List<string> ChromaticNotes = new List<string>();

        //  HS = 1
        //  FS = 2

       static  int[] Major = {0,2,2,1,2,2,2,1 };
        static void Main(string[] args)
        {
            foreach(char charNote in MusicNotes)
            {
                string Note = charNote.ToString();
                if( Note == "B" | Note == "E")
                {
                    ChromaticNotes.Add(Note);
                }
                else
                {
                    ChromaticNotes.Add(Note);
                    ChromaticNotes.Add(Note+"#");
                }
            }

            string ScaleRoot = "F";                                 //<<    Set scale root.
            int[] ScaleDefiition = Major;                           //<<    Set scale definition to use, e.g, Major or Minor. 
            int NoteIndex = ChromaticNotes.IndexOf(ScaleRoot);      //<<    Set scale root index.
            //Console.WriteLine(NoteIndex);

            //  Chromatic notes index cheat sheet.
            //  0  1  2  3  4  5  6  7  8  9  10  11
            //  C  C# D  D# E  F  F# G  G# A  A#  B 
            int nextIndex = NoteIndex;
            foreach(int step in ScaleDefiition)
            {
                nextIndex = nextIndex + step;
                if (nextIndex <= ChromaticNotes.Count() - 1)
                {
                    Console.WriteLine(ChromaticNotes[nextIndex]);
                }
                else
                {
                    Console.WriteLine(ChromaticNotes[nextIndex - ChromaticNotes.Count()]);
                }
            }
            Console.ReadKey();
        }

    }

}
       