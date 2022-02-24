// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Cloud.Spanner.Admin.Database.V1.Snippets
{
    // [START spanner_v1_generated_DatabaseAdmin_RestoreDatabase_async]
    using Google.Cloud.Spanner.Admin.Database.V1;
    using Google.Cloud.Spanner.Common.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedDatabaseAdminClientSnippets
    {
        /// <summary>Snippet for RestoreDatabaseAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task RestoreDatabaseRequestObjectAsync()
        {
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            RestoreDatabaseRequest request = new RestoreDatabaseRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                DatabaseId = "",
                BackupAsBackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
                EncryptionConfig = new RestoreDatabaseEncryptionConfig(),
            };
            // Make the request
            Operation<Database, RestoreDatabaseMetadata> response = await databaseAdminClient.RestoreDatabaseAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Database, RestoreDatabaseMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, RestoreDatabaseMetadata> retrievedResponse = await databaseAdminClient.PollOnceRestoreDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END spanner_v1_generated_DatabaseAdmin_RestoreDatabase_async]
}