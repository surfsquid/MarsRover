using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Plateau
    {
        /// <summary>
        /// The length of the plateau along the X axis
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// The length of the plateau along the Y axis
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Robots currently on the plateau
        /// </summary>
        public List<Rover> Rovers { get; set; }

        /// <summary>
        /// Indicates whether the plateau has dimensions
        /// </summary>
        public bool IsInitialized { get; set; }

        public Plateau()
        {
            Rovers = new List<Rover>();
        }

        /// <summary>
        /// Initializes the plateau with its dimensions
        /// </summary>
        /// <param name="dimensionInput"></param>
        /// <returns></returns>
        public string Initialize(string dimensionInput)
        {
            if (!string.IsNullOrWhiteSpace(dimensionInput))
            {
                string[] dimensionStrings = dimensionInput.Split(' ');
                if (dimensionStrings.Length == 2)
                {
                    int dimension;
                    if (int.TryParse(dimensionStrings[0], out dimension))
                    {
                        Width = dimension;
                        if (int.TryParse(dimensionStrings[1], out dimension))
                        {
                            Height = dimension;
                            IsInitialized = true;
                            return "Thanks!";
                        }
                    }
                }
            }
            return "Incorrect input format";
        }
    }
}
