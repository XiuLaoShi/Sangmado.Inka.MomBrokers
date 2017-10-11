﻿using System;
using System.Collections.Generic;

namespace Sangmado.Inka.MomBrokers
{
    public interface IOutgoingMomChannel : IMomChannel
    {
        IMomBasicProperties CreateBasicProperties();

        void ConfirmSelect();
        void WaitForConfirmsOrDie();
        void WaitForConfirmsOrDie(TimeSpan timeout);

        void Publish(byte[] message);
        void Publish(byte[] message, string routingKey);
        void Publish(byte[] message, string routingKey, bool mandatory);
        void Publish(byte[] message, string routingKey, IDictionary<string, object> headers);
    }
}
