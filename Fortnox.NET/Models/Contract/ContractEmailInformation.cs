﻿namespace FortnoxNET.Models.Contract
{
    public class ContractEmailInformation
    {
        /// <summary>
        /// Sender e-mail address
        /// </summary>
        public string EmailAddressFrom { get; set; }

        /// <summary>
        /// Customer e-mail address
        /// </summary>
        public string EmailAddressTo { get; set; }

        /// <summary>
        /// Customer e-mail address copy
        /// </summary>
        public string EmailAddressCC { get; set; }

        /// <summary>
        /// Customer e-mail address blind carbon copy
        /// </summary>
        public string EmailAddressBCC { get; set; }

        /// <summary>
        /// 	Subject of e-mail
        /// </summary>
        public string EmailSubject { get; set; }

        /// <summary>
        /// Body of e-mail.
        /// </summary>
        public string EmailBody { get; set; }
    }
}
