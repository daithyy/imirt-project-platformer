namespace IMIRT.SaveSystem
{
    internal interface ISerialiser
    {
        string SerialiseObject<T>(T dataObject);

        T DeserialiseObject<T>(string dataString);
    }
}
