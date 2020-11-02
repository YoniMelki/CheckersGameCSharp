namespace Checkers
{
    public struct Cell
    {
        private eCellSign m_Sign;
        private bool m_PawnInCell;

        public enum eCellSign
        {
            PawnO = 'O',
            PawnX = 'X',
            KingO = 'U',
            KingX = 'K',
            Empty = ' '
        }

        public eCellSign Sign
        {
            get
            {
                return m_Sign;
            }

            set
            {
                m_Sign = value;
            }
        }

        public bool PawnInCell
        {
            get
            {
                return m_PawnInCell;
            }

            set
            {
                m_PawnInCell = value;

                if (!m_PawnInCell)
                {
                    m_Sign = eCellSign.Empty;
                }
            }
        }
    }
}
