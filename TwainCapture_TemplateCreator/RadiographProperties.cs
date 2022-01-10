using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwainCapture_TemplateCreator
{
    internal class RadiographProperties
    {
        int m_sequenceNumber, m_sizeX, m_sizeY, m_positionX, m_positionY;
        string m_rotation, m_mirrored, m_flipped;

        /// <summary>
        /// Primary constructor that stores all these values
        /// </summary>
        /// <param name="imageNum"></param>
        /// <param name="sizeX"></param>
        /// <param name="sizeY"></param>
        /// <param name="positionX"></param>
        /// <param name="positionY"></param>
        /// <param name="mirror"></param>
        /// <param name="flip"></param>
        /// <param name="rotation"></param>
        public RadiographProperties(int imageNum, int sizeX, int sizeY, int positionX, int positionY, string mirror, string flip, string rotation)
        {
            m_sequenceNumber = imageNum;
            m_sizeX = sizeX;
            m_sizeY = sizeY;
            m_positionX = positionX;
            m_positionY = positionY;
            m_mirrored = mirror;
            m_flipped = flip;
            m_rotation = rotation;            
        }
        public int GetSequenceNumber() { return m_sequenceNumber;}
        /// <summary>
        /// Creates and returns new Size object constructed with width and height member variables.
        /// </summary>
        /// <returns></returns>
        public Size GetSize(){ return new Size(m_sizeX, m_sizeY); }
        public int GetSizeX() { return m_sizeX; }
        public int GetSizeY() { return m_sizeY; }

        /// <summary>
        /// Creates and returns a new Point constructed with the the position member values.
        /// </summary>
        /// <returns></returns>
        public Point GetLocation() { return new Point(m_positionX, m_positionY); }
        /// <summary>
        /// Getter for mirror value; Constructor takes string, this returns bool
        /// </summary>
        /// <returns></returns>
        public int GetPositionX() { return m_positionX; }
        public int GetPositionY() { return m_positionY; }


        public bool Mirrored()
        {
            if (m_mirrored.Contains("True"))
                return true;
            else
                return false;
        }
        /// <summary>
        /// Getter for Flipped value, Constructor takes string, this returns bool
        /// </summary>
        /// <returns></returns>
        public bool Flipped()
        {
            if (m_flipped.Contains("True"))
                return true;
            else
                return false;
        }

        /// <summary>
        /// getter for Rotation. Constructor accepts string, this will convert to int
        /// </summary>
        /// <returns></returns>
        public int Rotated() 
        {
            if (m_rotation.Contains("90"))
                return 90;
            else
                return 0;
        }
    }
}
