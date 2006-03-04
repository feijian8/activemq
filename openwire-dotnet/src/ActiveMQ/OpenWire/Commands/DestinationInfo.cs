/*
* Copyright 2006 The Apache Software Foundation or its licensors, as
* applicable.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*     http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.Collections;

using ActiveMQ.OpenWire;
using ActiveMQ.OpenWire.Commands;

namespace ActiveMQ.OpenWire.Commands
{
    //
    //  Marshalling code for Open Wire Format for DestinationInfo
    //
    //
    //  NOTE!: This file is autogenerated - do not modify!
    //         if you need to make a change, please see the Groovy scripts in the
    //         activemq-core module
    //
    public class DestinationInfo : BaseCommand
    {
        public const byte ID_DestinationInfo = 8;
    			
        ConnectionId connectionId;
        ActiveMQDestination destination;
        byte operationType;
        long timeout;
        BrokerId[] brokerPath;

		public override string ToString() {
            return GetType().Name + "["
                + " ConnectionId=" + ConnectionId
                + " Destination=" + Destination
                + " OperationType=" + OperationType
                + " Timeout=" + Timeout
                + " BrokerPath=" + BrokerPath
                + " ]";

		}
	


        public override byte GetDataStructureType() {
            return ID_DestinationInfo;
        }


        // Properties

        public ConnectionId ConnectionId
        {
            get { return connectionId; }
            set { this.connectionId = value; }            
        }

        public ActiveMQDestination Destination
        {
            get { return destination; }
            set { this.destination = value; }            
        }

        public byte OperationType
        {
            get { return operationType; }
            set { this.operationType = value; }            
        }

        public long Timeout
        {
            get { return timeout; }
            set { this.timeout = value; }            
        }

        public BrokerId[] BrokerPath
        {
            get { return brokerPath; }
            set { this.brokerPath = value; }            
        }

    }
}
