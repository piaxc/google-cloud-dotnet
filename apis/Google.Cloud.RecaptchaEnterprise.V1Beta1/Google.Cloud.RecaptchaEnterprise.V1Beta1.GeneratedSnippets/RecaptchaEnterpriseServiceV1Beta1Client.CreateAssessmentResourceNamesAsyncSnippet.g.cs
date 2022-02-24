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

namespace Google.Cloud.RecaptchaEnterprise.V1Beta1.Snippets
{
    // [START recaptchaenterprise_v1beta1_generated_RecaptchaEnterpriseServiceV1Beta1_CreateAssessment_async_flattened_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.RecaptchaEnterprise.V1Beta1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedRecaptchaEnterpriseServiceV1Beta1ClientSnippets
    {
        /// <summary>Snippet for CreateAssessmentAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateAssessmentResourceNamesAsync()
        {
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = await RecaptchaEnterpriseServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Assessment assessment = new Assessment();
            // Make the request
            Assessment response = await recaptchaEnterpriseServiceV1Beta1Client.CreateAssessmentAsync(parent, assessment);
        }
    }
    // [END recaptchaenterprise_v1beta1_generated_RecaptchaEnterpriseServiceV1Beta1_CreateAssessment_async_flattened_resourceNames]
}