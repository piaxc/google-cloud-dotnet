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

namespace Google.Cloud.OsConfig.V1.Snippets
{
    // [START osconfig_v1_generated_OsConfigZonalService_CreateOSPolicyAssignment_async]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.OsConfig.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedOsConfigZonalServiceClientSnippets
    {
        /// <summary>Snippet for CreateOSPolicyAssignmentAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateOSPolicyAssignmentRequestObjectAsync()
        {
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateOSPolicyAssignmentRequest request = new CreateOSPolicyAssignmentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OsPolicyAssignment = new OSPolicyAssignment(),
                OsPolicyAssignmentId = "",
            };
            // Make the request
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> response = await osConfigZonalServiceClient.CreateOSPolicyAssignmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OSPolicyAssignment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> retrievedResponse = await osConfigZonalServiceClient.PollOnceCreateOSPolicyAssignmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OSPolicyAssignment retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END osconfig_v1_generated_OsConfigZonalService_CreateOSPolicyAssignment_async]
}