namespace IMIRT.SaveSystem
{
    public class SaveSystem : ISaveSystem
    {
        private ISerialiser m_Serialiser;
        
        private ISaveFileHandler m_SaveFileHandler;

        public void Save<T>(T data)
        {
            /*  Take data and convert it to whatever format
             *  store the data
             */

            string dataString = m_Serialiser.SerialiseObject(data);

            m_SaveFileHandler.SaveData(dataString);
        }

        public T Load<T>()
        {
            string dataString = m_SaveFileHandler.LoadData();

            return m_Serialiser.DeserialiseObject<T>(dataString);
        }
    }
}
