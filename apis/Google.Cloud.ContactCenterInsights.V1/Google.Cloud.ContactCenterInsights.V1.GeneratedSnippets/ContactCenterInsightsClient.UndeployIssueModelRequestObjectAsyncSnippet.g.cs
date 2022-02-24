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

namespace Google.Cloud.ContactCenterInsights.V1.Snippets
{
    // [START contactcenterinsights_v1_generated_ContactCenterInsights_UndeployIssueModel_async]
    using Google.Cloud.ContactCenterInsights.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedContactCenterInsightsClientSnippets
    {
        /// <summary>Snippet for UndeployIssueModelAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task UndeployIssueModelRequestObjectAsync()
        {
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            UndeployIssueModelRequest request = new UndeployIssueModelRequest
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            // Make the request
            Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> response = await contactCenterInsightsClient.UndeployIssueModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UndeployIssueModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceUndeployIssueModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployIssueModelResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END contactcenterinsights_v1_generated_ContactCenterInsights_UndeployIssueModel_async]
}