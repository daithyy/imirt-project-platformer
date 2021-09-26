namespace IMIRT.SaveSystem
{
    public class SaveSystem : ISaveSystem
    {
        private ISerialiser m_Serialiser;
        
        private ISaveFileHandler m_SaveFileHandler;

        private string SaveFileName => "SaveFile";

        public void Save<T>(T data)
        {
            /*  Take data and convert it to whatever format
             *  store the data
             */

            string dataString = m_Serialiser.SerialiseObject(data);

            m_SaveFileHandler.SaveData(dataString, SaveFileName);
        }

        public T Load<T>()
        {
            string dataString = m_SaveFileHandler.LoadData(SaveFileName);

            return m_Serialiser.DeserialiseObject<T>(dataString);
        }
    }
}
