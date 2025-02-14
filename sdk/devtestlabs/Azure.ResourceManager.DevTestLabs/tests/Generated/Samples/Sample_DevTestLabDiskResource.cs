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
using Azure.ResourceManager.DevTestLabs.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class Sample_DevTestLabDiskResource
    {
        // Disks_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DisksGet()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/Disks_Get.json
            // this example is just showing the usage of "Disks_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DevTestLabDiskResource created on azure
            // for more information of creating DevTestLabDiskResource, please refer to the document of DevTestLabDiskResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            string userName = "@me";
            string name = "{diskName}";
            ResourceIdentifier devTestLabDiskResourceId = DevTestLabDiskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, userName, name);
            DevTestLabDiskResource devTestLabDisk = client.GetDevTestLabDiskResource(devTestLabDiskResourceId);

            // invoke the operation
            DevTestLabDiskResource result = await devTestLabDisk.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevTestLabDiskData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Disks_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DisksDelete()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/Disks_Delete.json
            // this example is just showing the usage of "Disks_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DevTestLabDiskResource created on azure
            // for more information of creating DevTestLabDiskResource, please refer to the document of DevTestLabDiskResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            string userName = "{userId}";
            string name = "{diskName}";
            ResourceIdentifier devTestLabDiskResourceId = DevTestLabDiskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, userName, name);
            DevTestLabDiskResource devTestLabDisk = client.GetDevTestLabDiskResource(devTestLabDiskResourceId);

            // invoke the operation
            await devTestLabDisk.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Disks_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_DisksUpdate()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/Disks_Update.json
            // this example is just showing the usage of "Disks_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DevTestLabDiskResource created on azure
            // for more information of creating DevTestLabDiskResource, please refer to the document of DevTestLabDiskResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            string userName = "@me";
            string name = "diskName";
            ResourceIdentifier devTestLabDiskResourceId = DevTestLabDiskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, userName, name);
            DevTestLabDiskResource devTestLabDisk = client.GetDevTestLabDiskResource(devTestLabDiskResourceId);

            // invoke the operation
            DevTestLabDiskPatch patch = new DevTestLabDiskPatch()
            {
                Tags =
{
["tagName1"] = "tagValue1",
},
            };
            DevTestLabDiskResource result = await devTestLabDisk.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevTestLabDiskData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Disks_Attach
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Attach_DisksAttach()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/Disks_Attach.json
            // this example is just showing the usage of "Disks_Attach" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DevTestLabDiskResource created on azure
            // for more information of creating DevTestLabDiskResource, please refer to the document of DevTestLabDiskResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            string userName = "{userId}";
            string name = "{diskName}";
            ResourceIdentifier devTestLabDiskResourceId = DevTestLabDiskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, userName, name);
            DevTestLabDiskResource devTestLabDisk = client.GetDevTestLabDiskResource(devTestLabDiskResourceId);

            // invoke the operation
            DevTestLabDiskAttachContent content = new DevTestLabDiskAttachContent()
            {
                LeasedByLabVmId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourcegroups/resourceGroupName/providers/microsoft.devtestlab/labs/{labName}/virtualmachines/{vmName}"),
            };
            await devTestLabDisk.AttachAsync(WaitUntil.Completed, content);

            Console.WriteLine($"Succeeded");
        }

        // Disks_Detach
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Detach_DisksDetach()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/Disks_Detach.json
            // this example is just showing the usage of "Disks_Detach" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DevTestLabDiskResource created on azure
            // for more information of creating DevTestLabDiskResource, please refer to the document of DevTestLabDiskResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            string userName = "{userId}";
            string name = "{diskName}";
            ResourceIdentifier devTestLabDiskResourceId = DevTestLabDiskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, userName, name);
            DevTestLabDiskResource devTestLabDisk = client.GetDevTestLabDiskResource(devTestLabDiskResourceId);

            // invoke the operation
            DevTestLabDiskDetachContent content = new DevTestLabDiskDetachContent()
            {
                LeasedByLabVmId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourcegroups/myResourceGroup/providers/microsoft.devtestlab/labs/{labName}/virtualmachines/{vmName}"),
            };
            await devTestLabDisk.DetachAsync(WaitUntil.Completed, content);

            Console.WriteLine($"Succeeded");
        }
    }
}
