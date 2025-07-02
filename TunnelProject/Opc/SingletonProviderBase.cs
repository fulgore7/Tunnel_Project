namespace TunnelProject.Opc
{
    using System;

    [Serializable]
    public abstract class SingletonProviderBase<SpecifiedProvider> where SpecifiedProvider : class
    {
        #region Fields
        private static SpecifiedProvider _instance;
        private static readonly object LOCK_OBJECT = new object();
        #endregion

        #region Properties
        /// <summary>
        /// This property should be used to ensure that one and only one 
        /// instance is being pointed to and used at all time
        /// </summary>
        /// <value>An Instance of the class</value>
        /// <returns>An Instance of the class</returns>
        /// <remarks>An Instance of the class</remarks>
        public static SpecifiedProvider Instance(params object[] parameters)
        {
            if (_instance == null)
            {
                lock (LOCK_OBJECT)
                {
                    if (_instance == null)
                    {
                        _instance = (SpecifiedProvider)Activator.CreateInstance(typeof(SpecifiedProvider), parameters);
                    }
                }
            }
            return _instance;
        }
        #endregion
    }
}
