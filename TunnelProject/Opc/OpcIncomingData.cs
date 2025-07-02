namespace TunnelProject.Opc
{
    public class OpcIncomingData
    {
        #region Fields
        private int _transactionID;
        private int _groupHandle;
        private int _numItems;
        private Array _itemValues;
        private Array _clientHandles;
        private Array _timeStamps;
        private Array _qualities;
        #endregion

        #region Properties
        public Array Qualities
        {
            get { return _qualities; }
            set { _qualities = value; }
        }

        public int TransactionID
        {
            get { return _transactionID; }
            set { _transactionID = value; }
        }

        public int GroupHandle
        {
            get { return _groupHandle; }
            set { _groupHandle = value; }
        }

        public int NumItems
        {
            get { return _numItems; }
            set { _numItems = value; }
        }

        public Array ItemValues
        {
            get { return _itemValues; }
            set { _itemValues = value; }
        }

        public Array ClientHandles
        {
            get { return _clientHandles; }
            set { _clientHandles = value; }
        }

        public Array TimeStamps
        {
            get { return _timeStamps; }
            set { _timeStamps = value; }
        }
        #endregion

        #region Constructors
        public OpcIncomingData(int transactionID, int groupHandle, Array clientHandles, int numItems, Array itemValues, Array timeStamps, Array qualities)
        {
            _transactionID = transactionID;
            _groupHandle = groupHandle;
            _numItems = numItems;
            _itemValues = itemValues;
            _clientHandles = clientHandles;
            _timeStamps = timeStamps;
            _qualities = qualities;
        }
        #endregion
    }
}
