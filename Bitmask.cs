    class BitMask
    {
        public enum Action
        {
            A, B, C, D,
            E, F, G, H,
        }

        byte b = 0;

        public void Set(Action a)
        {
            b = (byte)(b | 1 << (int)a);
        }

        public void Del(Action a)
        {
            b = (byte)(b & ~(byte)(1 << (int)a));
        }

        public bool Check(Action a)
        {
            return (b & (byte)(1 << (int)a)) > 0;
        }

    }
