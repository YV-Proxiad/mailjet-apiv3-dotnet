﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mailjet.Client
{
    public interface IMailjetClient
    {
        Task<MailjetResponse> GetAsync(MailjetRequest request);
        Task<MailjetResponse> PostAsync(MailjetRequest request);
        Task<MailjetResponse> PutAsync(MailjetRequest request);
        Task<MailjetResponse> DeleteAsync(MailjetRequest request);
    }
}
