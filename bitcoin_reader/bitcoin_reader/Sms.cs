﻿using System;
using System.IO;
using System.Net;
using System.Text;

class Sms
{
    public  void sendSms()
    {
        // This URL is used for sending messages
        string myURI = "https://api.bulksms.com/v1/messages";

        // change these values to match your own account
        string myUsername = "ryandiebeste";
        string myPassword = "Kru@2020";

        // the details of the message we want to send
        string myData = "{to: \"+27731875508\", body:\"OnewaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaStukNai\"}";

        // build the request based on the supplied settings
        var request = WebRequest.Create(myURI);

        // supply the credentials
        request.Credentials = new NetworkCredential(myUsername, myPassword);
        request.PreAuthenticate = true;
        // we want to use HTTP POST
        request.Method = "POST";
        // for this API, the type must always be JSON
        request.ContentType = "application/json";

        // Here we use Unicode encoding, but ASCIIEncoding would also work
        var encoding = new UnicodeEncoding();
        var encodedData = encoding.GetBytes(myData);

        // Write the data to the request stream
        var stream = request.GetRequestStream();
        stream.Write(encodedData, 0, encodedData.Length);
        stream.Close();

        // try ... catch to handle errors nicely
        try
        {
            // make the call to the API
            var response = request.GetResponse();

            // read the response and print it to the console
            var reader = new StreamReader(response.GetResponseStream());
            Console.WriteLine(reader.ReadToEnd());
        }
        catch (WebException ex)
        {
            // show the general message
            Console.WriteLine("An error occurred:" + ex.Message);

            // print the detail that comes with the error
            var reader = new StreamReader(ex.Response.GetResponseStream());
            Console.WriteLine("Error details:" + reader.ReadToEnd());
        }
    }
}