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

namespace Google.Cloud.ServiceManagement.V1.Snippets
{
    // [START servicemanagement_v1_generated_ServiceManager_GetServiceRollout_sync]
    using Google.Cloud.ServiceManagement.V1;

    public sealed partial class GeneratedServiceManagerClientSnippets
    {
        /// <summary>Snippet for GetServiceRollout</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetServiceRolloutRequestObject()
        {
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            GetServiceRolloutRequest request = new GetServiceRolloutRequest
            {
                ServiceName = "",
                RolloutId = "",
            };
            // Make the request
            Rollout response = serviceManagerClient.GetServiceRollout(request);
        }
    }
    // [END servicemanagement_v1_generated_ServiceManager_GetServiceRollout_sync]
}