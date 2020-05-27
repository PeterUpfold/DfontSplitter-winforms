using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DfontSplitter
{
    class FontForgeWrapper
    {

        //fontforge.exe -c 'open(argv[1]).generate(argv[2])' Courier.ttf Courier_win.ttf

        /// <summary>
        /// Use fontforge to normalise the given TTF file. Some Mac-specific TTF files are
        /// not supported by Windows, but FontForge can normalise these once extracted from the
        /// Dfont or Font Suitcase.
        /// </summary>
        /// <param name="filename">Relative path in the temporary folder</param>
        /// <param name="containingTempFolder">The temporary folder containing the file</param>
        /// <param name="normalisedFilePath">The file path for the normalised TTF</param>
        /// <returns>The exit code of fontforge.exe</returns>
        public static int NormaliseTTF(string filename, string containingTempFolder, out string normalisedFilePath)
        {
            string fontForgePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "ExternalTools", "fontforge", "bin", "fontforge.exe");

            if (!File.Exists(fontForgePath))
            {
                throw new InvalidOperationException("The fontforge external tools are not correctly installed.");
            }

            string inputFilename = Path.Combine(containingTempFolder, filename);
            string outputFilename = Path.Combine(containingTempFolder, Path.GetFileNameWithoutExtension(filename) + "_out.ttf");

            // some safety for arguments
            if (inputFilename.Contains("\"") || outputFilename.Contains("\"")) {
                throw new ArgumentOutOfRangeException(filename, "Input or output filename contains double quote character");
            }

            Process ffProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = fontForgePath,
                    Arguments = $"-c \"open(argv[1]).generate(argv[2])\" \"{inputFilename}\" \"{outputFilename}\""
                }
            };
            ffProcess.Start();
            ffProcess.WaitForExit();

            normalisedFilePath = outputFilename;
            return ffProcess.ExitCode;
        }
    }
}
