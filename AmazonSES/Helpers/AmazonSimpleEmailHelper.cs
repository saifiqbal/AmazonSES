using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazonSES.Helpers
{
    public class AmazonSimpleEmailHelper
    {
        public void SendEmail(string fromAddress,string toAddress,string _subject, string _body) {

            Destination destination = new Destination();
            destination.ToAddresses = (new List<string>() { toAddress });
            Content subject = new Content(_subject);
            Content textBody = new Content(_body);
            Body body = new Body(textBody);

            Message message = new Message(subject, body);
            
            SendEmailRequest request = new SendEmailRequest(fromAddress, destination, message);
            Amazon.RegionEndpoint REGION = Amazon.RegionEndpoint.USEast1;

            // Instantiate an Amazon SES client, which will make the service call.
            AmazonSimpleEmailServiceClient client = new AmazonSimpleEmailServiceClient(REGION);

            // Send the email.
            try
            {
                //("Attempting to send an email through Amazon SES by using the AWS SDK for .NET...");
                client.SendEmail(request);
                //("Email sent!");
            }
            catch (Exception ex)
            {
                //("Error message: " + ex.Message);
            }


        }

    }
}