// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Quota.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Quota.Samples
{
    public partial class Sample_GroupQuotaEntityResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GroupQuotasGetRequestForCompute()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/stable/2025-03-01/examples/GroupQuotas/GetGroupQuotas.json
            // this example is just showing the usage of "GroupQuotas_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GroupQuotaEntityResource created on azure
            // for more information of creating GroupQuotaEntityResource, please refer to the document of GroupQuotaEntityResource
            string managementGroupId = "E7EC67B3-7657-4966-BFFC-41EFD36BAA09";
            string groupQuotaName = "groupquota1";
            ResourceIdentifier groupQuotaEntityResourceId = GroupQuotaEntityResource.CreateResourceIdentifier(managementGroupId, groupQuotaName);
            GroupQuotaEntityResource groupQuotaEntity = client.GetGroupQuotaEntityResource(groupQuotaEntityResourceId);

            // invoke the operation
            GroupQuotaEntityResource result = await groupQuotaEntity.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GroupQuotaEntityData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_GroupQuotasDeleteRequestForCompute()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/stable/2025-03-01/examples/GroupQuotas/DeleteGroupQuotas.json
            // this example is just showing the usage of "GroupQuotas_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GroupQuotaEntityResource created on azure
            // for more information of creating GroupQuotaEntityResource, please refer to the document of GroupQuotaEntityResource
            string managementGroupId = "E7EC67B3-7657-4966-BFFC-41EFD36BAA09";
            string groupQuotaName = "groupquota1";
            ResourceIdentifier groupQuotaEntityResourceId = GroupQuotaEntityResource.CreateResourceIdentifier(managementGroupId, groupQuotaName);
            GroupQuotaEntityResource groupQuotaEntity = client.GetGroupQuotaEntityResource(groupQuotaEntityResourceId);

            // invoke the operation
            await groupQuotaEntity.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_GroupQuotasPatchRequestForCompute()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/stable/2025-03-01/examples/GroupQuotas/PatchGroupQuotas.json
            // this example is just showing the usage of "GroupQuotas_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GroupQuotaEntityResource created on azure
            // for more information of creating GroupQuotaEntityResource, please refer to the document of GroupQuotaEntityResource
            string managementGroupId = "E7EC67B3-7657-4966-BFFC-41EFD36BAA09";
            string groupQuotaName = "groupquota1";
            ResourceIdentifier groupQuotaEntityResourceId = GroupQuotaEntityResource.CreateResourceIdentifier(managementGroupId, groupQuotaName);
            GroupQuotaEntityResource groupQuotaEntity = client.GetGroupQuotaEntityResource(groupQuotaEntityResourceId);

            // invoke the operation
            GroupQuotaEntityPatch patch = new GroupQuotaEntityPatch
            {
                Properties = new GroupQuotasEntityPatchProperties
                {
                    DisplayName = "UpdatedGroupQuota1",
                },
            };
            ArmOperation<GroupQuotaEntityResource> lro = await groupQuotaEntity.UpdateAsync(WaitUntil.Completed, patch);
            GroupQuotaEntityResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GroupQuotaEntityData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetGroupQuotaLimitsRequests_GroupQuotaLimitsRequestList()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/stable/2025-03-01/examples/GroupQuotaLimitsRequests/GroupQuotaLimitsRequests_List.json
            // this example is just showing the usage of "GroupQuotaLimitsRequest_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GroupQuotaEntityResource created on azure
            // for more information of creating GroupQuotaEntityResource, please refer to the document of GroupQuotaEntityResource
            string managementGroupId = "E7EC67B3-7657-4966-BFFC-41EFD36BAA09";
            string groupQuotaName = "groupquota1";
            ResourceIdentifier groupQuotaEntityResourceId = GroupQuotaEntityResource.CreateResourceIdentifier(managementGroupId, groupQuotaName);
            GroupQuotaEntityResource groupQuotaEntity = client.GetGroupQuotaEntityResource(groupQuotaEntityResourceId);

            // invoke the operation and iterate over the result
            string resourceProviderName = "Microsoft.Compute";
            string filter = "location eq westus";
            await foreach (GroupQuotaRequestStatusResource item in groupQuotaEntity.GetGroupQuotaLimitsRequestsAsync(resourceProviderName, filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GroupQuotaRequestStatusData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
