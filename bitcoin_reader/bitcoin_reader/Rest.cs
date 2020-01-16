using System;
using System.Net;
using System.Web;

class Rest
{
    private static string API_KEY = "e24be655-2753-449c-ac83-b573fcf72407";

    public  string GetBTC()
    {
        try
        {
           String val = makeAPICall();
            return val;
        }
        catch (WebException e)
        {
            Console.WriteLine(e.Message);
            return null; 
         }
    }

     static string makeAPICall()
    {
        var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

        var queryString = HttpUtility.ParseQueryString(string.Empty);
        queryString["start"] = "1";
        queryString["limit"] = "2";
        queryString["convert"] = "USD";

        URL.Query = queryString.ToString();

        var client = new WebClient();
        client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
        client.Headers.Add("Accepts", "application/json");
        return client.DownloadString(URL.ToString());
    }

}