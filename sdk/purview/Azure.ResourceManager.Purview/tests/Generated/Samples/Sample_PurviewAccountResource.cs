// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Purview.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Purview
{
    public partial class Sample_PurviewAccountResource
    {
        // Accounts_ListBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetPurviewAccounts_AccountsListBySubscription()
        {
            // Generated from example definition: specification/purview/resource-manager/Microsoft.Purview/stable/2021-07-01/examples/Accounts_ListBySubscription.json
            // this example is just showing the usage of "Accounts_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (PurviewAccountResource item in subscriptionResource.GetPurviewAccountsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PurviewAccountData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Accounts_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_AccountsGet()
        {
            // Generated from example definition: specification/purview/resource-manager/Microsoft.Purview/stable/2021-07-01/examples/Accounts_Get.json
            // this example is just showing the usage of "Accounts_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this PurviewAccountResource created on azure
            // for more information of creating PurviewAccountResource, please refer to the document of PurviewAccountResource
            string subscriptionId = "12345678-1234-1234-12345678abc";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "account1";
            ResourceIdentifier purviewAccountResourceId = PurviewAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            PurviewAccountResource purviewAccount = client.GetPurviewAccountResource(purviewAccountResourceId);

            // invoke the operation
            PurviewAccountResource result = await purviewAccount.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PurviewAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Accounts_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_AccountsDelete()
        {
            // Generated from example definition: specification/purview/resource-manager/Microsoft.Purview/stable/2021-07-01/examples/Accounts_Delete.json
            // this example is just showing the usage of "Accounts_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this PurviewAccountResource created on azure
            // for more information of creating PurviewAccountResource, please refer to the document of PurviewAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "account1";
            ResourceIdentifier purviewAccountResourceId = PurviewAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            PurviewAccountResource purviewAccount = client.GetPurviewAccountResource(purviewAccountResourceId);

            // invoke the operation
            await purviewAccount.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Accounts_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_AccountsUpdate()
        {
            // Generated from example definition: specification/purview/resource-manager/Microsoft.Purview/stable/2021-07-01/examples/Accounts_Update.json
            // this example is just showing the usage of "Accounts_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this PurviewAccountResource created on azure
            // for more information of creating PurviewAccountResource, please refer to the document of PurviewAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "account1";
            ResourceIdentifier purviewAccountResourceId = PurviewAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            PurviewAccountResource purviewAccount = client.GetPurviewAccountResource(purviewAccountResourceId);

            // invoke the operation
            PurviewAccountPatch patch = new PurviewAccountPatch()
            {
                Tags =
{
["newTag"] = "New tag value.",
},
            };
            ArmOperation<PurviewAccountResource> lro = await purviewAccount.UpdateAsync(WaitUntil.Completed, patch);
            PurviewAccountResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PurviewAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Accounts_ListKeys
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetKeys_AccountsListKeys()
        {
            // Generated from example definition: specification/purview/resource-manager/Microsoft.Purview/stable/2021-07-01/examples/Accounts_ListKeys.json
            // this example is just showing the usage of "Accounts_ListKeys" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this PurviewAccountResource created on azure
            // for more information of creating PurviewAccountResource, please refer to the document of PurviewAccountResource
            string subscriptionId = "12345678-1234-1234-12345678abc";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "account1";
            ResourceIdentifier purviewAccountResourceId = PurviewAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            PurviewAccountResource purviewAccount = client.GetPurviewAccountResource(purviewAccountResourceId);

            // invoke the operation
            PurviewAccountAccessKey result = await purviewAccount.GetKeysAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // Accounts_AddRootCollectionAdmin
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task AddRootCollectionAdmin_AccountsAddRootCollectionAdmin()
        {
            // Generated from example definition: specification/purview/resource-manager/Microsoft.Purview/stable/2021-07-01/examples/Accounts_AddRootCollectionAdmin.json
            // this example is just showing the usage of "Accounts_AddRootCollectionAdmin" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this PurviewAccountResource created on azure
            // for more information of creating PurviewAccountResource, please refer to the document of PurviewAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "account1";
            ResourceIdentifier purviewAccountResourceId = PurviewAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            PurviewAccountResource purviewAccount = client.GetPurviewAccountResource(purviewAccountResourceId);

            // invoke the operation
            CollectionAdminUpdateContent content = new CollectionAdminUpdateContent()
            {
                AdminObjectId = "7e8de0e7-2bfc-4e1f-9659-2a5785e4356f",
            };
            await purviewAccount.AddRootCollectionAdminAsync(content);

            Console.WriteLine($"Succeeded");
        }

        // Accounts_CheckNameAvailability
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckPurviewAccountNameAvailability_AccountsCheckNameAvailability()
        {
            // Generated from example definition: specification/purview/resource-manager/Microsoft.Purview/stable/2021-07-01/examples/Accounts_CheckNameAvailability.json
            // this example is just showing the usage of "Accounts_CheckNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            PurviewAccountNameAvailabilityContent content = new PurviewAccountNameAvailabilityContent()
            {
                Name = "account1",
                ResourceType = "Microsoft.Purview/accounts",
            };
            PurviewAccountNameAvailabilityResult result = await subscriptionResource.CheckPurviewAccountNameAvailabilityAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
