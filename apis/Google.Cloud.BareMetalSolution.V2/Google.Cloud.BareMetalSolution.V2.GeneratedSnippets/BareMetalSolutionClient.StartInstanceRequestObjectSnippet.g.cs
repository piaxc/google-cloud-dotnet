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

namespace Google.Cloud.BareMetalSolution.V2.Snippets
{
    // [START baremetalsolution_v2_generated_BareMetalSolution_StartInstance_sync]
    using Google.Cloud.BareMetalSolution.V2;
    using Google.LongRunning;

    public sealed partial class GeneratedBareMetalSolutionClientSnippets
    {
        /// <summary>Snippet for StartInstance</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void StartInstanceRequestObject()
        {
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            StartInstanceRequest request = new StartInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Operation<StartInstanceResponse, OperationMetadata> response = bareMetalSolutionClient.StartInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<StartInstanceResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StartInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StartInstanceResponse, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceStartInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StartInstanceResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END baremetalsolution_v2_generated_BareMetalSolution_StartInstance_sync]
}