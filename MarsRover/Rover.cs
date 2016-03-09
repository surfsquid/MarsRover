using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Rover
    {
        const string cardinals = "NESWNESW";
        /// <summary>
        /// Position of rover along X axis on plateau
        /// </summary>
        public int XCoordinate { get; set; }

        /// <summary>
        /// Position of rover along Y axis on plateau
        /// </summary>
        public int YCoordinate { get; set; }

        /// <summary>
        /// Compass direction the rover is currently facing
        /// </summary>
        public string Orientation { get; set; }

        /// <summary>
        /// The current being processed by the rover
        /// </summary>
        public string Instruction { get; set; }

        public void Move()
        {
            foreach (char step in Instruction)
            {
                switch (step)
                {
                    case 'L':
                        Orientation = cardinals.Substring(cardinals.LastIndexOf(Orientation) - 1, 1);
                        break;
                    case 'R':
                        Orientation = cardinals.Substring(cardinals.IndexOf(Orientation) + 1, 1);
                        break;
                    case 'M':
                        switch (Orientation)
                        {
                            case "N":
                                YCoordinate++;
                                break;
                            case "E":
                                XCoordinate++;
                                break;
                            case "S":
                                YCoordinate--;
                                break;
                            case "W":
                                XCoordinate--;
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        public string GetLocation()
        {
            return string.Format("{0} {1} {2}", this.XCoordinate, this.YCoordinate, this.Orientation);
        }

        public bool Initialize(string positionInput, string instructionInput)
        {
            string[] position = positionInput.Split(' ');
            if (position.Length == 3)
            {
                try
                {
                    int x = int.Parse(position[0]);
                    int y = int.Parse(position[1]);
                    string orientation = position[2].ToUpper();
                    if (orientation == "N" || orientation == "S" || orientation == "E" || orientation == "W")
                    {
                        Orientation = orientation;
                        XCoordinate = x;
                        YCoordinate = y;
                        Instruction = instructionInput;
                        return true;
                    }
                }
                catch (Exception)
                {
                }
            }
            return false;
        }
    }
}
