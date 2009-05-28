using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareTelephone
{
    internal class Config : IConfig
    {
        Properties.Settings mSettings;
        public Config(Properties.Settings setSettings)
        {
            mSettings = setSettings;
            if (mSettings.SavedConfigurationInformation == null)
            {
                mSettings.SavedConfigurationInformation = new System.Collections.Specialized.StringCollection();
                mSettings.Save();
            }
        }

        private int findSavedConfigurationInformation(string ForWhat)
        {
            if (mSettings.SavedConfigurationInformation == null)
            {
                throw (new Exception("mSettings.SavedConfigurationInformation is null"));
            }
            int travItems = 0;
            while (travItems < mSettings.SavedConfigurationInformation.Count)
            {
                char[] splitOn = { '|' };
                string[] Values = mSettings.SavedConfigurationInformation[travItems].Split(splitOn, StringSplitOptions.RemoveEmptyEntries);
                if (Values.Length != 2)
                {
                    mSettings.SavedConfigurationInformation.RemoveAt(travItems); // test if safe to do here
                    continue;
                }

                if (Values[0] == ForWhat)
                {
                    return travItems;
                }
                ++travItems;
            }
            return -1;
        }

        public string getSavedConfigurationInformation(string ForWhat)
        {
            if (mSettings.SavedConfigurationInformation == null)
            {
                throw (new Exception("mSettings.SavedConfigurationInformation is null"));
            }

            int ItemIndex = findSavedConfigurationInformation(ForWhat);
            if (ItemIndex != -1)
            {
                if (ItemIndex >= mSettings.SavedConfigurationInformation.Count)
                {
                    throw (new Exception("Invalid index from findSavedConfigurationInformation in getSavedConfigurationInformation, exceeds length"));
                }
                char[] splitOn = { '|' };
                string[] Values = mSettings.SavedConfigurationInformation[ItemIndex].Split(splitOn, StringSplitOptions.RemoveEmptyEntries);
                if (Values.Length == 2)
                {
                    if (Values[0] != ForWhat)
                    {
                        throw (new Exception("findSavedConfigurationInformation found incorrect entry"));
                    }
                    return Values[1];
                }
            }
            return String.Empty;
        }

        public void setSavedConfigurationInformation( string ForWhat, string Value)
        {
            if (mSettings.SavedConfigurationInformation == null)
            {
                throw (new Exception("SavedConfigurationInformation is null"));
            }

            int ItemIndex = findSavedConfigurationInformation(ForWhat);
            if (ItemIndex != -1)
            {
                if (ItemIndex >= mSettings.SavedConfigurationInformation.Count)
                {
                    throw (new Exception("Invalid index from findSavedConfigurationInformation in getSavedConfigurationInformation, exceeds length"));
                }
                mSettings.SavedConfigurationInformation[ItemIndex] = ForWhat + "|" + Value;
                mSettings.Save();
            }
            else
            {
                mSettings.SavedConfigurationInformation.Add(ForWhat + "|" + Value);
                mSettings.Save();
            }
        }
    }
}
