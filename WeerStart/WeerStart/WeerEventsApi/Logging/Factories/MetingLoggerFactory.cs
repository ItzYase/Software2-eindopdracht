namespace WeerEventsApi.Logging.Factories;

public static class MetingLoggerFactory
{
    public static IMetingLogger Create(bool decorateWithJson = false, bool decorateWithXml = false)
    {
        //TODO Alle combinaties moeten mogelijk zijn (false,false | true,false | false,true | true,true)
        if(decorateWithJson && decorateWithXml)
        {
            throw new ArgumentException("Cannot use both JSON and XML decoration at the same time.");
        }
        if (decorateWithJson == false && decorateWithXml == false)
        {

        }
        if(decorateWithJson)
        {
            //TODO implement JSON decoration
            throw new NotImplementedException("JSON decoration is not implemented yet.");
        }
        if(decorateWithXml)
        {
            //TODO implement XML decoration
            throw new NotImplementedException("XML decoration is not implemented yet.");
        }
        return new MetingLogger();
    }
}