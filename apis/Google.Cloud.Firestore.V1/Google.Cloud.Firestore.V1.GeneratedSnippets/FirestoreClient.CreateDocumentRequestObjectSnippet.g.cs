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

namespace Google.Cloud.Firestore.V1.Snippets
{
    // [START firestore_v1_generated_Firestore_CreateDocument_sync]
    using Google.Cloud.Firestore.V1;

    public sealed partial class GeneratedFirestoreClientSnippets
    {
        /// <summary>Snippet for CreateDocument</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateDocumentRequestObject()
        {
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            CreateDocumentRequest request = new CreateDocumentRequest
            {
                Parent = "",
                CollectionId = "",
                DocumentId = "",
                Document = new Document(),
                Mask = new DocumentMask(),
            };
            // Make the request
            Document response = firestoreClient.CreateDocument(request);
        }
    }
    // [END firestore_v1_generated_Firestore_CreateDocument_sync]
}