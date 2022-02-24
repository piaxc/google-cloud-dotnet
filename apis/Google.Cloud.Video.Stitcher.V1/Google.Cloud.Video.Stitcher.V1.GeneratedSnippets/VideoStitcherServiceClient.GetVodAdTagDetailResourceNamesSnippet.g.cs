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

namespace Google.Cloud.Video.Stitcher.V1.Snippets
{
    // [START videostitcher_v1_generated_VideoStitcherService_GetVodAdTagDetail_sync_flattened_resourceNames]
    using Google.Cloud.Video.Stitcher.V1;

    public sealed partial class GeneratedVideoStitcherServiceClientSnippets
    {
        /// <summary>Snippet for GetVodAdTagDetail</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetVodAdTagDetailResourceNames()
        {
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            VodAdTagDetailName name = VodAdTagDetailName.FromProjectLocationVodSessionVodAdTagDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_AD_TAG_DETAIL]");
            // Make the request
            VodAdTagDetail response = videoStitcherServiceClient.GetVodAdTagDetail(name);
        }
    }
    // [END videostitcher_v1_generated_VideoStitcherService_GetVodAdTagDetail_sync_flattened_resourceNames]
}