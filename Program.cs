﻿using System;
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
            SetChromaticNotes();                                    //<<    Set chromatic notes. Required!!!

            string ScaleRoot = "F";                                 //<<    Set scale root.
            int[] ScaleDefinition = Major;                          //<<    Set scale definition to use, e.g, Major or Minor. 
            pScale(ScaleRoot, ScaleDefinition);
            
            Console.ReadKey();                                      //<<    Keep app alive.
        }
        static void SetChromaticNotes()
        {
            foreach (char charNote in MusicNotes)
            {
                string Note = charNote.ToString();
                if (Note == "B" | Note == "E")
                {
                    ChromaticNotes.Add(Note);
                }
                else
                {
                    ChromaticNotes.Add(Note);
                    ChromaticNotes.Add(Note + "#");
                }
            }
        }
        static void pScale(string ScaleRoot, int[]ScaleDefinition)
        {
            List<string> ScaleNotes = new List<string>();
            int NoteIndex = ChromaticNotes.IndexOf(ScaleRoot);      //<<    Set scale root index.
            //Console.WriteLine(NoteIndex);

            //  Chromatic notes index cheat sheet.
            //  0  1  2  3  4  5  6  7  8  9  10  11
            //  C  C# D  D# E  F  F# G  G# A  A#  B 
            int nextIndex = NoteIndex;
            foreach (int step in ScaleDefinition)
            {
                nextIndex = nextIndex + step;
                if (nextIndex <= ChromaticNotes.Count() - 1)
                {
                    //Console.WriteLine(ChromaticNotes[nextIndex]);
                    ScaleNotes.Add(ChromaticNotes[nextIndex]);
                }
                else
                {
                    //Console.WriteLine(ChromaticNotes[nextIndex - ChromaticNotes.Count()]);
                    ScaleNotes.Add(ChromaticNotes[nextIndex - ChromaticNotes.Count()]);
                }
            }
            Console.WriteLine(string.Join(" - ", ScaleNotes));
        } 
    }

}
       