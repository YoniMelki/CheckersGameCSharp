using System.Drawing;

namespace Checkers
{
    public class Move
    {
        private Point m_Source;
        private Point m_Destination;

        public Move() // C'tor that create and empty move
        {
            // Point(-100, -100) -> Empty Point, hence two empty point -> empty move
            m_Source = new Point(-100, -100);
            m_Destination = new Point(-100, -100);
        }

        public Move(Point i_Source, Point i_Dest)
        {
            m_Source = i_Source;
            m_Destination = i_Dest;
        }

        public Point Source
        {
            get { return m_Source; }
            set { m_Source = value; }
        }

        public Point Destination
        {
            get { return m_Destination; }
            set { m_Destination = value; }
        }

        public void MakeEmpty()
        {
            m_Source = new Point(-100, -100);
            m_Destination = new Point(-100, -100);
        }

        public bool IsEmpty()
        {
            return m_Source.X == -100 && m_Source.Y == -100;
        }
    }
}
