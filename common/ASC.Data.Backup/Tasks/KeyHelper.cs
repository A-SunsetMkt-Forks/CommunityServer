/*
 *
 * (c) Copyright Ascensio System Limited 2010-2023
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * http://www.apache.org/licenses/LICENSE-2.0
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
*/


using System.IO;

using ASC.Data.Backup.Tasks.Modules;

namespace ASC.Data.Backup.Tasks
{
    internal static class KeyHelper
    {
        private const string Databases = "databases";

        public static string GetDumpKey()
        {
            return "dump";
        }

        public static string GetDatabaseSchema()
        {
            return string.Format("{0}/{1}", Databases, "scheme");
        }

        public static string GetDatabaseData()
        {
            return string.Format("{0}/{1}", Databases, "data");
        }

        public static string GetDatabaseSchema(string table)
        {
            return string.Format("{0}/{1}", GetDatabaseSchema(), table);
        }

        public static string GetDatabaseData(string table)
        {
            return string.Format("{0}/{1}", GetDatabaseData(), table);
        }

        public static string GetTableZipKey(IModuleSpecifics module, string tableName)
        {
            return string.Format("{0}/{1}/{2}", Databases, module.ConnectionStringName, tableName);
        }

        public static string GetZipKey(this BackupFileInfo file)
        {
            return Path.Combine(file.Module, file.Domain, file.Path);
        }

        public static string GetStorage()
        {
            return "storage";
        }
        public static string GetStorageRestoreInfoZipKey()
        {
            return string.Format("{0}/restore_info", GetStorage());
        }

        public static string GetMailTableZipKey(string tableName)
        {
            return string.Format("mailtable/{0}", tableName);
        }
    }
}
