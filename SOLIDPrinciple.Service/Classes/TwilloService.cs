using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace SOLIDPrinciple.Service.Classes
{
    public class TwilloService
    {
        /// <summary>
        /// THIS IS SINGLE RESPONSIBILITY PRINCIPLE (SRP) DESIGN
        /// WHEN A SERVICE OR METHOD ARE REUSE MANY OTHERS CLASS OR SERVICE
        /// </summary>
        /// <param name="callReceiver"></param>
        /// <param name="sayText"></param>
        /// <returns></returns>
        public CallResource TwilioSay(string callReceiver, string sayText)
        {
            TwilioClient.Init(ConfigurationManager.AppSettings["TwilioAccountsId"], ConfigurationManager.AppSettings["TwilioAuthToken"]);
            return CallResource.Create(
               twiml: new Twilio.Types.Twiml($"<Response><Say voice='woman'>{sayText}</Say></Response>"),
               to: new Twilio.Types.PhoneNumber(callReceiver),
               from: new Twilio.Types.PhoneNumber(ConfigurationManager.AppSettings["TwilioSenderPhoneNumber"]));
        }
    }
}
