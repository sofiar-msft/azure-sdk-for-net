﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Storage.Blobs.Models;
using System;
using System.Collections.Generic;
using Metadata = System.Collections.Generic.IDictionary<string, string>;
using Tags = System.Collections.Generic.IDictionary<string, string>;

namespace Azure.Storage.DataMovement.Blobs
{
    /// <summary>
    /// Optional parameters for uploading to a
    /// BlockBlobStorageResource.
    ///
    /// When calling <see cref="BlockBlobStorageResource.WriteFromStreamAsync(System.IO.Stream, long, bool, long, long, Models.StorageResourceWriteToOffsetOptions, System.Threading.CancellationToken)"/>,
    /// and <see cref="BlockBlobStorageResource.CompleteTransferAsync(System.Threading.CancellationToken)"/>.
    /// These options will apply to the blob service requests to complete uploading to the block blob.
    /// </summary>
    public class BlockBlobStorageResourceUploadOptions
    {
        /// <summary>
        /// Optional standard HTTP header properties that can be set for the
        /// new block blob.
        /// </summary>
        public BlobHttpHeaders HttpHeaders { get; set; }

        /// <summary>
        /// Optional custom metadata to set for this block blob.
        /// For a sample code to set the metadata, see <see href="https://github.com/Azure/azure-sdk-for-net/blob/47ea075bca473fe6e9928ff9893fbaa8a552f3a5/sdk/storage/Azure.Storage.Blobs/samples/Sample03_Migrations.cs#L630">this </see>article.
        /// </summary>
#pragma warning disable CA2227 // Collection properties should be readonly
        public Metadata Metadata { get; set; }
#pragma warning restore CA2227 // Collection properties should be readonly

        /// <summary>
        /// Options tags to set for this block blob.
        /// </summary>
#pragma warning disable CA2227 // Collection properties should be readonly
        public Tags Tags { get; set; }
#pragma warning restore CA2227 // Collection properties should be readonly

        /// <summary>
        /// Optional. See <see cref="BlobRequestConditions"/> to add
        /// conditions on the upload of this block blob.
        /// </summary>
        public BlobRequestConditions Conditions { get; set; }

        /// <summary>
        /// Optional. See <see cref="AccessTier"/> to set on
        /// this block blob.
        /// </summary>
        public AccessTier? AccessTier { get; set; }

        /// <summary>
        /// Optional. See <see cref="BlobImmutabilityPolicy"/> to set on this block blob.
        /// Note that is parameter is only applicable to a blob within a container that
        /// has immutable storage with versioning enabled.
        /// </summary>
        public BlobImmutabilityPolicy ImmutabilityPolicy { get; set; }

        /// <summary>
        /// Optional. Indicates if a legal hold should be placed on the blob.
        /// Note that is parameter is only applicable to a blob within a container that
        /// has immutable storage with versioning enabled.
        /// </summary>
        public bool? LegalHold { get; set; }

        /// <summary>
        /// Options for transfer validation settings on this operation.
        /// When transfer validation options are set in the client, setting this parameter
        /// acts as an override.
        /// This operation does not allow <see cref="UploadTransferValidationOptions.PrecalculatedChecksum"/>
        /// to be set.
        /// </summary>
        public UploadTransferValidationOptions TransferValidationOptions { get; set; }
    }
}
