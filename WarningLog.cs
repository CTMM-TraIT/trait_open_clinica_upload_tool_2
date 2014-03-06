﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace OCDataImporter
{
    public class WarningMessage
    {
        public String messageText {get; set;}

        public String timeStamp { get; set; }        

        public WarningMessage(String messageText, String timeStamp)
        {
            this.messageText = messageText;
            this.timeStamp = timeStamp;
        }

        /// <summary>
        /// Checks if the warning message is equal to an other, based only on
        /// the message: the time stamp is ignored
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public override bool Equals(System.Object other)
        {
            if (other == null)
            {
                return false;
            }
            WarningMessage that = other as WarningMessage;
            if ((System.Object) that == null)
            {
                return false;
            }
            return (this.messageText == that.messageText);
        }

        public override int GetHashCode()
        {
            return messageText.GetHashCode();
        }
    }
    
    class WarningLog
    {
        private List<WarningMessage> warningMessageList;
        
        
        public WarningLog()
        {
            warningMessageList = new List<WarningMessage>();
        }

        public void reset()
        {
            warningMessageList.Clear();
        }

        public int getWarningCount()
        {
            return warningMessageList.Count;
        }

        public void appendMessage(String aMessageText)
        {                
            bool found = false;
            String timeStamp = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            WarningMessage messageToAdd = new WarningMessage(aMessageText, timeStamp);
            foreach (WarningMessage warningMessage in warningMessageList)
            {
                if (warningMessage.Equals(messageToAdd)) 
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                warningMessageList.Add(messageToAdd);                
            }
        }
    }
}
